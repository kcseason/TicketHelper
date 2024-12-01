namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class MyItem
        {
            public string Text { get; set; }
            public int Value { get; set; }
        }

        private List<MyItem> items = new List<MyItem>
        {
            new MyItem { Text = "选项1", Value = 1 },
            new MyItem { Text = "选项2", Value = 2 },
            new MyItem { Text = "选项3", Value = 3 }
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            uiComboTreeView1.Nodes.Clear();
            uiComboTreeView1.Nodes.Add("1");
            uiComboTreeView1.Nodes.Add("2");
            uiComboTreeView1.Nodes.Add("3");
            uiComboTreeView1.Nodes.Add("4");
        }
    }
}
