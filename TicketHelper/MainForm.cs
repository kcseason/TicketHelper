using TicketHelper.DBO;
using TicketHelper.Enum;
using TicketHelper.Handler;
using TicketHelper.Model;
using TicketHelper.String;

namespace TicketHelper
{
    public partial class MainForm : Form
    {
        private bool IsLoad = true;
        private bool IsAsc = true;
        private CurrentModule currentModuel = CurrentModule.None;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitSearchPanel();
            IsLoad = false;
        }

        private void tdb_Run_Click(object sender, EventArgs e)
        {
            var runHelper = new RunHelper();
            runHelper.HandleTicket();

            tsbTraffic_Click(null, null);
        }

        private void InitSearchPanel()
        {
            cbCity.DataSource = CityName.CityList;
            cbCompany.DataSource = CompanyType.CompanyList;
            cbTicketType.DataSource = currentModuel == CurrentModule.Traffic ? TicketType.TicketTypes :
                (currentModuel == CurrentModule.Hotel ? FeeType.HotelFeeTypes : FeeType.HotelFeeTypes);
        }
        private void Search(object sender, EventArgs e)
        {
            if (IsLoad)
                return;

            if (currentModuel == CurrentModule.Traffic)
            {
                DateTime start = dtStart.Value.Date;
                DateTime end = dtEnd.Value.Date;
                var city = cbCity.Text;
                var company = cbCompany.Text;
                var ticketType = cbTicketType.Text;

                var pams = new object[] { start, end, city, company, ticketType };
                var list = new SQLiteDBItinerary<Itinerary>().QueryTable(pams);
                GvItinerary.DataSource = list;

                tbTotalMoney.Text = list.Sum(x => x.Cost).ToString();
            }
            if (currentModuel == CurrentModule.Hotel)
            {
                DateTime start = dtStart.Value.Date;
                DateTime end = dtEnd.Value.Date;
                var city = cbCity.Text;
                var feeType = cbTicketType.Text;

                var pams = new object[] { start, end, city, feeType };
                var list = new SQLiteDBHotel<Hotel>().QueryTable(pams);
                GvItinerary.DataSource = list;

                tbTotalMoney.Text = list.Sum(x => x.Cost).ToString();
            }
            if (currentModuel == CurrentModule.Hospital)
            {
                DateTime start = dtStart.Value.Date;
                DateTime end = dtEnd.Value.Date;
                var city = cbCity.Text;
                var company = cbCompany.Text;
                var ticketType = cbTicketType.Text;

                var pams = new object[] { start, end, city, company, ticketType };
                var list = new SQLiteDBItinerary<Itinerary>().QueryTable(pams);
                GvItinerary.DataSource = list;

                tbTotalMoney.Text = list.Sum(x => x.Cost).ToString();
            }
        }

        private void tdbDataInit_Click(object sender, EventArgs e)
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
            if (currentModuel == CurrentModule.Traffic)
            {
                //������ʾ������
                GvItinerary.Columns["Id"].Visible = false;
                GvItinerary.Columns["StartDate"].HeaderText = "�г�����";
                GvItinerary.Columns["StartDate"].DisplayIndex = 0;
                GvItinerary.Columns["StartDate"].SortMode = DataGridViewColumnSortMode.Automatic;
                GvItinerary.Columns["StartDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                GvItinerary.Columns["EndDate"].Visible = false;
                GvItinerary.Columns["Start"].HeaderText = "��ʼ�ص�";
                GvItinerary.Columns["Start"].Width = 270;
                GvItinerary.Columns["End"].HeaderText = "�����ص�";
                GvItinerary.Columns["End"].Width = 270;
                GvItinerary.Columns["Cost"].HeaderText = "����(Ԫ)";
                GvItinerary.Columns["Cost"].DefaultCellStyle.Format = "N";
                GvItinerary.Columns["CityName"].HeaderText = "����";
                GvItinerary.Columns["CityName"].Width = 100;
                GvItinerary.Columns["CityName"].DisplayIndex = 1;
                GvItinerary.Columns["CompanyType"].HeaderText = "��ͨ��˾";
                GvItinerary.Columns["TicketType"].HeaderText = "Ʊ������";
                GvItinerary.Columns["FeeType"].HeaderText = "��������";
                GvItinerary.Columns["FeeType"].Width = 150;
                GvItinerary.Columns["HasTicket"].HeaderText = "��Ʊ";
                GvItinerary.Columns["HasTicket"].Width = 100;
                GvItinerary.Columns["HasDetail"].HeaderText = "�г̵�";
                GvItinerary.Columns["HasDetail"].Width = 100;
                GvItinerary.Columns["Remark"].HeaderText = "��ע";
                GvItinerary.Columns["Remark"].Width = 280;
            }
            if (currentModuel == CurrentModule.Hotel)
            {
                //������ʾ������
                GvItinerary.Columns["Id"].Visible = false;
                GvItinerary.Columns["CityName"].HeaderText = "����";
                GvItinerary.Columns["CityName"].DisplayIndex = 0;
                GvItinerary.Columns["HotelName"].HeaderText = "ס�޵ص�";
                GvItinerary.Columns["HotelName"].Width = 200;
                GvItinerary.Columns["HotelName"].DisplayIndex = 1;
                GvItinerary.Columns["StartDate"].HeaderText = "��ʼʱ��";
                GvItinerary.Columns["StartDate"].DisplayIndex = 2;
                GvItinerary.Columns["StartDate"].SortMode = DataGridViewColumnSortMode.Automatic;
                GvItinerary.Columns["StartDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                GvItinerary.Columns["EndDate"].HeaderText = "����ʱ��";
                GvItinerary.Columns["EndDate"].DisplayIndex = 3;
                GvItinerary.Columns["EndDate"].SortMode = DataGridViewColumnSortMode.Automatic;
                GvItinerary.Columns["EndDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                GvItinerary.Columns["Cost"].HeaderText = "����(Ԫ)";
                GvItinerary.Columns["Cost"].DefaultCellStyle.Format = "N";
                GvItinerary.Columns["Cost"].DisplayIndex = 4;
                GvItinerary.Columns["HasETicket"].HeaderText = "���ӷ�Ʊ";
                GvItinerary.Columns["HasETicket"].Width = 120;
                GvItinerary.Columns["HasETicket"].DisplayIndex = 5;
                GvItinerary.Columns["HasTicket"].HeaderText = "ֽ�ʷ�Ʊ";
                GvItinerary.Columns["HasTicket"].Width = 120;
                GvItinerary.Columns["HasTicket"].DisplayIndex = 6;
                GvItinerary.Columns["FeeType"].HeaderText = "��������";
                GvItinerary.Columns["FeeType"].DisplayIndex = 7;
                GvItinerary.Columns["Remark"].HeaderText = "��ע";
                GvItinerary.Columns["Remark"].Width = 280;
            }
            if (currentModuel == CurrentModule.Hospital)
            {
                //������ʾ������
                GvItinerary.Columns["Id"].Visible = false;
                GvItinerary.Columns["CityName"].HeaderText = "����";
                GvItinerary.Columns["CityName"].DisplayIndex = 0;
                GvItinerary.Columns["HospitalName"].HeaderText = "ҽԺ����";
                GvItinerary.Columns["StartDate"].HeaderText = "��ʼʱ��";
                GvItinerary.Columns["StartDate"].DisplayIndex = 1;
                GvItinerary.Columns["StartDate"].SortMode = DataGridViewColumnSortMode.Automatic;
                GvItinerary.Columns["StartDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                GvItinerary.Columns["EndDate"].HeaderText = "����ʱ��";
                GvItinerary.Columns["EndDate"].DisplayIndex = 2;
                GvItinerary.Columns["EndDate"].SortMode = DataGridViewColumnSortMode.Automatic;
                GvItinerary.Columns["EndDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                GvItinerary.Columns["PatientType"].HeaderText = "��������";
                GvItinerary.Columns["HasPatientRecord"].HeaderText = "���ﲡ��";
                GvItinerary.Columns["HasPatientTicket"].HeaderText = "ֽ�ʷ�Ʊ";
                GvItinerary.Columns["HasPatientDetail"].HeaderText = "�����嵥";
                GvItinerary.Columns["HasBChaoReport"].HeaderText = "B������";
                GvItinerary.Columns["HasCTReport"].HeaderText = "CT����";
                GvItinerary.Columns["HasMRReport"].HeaderText = "MR����";
                GvItinerary.Columns["Cost"].HeaderText = "����(Ԫ)";
                GvItinerary.Columns["Cost"].DefaultCellStyle.Format = "N";
                GvItinerary.Columns["FeeType"].HeaderText = "��������";
                GvItinerary.Columns["Remark"].HeaderText = "��ע";
                GvItinerary.Columns["Remark"].Width = 250;
            }
        }

        /// <summary>
        /// �����
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
        /// ���ñ�ͷ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GvItinerary_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // ��ȡ�����������
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
            // Ӧ����������GridView
            GvItinerary.DataSource = data;
            GvItinerary.Refresh();
        }

        private void tsbTraffic_Click(object sender, EventArgs e)
        {
            currentModuel = CurrentModule.Traffic;
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
            if (currentModuel == CurrentModule.Traffic)
            {
                GvItinerary.DataSource = null;
                var list = new SQLiteDBItinerary<Itinerary>().QueryTable();
                GvItinerary.DataSource = list;
                tbTotalMoney.Text = list.Sum(x => x.Cost).ToString();
            }
            if (currentModuel == CurrentModule.Hotel)
            {
                GvItinerary.DataSource = null;
                var list = new SQLiteDBHotel<Hotel>().QueryTable();
                GvItinerary.DataSource = list;
                tbTotalMoney.Text = list.Sum(x => x.Cost).ToString();
            }
            if (currentModuel == CurrentModule.Hospital)
            {
                GvItinerary.DataSource = null;
                var list = new SQLiteDBHospitalPatient<HospitalPatient>().QueryTable();
                GvItinerary.DataSource = list;
                tbTotalMoney.Text = list.Sum(x => x.Cost).ToString();
            }
        }

        private void ShowCondition()
        {
            InitSearchPanel();
            lbCompany.Visible = (currentModuel == CurrentModule.Traffic);
            cbCompany.Visible = (currentModuel == CurrentModule.Traffic);
        }

        /// <summary>
        /// ����excel�ļ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbExport_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Excel�ļ�|*.xlsx";
            dialog.Title = "�����ļ�";
            dialog.FileName = "���ϻ���";
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

            if (MessageBox.Show("���ڴ򿪵����ļ���", "���ļ�", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Thread th = new Thread(() =>
                {
                    System.Diagnostics.Process.Start("C:\\Users\\30908\\Desktop\\���ϻ���.xlsx");
                });
            }
        }
    }

}

