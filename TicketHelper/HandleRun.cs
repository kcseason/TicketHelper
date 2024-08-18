using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using System.IO.Compression;
using System.Text;
using System.Text.RegularExpressions;
using TicketHelper.DBO;
using TicketHelper.Entity;
using TicketHelper.String;

namespace TicketHelper
{
    internal class RunHelper
    {
        public void HandleTicket()
        {
            // 清空
            DBItinerary.DeleteAll();

            // 解压缩
            this.UnZipFiles();

            // 遍历pdf读取内容
            this.ReadPDF();
        }

        /// <summary>
        /// 解压缩
        /// </summary>
        /// <returns></returns>
        private bool UnZipFiles()
        {
            try
            {
                var currentPath = Directory.GetCurrentDirectory();
                var zipFiles = Directory.GetFiles(Path.Combine(currentPath, "TicketFiles"), "*.zip");
                var newFolder = Program.configuration["FolderName:OriginalTicket"];
                var newPath = Path.Combine(currentPath, newFolder);

                //if (Directory.Exists(newPath))
                //    Directory.Delete(newPath, true);

                foreach (var file in zipFiles)
                    ZipFile.ExtractToDirectory(file, newFolder, Encoding.GetEncoding("GBK"));

                return true;
            }
            catch { return false; }
        }

        private void ReadPDF()
        {
            Program.log.Info("开始读取pdf文件。");

            var currentPath = Directory.GetCurrentDirectory();
            var originalTicketFolder = Program.configuration["FolderName:OriginalTicket"];
            var completedTicketFolder = Program.configuration["FolderName:CompletedTicket"];

            if (Directory.Exists(completedTicketFolder))
            {
                Directory.Delete(Path.Combine(completedTicketFolder), true);
                Program.log.Info("删除文件夹：" + completedTicketFolder);
            }

            var newPath = Path.Combine(currentPath, originalTicketFolder);
            var pdfFiles = Directory.GetFiles(newPath, "行程单*.pdf");
            Program.log.Info("遍历文件夹：" + newPath);

            foreach (var file in pdfFiles)
            {
                var itinerary = new Itinerary();
                var text = new StringBuilder();
                using (PdfReader reader = new PdfReader(file))
                {
                    Program.log.Info("读取pdf文件：" + file);
                    using (PdfDocument doc = new PdfDocument(reader))
                    {
                        for (int page = 1; page <= doc.GetNumberOfPages(); page++)
                        {
                            var currentText = string.Empty;
                            currentText = PdfTextExtractor.GetTextFromPage(doc.GetPage(page));
                            currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)));
                            text.Append(currentText);
                        }

                        Program.log.Info("读取pdf文件内容：" + text);

                        var date = RegexMatchDate(text.ToString());
                        Program.log.Info("读取行程日期：" + date);
                        if (date == null || string.IsNullOrEmpty(date))
                            Program.log.Error("获取行程日期失败：" + file);

                        var location = RegexMatchLocation(text.ToString());
                        Program.log.Info("读取行程地点：" + location);
                        if (location == null || string.IsNullOrEmpty(location))
                            Program.log.Error("获取行程地点失败：" + file);

                        var company = RegexMatchCompany(text.ToString());
                        Program.log.Info("读取出行公司：" + company);
                        if (company == null || string.IsNullOrEmpty(company))
                            Program.log.Error("获取出行公司失败：" + file);

                        var cost = RegexMatchCost(text.ToString());
                        Program.log.Info("读取行程花费：" + cost);
                        if (cost == null || string.IsNullOrEmpty(cost))
                            Program.log.Error("获取行程花费失败：" + file);

                        var positions = GetPosition(text.ToString());
                        Program.log.Info("读取上车地点：" + (positions.Count > 0 ? positions[0].Item2 : null));
                        Program.log.Info("读取下车地点：" + (positions.Count > 1 ? positions[1]?.Item2 : null));
                        if (positions == null || positions.Count == 0 || positions.Count == 1)
                            Program.log.Error("获取上下车地点失败：" + file);

                        var newFolderName = string.Join(" ", [date, location, company, cost]);
                        var newCopyPath = Path.Combine(completedTicketFolder, newFolderName);
                        Directory.CreateDirectory(Path.Combine(newCopyPath));

                        var fi = new FileInfo(file);
                        File.Copy(file, Path.Combine(newCopyPath, fi.Name), true);
                        Program.log.Info("复制pdf文件：" + file + " 到 " + Path.Combine(newCopyPath, fi.Name));

                        itinerary.DateTime = Convert.ToDateTime(date);
                        itinerary.Cost = Convert.ToDecimal(cost);
                        itinerary.CompanyType = company;
                        itinerary.LocationName = location;
                        itinerary.TicketType = TicketType.Taxi;
                        itinerary.Start = positions.Count > 0 ? positions[0].Item2 : null;
                        itinerary.End = positions.Count > 1 ? positions[1]?.Item2 : null;

                        DBItinerary.Add(itinerary);
                        Program.log.Info("写入数据库文件Id：" + itinerary.Id);
                    }
                }
            }
        }

        private string RegexMatchDate(string text)
        {
            string pattern = Program.configuration["RegexExpression:Date"];
            var rg = new Regex(pattern);
            var result = rg.Matches(text).FirstOrDefault().Value;
            if (result.Length == 10)
                return result;

            return null;
        }

        private string RegexMatchLocation(string text)
        {
            string pattern = Program.configuration["RegexExpression:Location"];
            var rg = new Regex(pattern);
            var result = rg.Matches(text).FirstOrDefault().Value;
            result = result.Replace("市", "");

            return result;
        }

        private string RegexMatchCost(string text)
        {
            string pattern = Program.configuration["RegexExpression:Cost"];
            var rg = new Regex(pattern);
            var result = rg.Matches(text).FirstOrDefault().Value;

            return result;
        }

        private string RegexMatchCompany(string text)
        {
            string pattern = Program.configuration["RegexExpression:Company"];
            var rg = new Regex(pattern);
            var result = rg.Matches(text);
            if (result.Count == 0)
                return CompanyType.Other;
            else
            {
                var result2 = rg.Matches(text).FirstOrDefault().Value;
                if (result2.Length == 4)
                    return result2.Substring(0, 2);
            }

            return CompanyType.Other;
        }

        private List<Tuple<int, string>> GetPosition(string text)
        {
            List<Tuple<int, string>> match = new List<Tuple<int, string>>();
            DBPosition.PositionList.ForEach(position =>
            {
                if (text.Contains(position.PositionName))
                {
                    var result = Tuple.Create(text.IndexOf(position.PositionName), position.PositionName);
                    match.Add(result);
                }
            });

            match = match.OrderBy(x => x.Item1).ToList();

            //if (match.Count == 0 || match.Count == 1)
            //{ 

            //}

            //if (match.Count == 2 && match[0].Item2.Trim().Equals(string.Empty))
            //{ 

            //}

            return match;
        }
    }
}
