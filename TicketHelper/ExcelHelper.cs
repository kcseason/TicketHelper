using ClosedXML.Excel;
using TicketHelper.Model;

namespace TicketHelper
{
    internal static class ExcelHelper<T> where T : ModelBase
    {
        private static List<string> titleList = ["交通出行", "酒店住宿", "医院看病"];

        public static void ExportListToExcel(List<List<T>> dataList, string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet1 = workbook.Worksheets.Add(titleList[0]);
                ExportItinerray(dataList[0], worksheet1);

                var worksheet2 = workbook.Worksheets.Add(titleList[1]);
                ExportHotel(dataList[1], worksheet2);

                var worksheet3 = workbook.Worksheets.Add(titleList[2]);
                ExportHospital(dataList[2], worksheet3);

                // 保存Excel文件
                workbook.SaveAs(filePath);
            }
        }

        private static bool ExportItinerray(List<T> list, IXLWorksheet worksheet)
        {
            try
            {
                var itineraryList = list.Cast<T>().Cast<Itinerary>();
                int currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "合计：";
                worksheet.Cell(currentRow, 2).Value = itineraryList.Sum(x => x.Cost).ToString(); ;
                currentRow++;
                // 添加标题行
                worksheet.Cell(currentRow, 1).Value = "行程日期";
                worksheet.Cell(currentRow, 2).Value = "城市";
                worksheet.Cell(currentRow, 3).Value = "开始地点";
                worksheet.Cell(currentRow, 4).Value = "结束地点";
                worksheet.Cell(currentRow, 5).Value = "花费(元)";
                worksheet.Cell(currentRow, 6).Value = "交通公司";
                worksheet.Cell(currentRow, 7).Value = "票据类型";
                worksheet.Cell(currentRow, 8).Value = "发票";
                worksheet.Cell(currentRow, 9).Value = "行程单";
                worksheet.Cell(currentRow, 10).Value = "费用类型";
                worksheet.Cell(currentRow, 11).Value = "备注";

                // 填充数据
                foreach (var item in itineraryList)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.StartDate.ToString("yyyy-MM-dd");
                    worksheet.Cell(currentRow, 2).Value = item.CityName;
                    worksheet.Cell(currentRow, 3).Value = item.Start;
                    worksheet.Cell(currentRow, 4).Value = item.End;
                    worksheet.Cell(currentRow, 5).Value = item.Cost;
                    worksheet.Cell(currentRow, 6).Value = item.CompanyType;
                    worksheet.Cell(currentRow, 7).Value = item.TicketType;
                    worksheet.Cell(currentRow, 8).Value = item.HasTicket;
                    worksheet.Cell(currentRow, 9).Value = item.HasDetail;
                    worksheet.Cell(currentRow, 10).Value = item.FeeType;
                    worksheet.Cell(currentRow, 11).Value = item.Remark;
                }

                // 调整列宽
                worksheet.Columns().AdjustToContents();

            }
            catch
            {
                return false;
            }

            return true;
        }

        private static bool ExportHotel(List<T> list, IXLWorksheet worksheet)
        {
            try
            {
                var hotelList = list.Cast<T>().Cast<Hotel>();
                int currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "合计：";
                worksheet.Cell(currentRow, 2).Value = hotelList.Sum(x => x.Cost).ToString(); ;
                currentRow++;
                // 添加标题行
                worksheet.Cell(currentRow, 1).Value = "城市";
                worksheet.Cell(currentRow, 2).Value = "住宿地点";
                worksheet.Cell(currentRow, 3).Value = "开始时间";
                worksheet.Cell(currentRow, 4).Value = "结束时间";
                worksheet.Cell(currentRow, 5).Value = "费用(元)";
                worksheet.Cell(currentRow, 6).Value = "电子发票";
                worksheet.Cell(currentRow, 7).Value = "纸质发票";
                worksheet.Cell(currentRow, 8).Value = "费用类型";
                worksheet.Cell(currentRow, 9).Value = "备注";

                // 填充数据
                foreach (var item in hotelList)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.CityName;
                    worksheet.Cell(currentRow, 2).Value = item.HotelName;
                    worksheet.Cell(currentRow, 3).Value = item.StartDate.ToString("yyyy-MM-dd");
                    worksheet.Cell(currentRow, 4).Value = item.EndDate.ToString("yyyy-MM-dd"); ;
                    worksheet.Cell(currentRow, 5).Value = item.Cost;
                    worksheet.Cell(currentRow, 6).Value = item.HasETicket;
                    worksheet.Cell(currentRow, 7).Value = item.HasTicket;
                    worksheet.Cell(currentRow, 8).Value = item.FeeType;
                    worksheet.Cell(currentRow, 9).Value = item.Remark;
                }

                // 调整列宽
                worksheet.Columns().AdjustToContents();
            }
            catch
            {
                return false;
            }

            return true;
        }

        private static bool ExportHospital(List<T> list, IXLWorksheet worksheet)
        {
            try
            {
                var hospitalList = list.Cast<T>().Cast<HospitalPatient>();
                int currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "合计：";
                worksheet.Cell(currentRow, 2).Value = hospitalList.Sum(x => x.Cost).ToString(); ;
                currentRow++;
                // 添加标题行
                worksheet.Cell(currentRow, 1).Value = "城市";
                worksheet.Cell(currentRow, 3).Value = "开始时间";
                worksheet.Cell(currentRow, 4).Value = "结束时间";
                worksheet.Cell(currentRow, 4).Value = "医院名称";
                worksheet.Cell(currentRow, 4).Value = "就诊类型";
                worksheet.Cell(currentRow, 4).Value = "门诊病历";
                worksheet.Cell(currentRow, 7).Value = "纸质发票";
                worksheet.Cell(currentRow, 6).Value = "费用清单";
                worksheet.Cell(currentRow, 6).Value = "B超报告";
                worksheet.Cell(currentRow, 6).Value = "CT报告";
                worksheet.Cell(currentRow, 6).Value = "MR报告";
                worksheet.Cell(currentRow, 5).Value = "费用(元)";
                worksheet.Cell(currentRow, 8).Value = "费用类型";
                worksheet.Cell(currentRow, 9).Value = "备注";

                // 填充数据
                foreach (var item in hospitalList)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.CityName;
                    worksheet.Cell(currentRow, 3).Value = item.StartDate.ToString("yyyy-MM-dd");
                    worksheet.Cell(currentRow, 4).Value = item.EndDate.ToString("yyyy-MM-dd");
                    worksheet.Cell(currentRow, 1).Value = item.HospitalName;
                    worksheet.Cell(currentRow, 1).Value = item.PatientType;
                    worksheet.Cell(currentRow, 1).Value = item.HasPatientRecord;
                    worksheet.Cell(currentRow, 1).Value = item.HasPatientTicket;
                    worksheet.Cell(currentRow, 1).Value = item.HasPatientDetail;
                    worksheet.Cell(currentRow, 1).Value = item.HasBChaoReport;
                    worksheet.Cell(currentRow, 1).Value = item.HasCTReport;
                    worksheet.Cell(currentRow, 1).Value = item.HasMRReport;
                    worksheet.Cell(currentRow, 5).Value = item.Cost;
                    worksheet.Cell(currentRow, 8).Value = item.FeeType;
                    worksheet.Cell(currentRow, 9).Value = item.Remark;
                }

                // 调整列宽
                worksheet.Columns().AdjustToContents();
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
