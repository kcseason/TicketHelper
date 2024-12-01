using LoadingIndicator.WinForms;
using TicketHelper.DBO;
using TicketHelper.Handler;
using TicketHelper.Model;
using TicketHelper.String;
using TicketHelper.TicketEnum;

namespace TicketHelper
{
    public partial class MainForm : Form
    {
        private bool IsLoad = true;
        private bool IsAsc = true;
        private LongOperation _longOperation;

        private CurrentModule currentModuel = CurrentModule.None;
        private Dictionary<string, object> CurrentListDic = new Dictionary<string, object>();
        private List<Itinerary> CurrentItineraryList = new List<Itinerary>();
        private List<Hotel> CurrentHotelList = new List<Hotel>();
        private List<HospitalPatient> CurrentHospitalPatientList = new List<HospitalPatient>();
        public MainForm()
        {
            InitializeComponent();

            var settings = LongOperationSettings.Default
                                            .WithBoxIndicator(boxSettings =>
                                            {
                                                boxSettings.NumberOfBoxes = 5;
                                            })
                                            .AllowStopBeforeStartMethods();
            _longOperation = new LongOperation(this, settings);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitSearchPanel();
            IsLoad = false;
            this.Focus();
        }

        private void tdb_Run_Click(object sender, EventArgs e)
        {
            var runHelper = new RunHelper();
            runHelper.HandleTicket();

            tsbTraffic_Click(null, null);
        }

        private void InitSearchPanel()
        {
            cbCity.Nodes.Clear();
            CityName.CityList.ForEach(city => { cbCity.Nodes.Add(city); });

            cbCompany.Nodes.Clear();
            CompanyType.CompanyList.ForEach(com => { cbCompany.Nodes.Add(com); });

            cbTicketType.Nodes.Clear();
            if (currentModuel == CurrentModule.Itinerary)
                TicketType.TicketTypes.ForEach(ticket => { cbTicketType.Nodes.Add(ticket); });
            else
                FeeType.HotelFeeTypes.ForEach(fee => { cbTicketType.Nodes.Add(fee); });

            switch (currentModuel)
            {
                case CurrentModule.Itinerary: cbCalcTotal.DataSource = CalcTotalType.ItineraryTypes; break;
                case CurrentModule.Hotel: cbCalcTotal.DataSource = CalcTotalType.HotelTypes; break;
                case CurrentModule.Hospital: cbCalcTotal.DataSource = CalcTotalType.HospitalPatientTypes; break;
                default: break;
            }
        }

        private void Search(object sender, EventArgs e)
        {
            if (IsLoad)
                return;

            if (currentModuel == CurrentModule.Itinerary)
            {
                string start = dtStart.Value.Date.ToString("yyyy-MM-dd");
                string end = dtEnd.Value.Date.ToString("yyyy-MM-dd");
                var city = cbCity.Text.Split(";").ToList().Where(x => !string.IsNullOrEmpty(x.Trim())).Select(y => "'" + y.Trim() + "'").ToList();
                var cityStr = string.Join(",", city);
                var company = cbCompany.Text.Split(";").ToList().Where(x => !string.IsNullOrEmpty(x.Trim())).Select(y => "'" + y.Trim() + "'").ToList();
                var companyStr = string.Join(",", company);
                var ticketType = cbTicketType.Text.Split(";").ToList().Where(x => !string.IsNullOrEmpty(x.Trim())).Select(y => "'" + y.Trim() + "'").ToList();
                var ticketTypeStr = string.Join(",", ticketType);

                var pams = new object[] { start, end, cityStr, companyStr, ticketTypeStr };
                var list = new SQLiteDBItinerary<Itinerary>().QueryTable(pams);

                if (!CurrentListDic.ContainsKey("Itinerary"))
                    CurrentListDic.Add("Itinerary", list);
                else
                    CurrentListDic["Itinerary"] = list;

                GvItinerary.DataSource = list;
                tbTotalMoney.Text = list.Sum(x => x.Cost).ToString();
                lbCount.Text = list.Count().ToString();
            }

            if (currentModuel == CurrentModule.Hotel)
            {
                string start = dtStart.Value.Date.ToString("yyyy-MM-dd");
                string end = dtEnd.Value.Date.ToString("yyyy-MM-dd");
                var city = cbCity.Text;
                var feeType = cbTicketType.Text;

                var pams = new object[] { start, end, city, feeType };
                var list = new SQLiteDBHotel<Hotel>().QueryTable(pams);

                if (!CurrentListDic.ContainsKey("Hotel"))
                    CurrentListDic.Add("Hotel", list);
                else
                    CurrentListDic["Hotel"] = list;

                GvItinerary.DataSource = list;
                tbTotalMoney.Text = list.Sum(x => x.Cost).ToString();
                lbCount.Text = list.Count().ToString();
            }
            if (currentModuel == CurrentModule.Hospital)
            {
                string start = dtStart.Value.Date.ToString("yyyy-MM-dd");
                string end = dtEnd.Value.Date.ToString("yyyy-MM-dd");
                var city = cbCity.Text;
                var company = cbCompany.Text;
                var ticketType = cbTicketType.Text;

                var pams = new object[] { start, end, city, company, ticketType };
                var list = new SQLiteDBHospitalPatient<HospitalPatient>().QueryTable(pams);

                if (!CurrentListDic.ContainsKey("HospitalPatient"))
                    CurrentListDic.Add("HospitalPatient", list);
                else
                    CurrentListDic["HospitalPatient"] = list;

                GvItinerary.DataSource = list;
                tbTotalMoney.Text = list.Sum(x => x.Cost).ToString();
                lbCount.Text = list.Count().ToString();
            }

            CalcTotal(null, null);
        }

        private void CalcTotal(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbCalcTotal.Text))
                return;

            var modelName = Enum.GetName(currentModuel);
            var list = currentModuel == CurrentModule.Itinerary ? CurrentListDic[modelName] as List<Itinerary> : null;

            if (cbCalcTotal.Text.Equals(CalcTotalType.Year))
            {
                var calcResult = list.GroupBy(item => (DateTime.Parse(item.StartDate)).Year).Select(group => new { StartDate = group.Key + "年", Cost = group.Sum(item => item.Cost) }).ToList();

                GvItinerary.DataSource = null;
                GvItinerary.DataSource = calcResult;
                tbTotalMoney.Text = calcResult.Sum(x => x.Cost).ToString();
            }
            if (cbCalcTotal.Text.Equals(CalcTotalType.Month))
            {
                var calcResult = list.GroupBy(item => (DateTime.Parse(item.StartDate)).ToString("yyyy年-MM月")).Select(group => new { StartDate = group.Key, Cost = group.Sum(item => item.Cost) }).ToList();

                GvItinerary.DataSource = null;
                GvItinerary.DataSource = calcResult;
                tbTotalMoney.Text = calcResult.Sum(x => x.Cost).ToString();
            }
            if (cbCalcTotal.Text.Equals(CalcTotalType.Company))
            {
                var calcResult = list.GroupBy(item => item.CompanyType).Select(group => new { CompanyType = group.Key, Cost = group.Sum(item => item.Cost) }).ToList();

                GvItinerary.DataSource = null;
                GvItinerary.DataSource = calcResult;
                tbTotalMoney.Text = calcResult.Sum(x => x.Cost).ToString();
            }
            if (cbCalcTotal.Text.Equals(CalcTotalType.City))
            {
                var calcResult = list.GroupBy(item => item.CityName).Select(group => new { CityName = group.Key, Cost = group.Sum(item => item.Cost) }).ToList();

                GvItinerary.DataSource = null;
                GvItinerary.DataSource = calcResult;
                tbTotalMoney.Text = calcResult.Sum(x => x.Cost).ToString();
            }
            if (cbCalcTotal.Text.Equals(CalcTotalType.Ticket))
            {
                var calcResult = list.GroupBy(item => item.TicketType).Select(group => new { TicketType = group.Key, Cost = group.Sum(item => item.Cost) }).ToList();

                GvItinerary.DataSource = null;
                GvItinerary.DataSource = calcResult;
                tbTotalMoney.Text = calcResult.Sum(x => x.Cost).ToString();
            }
        }

        private async void tdbDataInit_Click(object sender, EventArgs e)
        {
            using (_longOperation.Start(false))
                await DoSomethingLongAsync();
        }

        private async Task DoSomethingLongAsync()
        {
            PositionHandler.DataInit();
            ItineraryHandler.DataInit();
            HotelHandler.DataInit();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GvItinerary_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (currentModuel == CurrentModule.Itinerary)
            {
                if (!string.IsNullOrEmpty(cbCalcTotal.Text))
                {
                    if (cbCalcTotal.Text.Equals(CalcTotalType.Year))
                    {
                        GvItinerary.Columns["StartDate"].HeaderText = "行程日期";
                        GvItinerary.Columns["StartDate"].DisplayIndex = 0;
                        GvItinerary.Columns["StartDate"].Width = 250;
                        GvItinerary.Columns["StartDate"].SortMode = DataGridViewColumnSortMode.Automatic;
                        GvItinerary.Columns["Cost"].HeaderText = "花费(元)";
                        GvItinerary.Columns["Cost"].DefaultCellStyle.Format = "N";
                        GvItinerary.Columns["Cost"].Width = 350;
                    }
                    else if (cbCalcTotal.Text.Equals(CalcTotalType.Month))
                    {
                        GvItinerary.Columns["StartDate"].HeaderText = "行程日期";
                        GvItinerary.Columns["StartDate"].DisplayIndex = 0;
                        GvItinerary.Columns["StartDate"].Width = 250;
                        GvItinerary.Columns["StartDate"].SortMode = DataGridViewColumnSortMode.Automatic;
                        GvItinerary.Columns["Cost"].HeaderText = "花费(元)";
                        GvItinerary.Columns["Cost"].DefaultCellStyle.Format = "N";
                        GvItinerary.Columns["Cost"].Width = 350;
                    }
                    else if (cbCalcTotal.Text.Equals(CalcTotalType.Company))
                    {
                        GvItinerary.Columns["CompanyType"].HeaderText = "出行公司";
                        GvItinerary.Columns["CompanyType"].DisplayIndex = 0;
                        GvItinerary.Columns["CompanyType"].Width = 250;
                        GvItinerary.Columns["CompanyType"].SortMode = DataGridViewColumnSortMode.Automatic;
                        GvItinerary.Columns["Cost"].HeaderText = "花费(元)";
                        GvItinerary.Columns["Cost"].DefaultCellStyle.Format = "N";
                        GvItinerary.Columns["Cost"].Width = 350;
                    }
                    else if (cbCalcTotal.Text.Equals(CalcTotalType.City))
                    {
                        GvItinerary.Columns["CityName"].HeaderText = "城市";
                        GvItinerary.Columns["CityName"].DisplayIndex = 0;
                        GvItinerary.Columns["CityName"].Width = 250;
                        GvItinerary.Columns["CityName"].SortMode = DataGridViewColumnSortMode.Automatic;
                        GvItinerary.Columns["Cost"].HeaderText = "花费(元)";
                        GvItinerary.Columns["Cost"].DefaultCellStyle.Format = "N";
                        GvItinerary.Columns["Cost"].Width = 350;
                    }
                    else if (cbCalcTotal.Text.Equals(CalcTotalType.Ticket))
                    {
                        GvItinerary.Columns["TicketType"].HeaderText = "票类";
                        GvItinerary.Columns["TicketType"].DisplayIndex = 0;
                        GvItinerary.Columns["TicketType"].Width = 250;
                        GvItinerary.Columns["TicketType"].SortMode = DataGridViewColumnSortMode.Automatic;
                        GvItinerary.Columns["Cost"].HeaderText = "花费(元)";
                        GvItinerary.Columns["Cost"].DefaultCellStyle.Format = "N";
                        GvItinerary.Columns["Cost"].Width = 350;
                    }
                    return;
                }

                //设置显示的列名
                GvItinerary.Columns["Id"].Visible = false;
                GvItinerary.Columns["StartDate"].HeaderText = "行程日期";
                GvItinerary.Columns["StartDate"].DisplayIndex = 0;
                GvItinerary.Columns["StartDate"].SortMode = DataGridViewColumnSortMode.Automatic;
                GvItinerary.Columns["StartDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                GvItinerary.Columns["EndDate"].Visible = false;
                GvItinerary.Columns["Start"].HeaderText = "开始地点";
                GvItinerary.Columns["Start"].Width = 270;
                GvItinerary.Columns["End"].HeaderText = "结束地点";
                GvItinerary.Columns["End"].Width = 270;
                GvItinerary.Columns["Cost"].HeaderText = "花费(元)";
                GvItinerary.Columns["Cost"].DefaultCellStyle.Format = "N";
                GvItinerary.Columns["CityName"].HeaderText = "城市";
                GvItinerary.Columns["CityName"].Width = 100;
                GvItinerary.Columns["CityName"].DisplayIndex = 1;
                GvItinerary.Columns["CompanyType"].HeaderText = "交通公司";
                GvItinerary.Columns["TicketType"].HeaderText = "票据类型";
                GvItinerary.Columns["FeeType"].HeaderText = "费用类型";
                GvItinerary.Columns["FeeType"].Width = 150;
                GvItinerary.Columns["HasTicket"].HeaderText = "发票";
                GvItinerary.Columns["HasTicket"].Width = 100;
                GvItinerary.Columns["HasDetail"].HeaderText = "行程单";
                GvItinerary.Columns["HasDetail"].Width = 100;
                GvItinerary.Columns["ItineraryNO"].HeaderText = "车次/航班";
                GvItinerary.Columns["Remark"].HeaderText = "备注";
                GvItinerary.Columns["Remark"].Width = 280;
            }
            if (currentModuel == CurrentModule.Hotel)
            {
                //设置显示的列名
                GvItinerary.Columns["Id"].Visible = false;
                GvItinerary.Columns["CityName"].HeaderText = "城市";
                GvItinerary.Columns["CityName"].Width = 100;
                GvItinerary.Columns["CityName"].DisplayIndex = 0;
                GvItinerary.Columns["HotelName"].HeaderText = "住宿地点";
                GvItinerary.Columns["HotelName"].Width = 200;
                GvItinerary.Columns["HotelName"].DisplayIndex = 1;
                GvItinerary.Columns["StartDate"].HeaderText = "开始时间";
                GvItinerary.Columns["StartDate"].DisplayIndex = 2;
                GvItinerary.Columns["StartDate"].SortMode = DataGridViewColumnSortMode.Automatic;
                GvItinerary.Columns["StartDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                GvItinerary.Columns["EndDate"].HeaderText = "结束时间";
                GvItinerary.Columns["EndDate"].DisplayIndex = 3;
                GvItinerary.Columns["EndDate"].SortMode = DataGridViewColumnSortMode.Automatic;
                GvItinerary.Columns["EndDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                GvItinerary.Columns["Cost"].HeaderText = "费用(元)";
                GvItinerary.Columns["Cost"].DefaultCellStyle.Format = "N";
                GvItinerary.Columns["Cost"].DisplayIndex = 4;
                GvItinerary.Columns["HasETicket"].HeaderText = "电子发票";
                GvItinerary.Columns["HasETicket"].Width = 120;
                GvItinerary.Columns["HasETicket"].DisplayIndex = 5;
                GvItinerary.Columns["HasTicket"].HeaderText = "纸质发票";
                GvItinerary.Columns["HasTicket"].Width = 120;
                GvItinerary.Columns["HasTicket"].DisplayIndex = 6;
                GvItinerary.Columns["FeeType"].HeaderText = "费用类型";
                GvItinerary.Columns["FeeType"].DisplayIndex = 7;
                GvItinerary.Columns["Remark"].HeaderText = "备注";
                GvItinerary.Columns["Remark"].Width = 280;
            }
            if (currentModuel == CurrentModule.Hospital)
            {
                //设置显示的列名
                GvItinerary.Columns["Id"].Visible = false;
                GvItinerary.Columns["CityName"].HeaderText = "城市";
                GvItinerary.Columns["CityName"].DisplayIndex = 0;
                GvItinerary.Columns["HospitalName"].HeaderText = "医院名称";
                GvItinerary.Columns["StartDate"].HeaderText = "开始时间";
                GvItinerary.Columns["StartDate"].DisplayIndex = 1;
                GvItinerary.Columns["StartDate"].SortMode = DataGridViewColumnSortMode.Automatic;
                GvItinerary.Columns["StartDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                GvItinerary.Columns["EndDate"].HeaderText = "结束时间";
                GvItinerary.Columns["EndDate"].DisplayIndex = 2;
                GvItinerary.Columns["EndDate"].SortMode = DataGridViewColumnSortMode.Automatic;
                GvItinerary.Columns["EndDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                GvItinerary.Columns["PatientType"].HeaderText = "就诊类型";
                GvItinerary.Columns["HasPatientRecord"].HeaderText = "门诊病历";
                GvItinerary.Columns["HasPatientTicket"].HeaderText = "纸质发票";
                GvItinerary.Columns["HasPatientDetail"].HeaderText = "费用清单";
                GvItinerary.Columns["HasBChaoReport"].HeaderText = "B超报告";
                GvItinerary.Columns["HasCTReport"].HeaderText = "CT报告";
                GvItinerary.Columns["HasMRReport"].HeaderText = "MR报告";
                GvItinerary.Columns["Cost"].HeaderText = "花费(元)";
                GvItinerary.Columns["Cost"].DefaultCellStyle.Format = "N";
                GvItinerary.Columns["FeeType"].HeaderText = "费用类型";
                GvItinerary.Columns["Remark"].HeaderText = "备注";
                GvItinerary.Columns["Remark"].Width = 250;
            }
        }

        /// <summary>
        /// 序号列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == -1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);
                using (Brush brush = new SolidBrush(e.CellStyle.ForeColor))
                {
                    e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.CellStyle.Font, brush, e.CellBounds.Location.X + 14, e.CellBounds.Location.Y + 8);
                }
                e.Handled = true;
            }
        }
        /// <summary>
        /// 设置表头排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GvItinerary_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // 获取点击的列索引
            int columnIndex = e.ColumnIndex;

            var data = (List<Itinerary>)GvItinerary.DataSource;
            if (GvItinerary.Columns[columnIndex].DataPropertyName.Equals("StartDate"))
            {
                if (IsAsc)
                {
                    data = data.OrderBy(x => x.StartDate).ToList();
                    IsAsc = !IsAsc;
                }
                else
                {
                    data = data.OrderByDescending(x => x.StartDate).ToList();
                    IsAsc = !IsAsc;
                }
            }
            if (GvItinerary.Columns[columnIndex].DataPropertyName.Equals("Cost"))
            {
                if (IsAsc)
                {
                    data = data.OrderBy(x => x.Cost).ToList();
                    IsAsc = !IsAsc;
                }
                else
                {
                    data = data.OrderByDescending(x => x.Cost).ToList();
                    IsAsc = !IsAsc;
                }
            }
            if (GvItinerary.Columns[columnIndex].DataPropertyName.Equals("CityName"))
            {
                if (IsAsc)
                {
                    data = data.OrderBy(x => x.CityName).ToList();
                    IsAsc = !IsAsc;
                }
                else
                {
                    data = data.OrderByDescending(x => x.CityName).ToList();
                    IsAsc = !IsAsc;
                }
            }
            if (GvItinerary.Columns[columnIndex].DataPropertyName.Equals("CompanyType"))
            {
                if (IsAsc)
                {
                    data = data.OrderBy(x => x.CompanyType).ToList();
                    IsAsc = !IsAsc;
                }
                else
                {
                    data = data.OrderByDescending(x => x.CompanyType).ToList();
                    IsAsc = !IsAsc;
                }
            }
            if (GvItinerary.Columns[columnIndex].DataPropertyName.Equals("TicketType"))
            {
                if (IsAsc)
                {
                    data = data.OrderBy(x => x.TicketType).ToList();
                    IsAsc = !IsAsc;
                }
                else
                {
                    data = data.OrderByDescending(x => x.TicketType).ToList();
                    IsAsc = !IsAsc;
                }
            }
            // 应用排序结果到GridView
            GvItinerary.DataSource = data;
            GvItinerary.Refresh();
        }

        private void tsbTraffic_Click(object sender, EventArgs e)
        {
            currentModuel = CurrentModule.Itinerary;
            ShowCondition();
            ShowData();
        }
        private void tsbHospital_Click(object sender, EventArgs e)
        {
            currentModuel = CurrentModule.Hospital;
            ShowCondition();
            ShowData();
        }
        private void tsbHotel_Click(object sender, EventArgs e)
        {
            currentModuel = CurrentModule.Hotel;
            ShowCondition();
            ShowData();
        }
        private void ShowData()
        {
            Search(null, null);
        }

        private void ShowCondition()
        {
            InitSearchPanel();
            lbCompany.Visible = (currentModuel == CurrentModule.Itinerary);
            //cbCompany.Visible = (currentModuel == CurrentModule.Traffic);
        }

        /// <summary>
        /// 导出excel文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbExport_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Excel文件|*.xlsx";
            dialog.Title = "保存文件";
            dialog.FileName = "资料汇总";
            var filePath = dialog.FileName;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var itineraryList = new SQLiteDBItinerary<Itinerary>().QueryTable().Cast<ModelBase>().ToList();
                var hotelList = new SQLiteDBHotel<Hotel>().QueryTable().Cast<ModelBase>().ToList();
                var hospitalList = new SQLiteDBHospitalPatient<HospitalPatient>().QueryTable().Cast<ModelBase>().ToList();
                var dataList = new List<List<ModelBase>>();
                dataList.Add(itineraryList);
                dataList.Add(hotelList);
                dataList.Add(hospitalList);
                ExcelHelper<ModelBase>.ExportListToExcel(dataList, dialog.FileName);
            }

            if (MessageBox.Show("现在打开导出文件吗？", "打开文件", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Thread th = new Thread(() =>
                {
                    System.Diagnostics.Process.Start("C:\\Users\\30908\\Desktop\\资料汇总.xlsx");
                });
            }
        }
    }

}

