using TicketHelper.DBO;
using TicketHelper.Handler;
using TicketHelper.Model;
using TicketHelper.String;

namespace TicketHelper
{
    public partial class MainForm : Form
    {
        private bool IsLoad = true;
        private bool IsAsc = true;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitSearchPanel();

            var list = DBItinerary.GetAllItinerary();
            GvItinerary.DataSource = list;
            tbTotalMoney.Text = list.Sum(x => x.Cost).ToString();

            IsLoad = false;
        }

        private void tdb_Run_Click(object sender, EventArgs e)
        {
            var runHelper = new RunHelper();
            runHelper.HandleTicket();

            GvItinerary.DataSource = null;
            var list = DBItinerary.GetAllItinerary();
            GvItinerary.DataSource = list;
            tbTotalMoney.Text = list.Sum(x => x.Cost).ToString();
        }

        private void InitSearchPanel()
        {
            cbCity.DataSource = LocationName.Locations;
            cbCompany.DataSource = CompanyType.Locations;
            cbTicketType.DataSource = TicketType.TicketTypes;
        }

        private void Search(object sender, EventArgs e)
        {
            if (IsLoad)
                return;

            DateTime start = dtStart.Value.Date;
            DateTime end = dtEnd.Value.Date;
            var city = cbCity.Text;
            var company = cbCompany.Text;
            var ticketType = cbTicketType.Text;

            var pams = new object[] { start, end, city, company, ticketType };
            var list = DBItinerary.GetAllItinerary(pams);
            GvItinerary.DataSource = list;

            tbTotalMoney.Text = list.Sum(x => x.Cost).ToString();
        }

        private void tdbDataInit_Click(object sender, EventArgs e)
        {
            PositionHandler.DataInit();
        }

        private void GvItinerary_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //设置显示的列名
            GvItinerary.Columns["Id"].Visible = false;
            GvItinerary.Columns["DateTime"].HeaderText = "行程日期";
            GvItinerary.Columns["DateTime"].SortMode = DataGridViewColumnSortMode.Automatic;
            GvItinerary.Columns["DateTime"].DefaultCellStyle.Format = "yyyy-MM-dd";
            GvItinerary.Columns["Start"].HeaderText = "开始地点";
            GvItinerary.Columns["Start"].Width = 230;
            GvItinerary.Columns["End"].HeaderText = "结束地点";
            GvItinerary.Columns["End"].Width = 230;
            GvItinerary.Columns["Cost"].HeaderText = "花费(元)";
            GvItinerary.Columns["LocationName"].HeaderText = "城市";
            GvItinerary.Columns["CompanyType"].HeaderText = "交通公司";
            GvItinerary.Columns["TicketType"].HeaderText = "票据类型";
            GvItinerary.Columns["FeeType"].HeaderText = "费用类型";
            GvItinerary.Columns["Remark"].HeaderText = "备注";
            GvItinerary.Columns["Remark"].Width = 250;
        }

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

        private void GvItinerary_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // 获取点击的列索引
            int columnIndex = e.ColumnIndex;

            var data = (List<Itinerary>)GvItinerary.DataSource;
            if (GvItinerary.Columns[columnIndex].DataPropertyName.Equals("DateTime"))
            {
                if (IsAsc)
                {
                    data = data.OrderBy(x => x.DateTime).ToList();
                    IsAsc = !IsAsc;
                }
                else
                {
                    data = data.OrderByDescending(x => x.DateTime).ToList();
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
            if (GvItinerary.Columns[columnIndex].DataPropertyName.Equals("LocationName"))
            {
                if (IsAsc)
                {
                    data = data.OrderBy(x => x.LocationName).ToList();
                    IsAsc = !IsAsc;
                }
                else
                {
                    data = data.OrderByDescending(x => x.LocationName).ToList();
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
    }
}
