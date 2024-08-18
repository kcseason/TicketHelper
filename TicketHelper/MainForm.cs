using TicketHelper.DBO;
using TicketHelper.String;

namespace TicketHelper
{
    public partial class MainForm : Form
    {
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
        }

        private void tdb_Run_Click(object sender, EventArgs e)
        {
            var runHelper = new RunHelper();
            runHelper.HandleTicket();

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
            DBPosition.DataInit();
        }
    }
}
