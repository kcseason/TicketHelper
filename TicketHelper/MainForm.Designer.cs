namespace TicketHelper
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            tsbTraffic = new ToolStripButton();
            tsbHotel = new ToolStripButton();
            tsbHospital = new ToolStripButton();
            tsbExport = new ToolStripButton();
            toolStripButton2 = new ToolStripDropDownButton();
            初始化ToolStripMenuItem = new ToolStripMenuItem();
            交通出行ToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            label6 = new Label();
            lbCount = new TextBox();
            label9 = new Label();
            label7 = new Label();
            cbTicketType = new Sunny.UI.UIComboTreeView();
            cbCompany = new Sunny.UI.UIComboTreeView();
            cbCity = new Sunny.UI.UIComboTreeView();
            cbCalcTotal = new ComboBox();
            label8 = new Label();
            lbTicketType = new Label();
            lbCompany = new Label();
            label5 = new Label();
            dtEnd = new DateTimePicker();
            label4 = new Label();
            dtStart = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            tbTotalMoney = new TextBox();
            label1 = new Label();
            GvItinerary = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GvItinerary).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbTraffic, tsbHotel, tsbHospital, tsbExport, toolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(2138, 33);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbTraffic
            // 
            tsbTraffic.Image = (Image)resources.GetObject("tsbTraffic.Image");
            tsbTraffic.ImageTransparentColor = Color.Magenta;
            tsbTraffic.Name = "tsbTraffic";
            tsbTraffic.Size = new Size(110, 28);
            tsbTraffic.Text = "交通出行";
            tsbTraffic.Click += tsbTraffic_Click;
            // 
            // tsbHotel
            // 
            tsbHotel.Image = (Image)resources.GetObject("tsbHotel.Image");
            tsbHotel.ImageTransparentColor = Color.Magenta;
            tsbHotel.Name = "tsbHotel";
            tsbHotel.Size = new Size(110, 28);
            tsbHotel.Text = "住宿酒店";
            tsbHotel.Click += tsbHotel_Click;
            // 
            // tsbHospital
            // 
            tsbHospital.Image = (Image)resources.GetObject("tsbHospital.Image");
            tsbHospital.ImageTransparentColor = Color.Magenta;
            tsbHospital.Name = "tsbHospital";
            tsbHospital.Size = new Size(110, 28);
            tsbHospital.Text = "医院看病";
            tsbHospital.Click += tsbHospital_Click;
            // 
            // tsbExport
            // 
            tsbExport.Image = (Image)resources.GetObject("tsbExport.Image");
            tsbExport.ImageTransparentColor = Color.Magenta;
            tsbExport.Name = "tsbExport";
            tsbExport.Size = new Size(74, 28);
            tsbExport.Text = "导出";
            tsbExport.Click += tsbExport_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DropDownItems.AddRange(new ToolStripItem[] { 初始化ToolStripMenuItem, 交通出行ToolStripMenuItem });
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(88, 28);
            toolStripButton2.Text = "数据";
            // 
            // 初始化ToolStripMenuItem
            // 
            初始化ToolStripMenuItem.Name = "初始化ToolStripMenuItem";
            初始化ToolStripMenuItem.Size = new Size(182, 34);
            初始化ToolStripMenuItem.Text = "初始化";
            初始化ToolStripMenuItem.Click += tdbDataInit_Click;
            // 
            // 交通出行ToolStripMenuItem
            // 
            交通出行ToolStripMenuItem.Name = "交通出行ToolStripMenuItem";
            交通出行ToolStripMenuItem.Size = new Size(182, 34);
            交通出行ToolStripMenuItem.Text = "交通出行";
            交通出行ToolStripMenuItem.Click += tdb_Run_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 33);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(cbTicketType);
            splitContainer1.Panel1.Controls.Add(lbTicketType);
            splitContainer1.Panel1.Controls.Add(lbCount);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(cbCompany);
            splitContainer1.Panel1.Controls.Add(cbCity);
            splitContainer1.Panel1.Controls.Add(cbCalcTotal);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(lbCompany);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(dtEnd);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(dtStart);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(tbTotalMoney);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(GvItinerary);
            splitContainer1.Size = new Size(2138, 1085);
            splitContainer1.SplitterDistance = 70;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1965, 25);
            label6.Name = "label6";
            label6.Size = new Size(28, 24);
            label6.TabIndex = 26;
            label6.Text = "条";
            // 
            // lbCount
            // 
            lbCount.BackColor = Color.White;
            lbCount.Location = new Point(1885, 22);
            lbCount.Name = "lbCount";
            lbCount.ReadOnly = true;
            lbCount.Size = new Size(80, 30);
            lbCount.TabIndex = 25;
            lbCount.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1840, 23);
            label9.Name = "label9";
            label9.Size = new Size(46, 24);
            label9.TabIndex = 24;
            label9.Text = "记录";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1386, 24);
            label7.Name = "label7";
            label7.Size = new Size(46, 24);
            label7.TabIndex = 23;
            label7.Text = "统计";
            // 
            // cbTicketType
            // 
            cbTicketType.CausesValidation = false;
            cbTicketType.CheckBoxes = true;
            cbTicketType.DropDownHeight = 250;
            cbTicketType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbTicketType.FillColor = Color.White;
            cbTicketType.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cbTicketType.Location = new Point(884, 19);
            cbTicketType.Margin = new Padding(4, 5, 4, 5);
            cbTicketType.MinimumSize = new Size(63, 0);
            cbTicketType.Name = "cbTicketType";
            cbTicketType.Padding = new Padding(0, 0, 30, 2);
            cbTicketType.ShowClearButton = true;
            cbTicketType.Size = new Size(220, 34);
            cbTicketType.SymbolSize = 24;
            cbTicketType.TabIndex = 22;
            cbTicketType.TextAlignment = ContentAlignment.MiddleLeft;
            cbTicketType.Watermark = "";
            cbTicketType.TextChanged += Search;
            // 
            // cbCompany
            // 
            cbCompany.CausesValidation = false;
            cbCompany.CheckBoxes = true;
            cbCompany.DropDownHeight = 250;
            cbCompany.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbCompany.FillColor = Color.White;
            cbCompany.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cbCompany.Location = new Point(1159, 19);
            cbCompany.Margin = new Padding(4, 5, 4, 5);
            cbCompany.MinimumSize = new Size(63, 0);
            cbCompany.Name = "cbCompany";
            cbCompany.Padding = new Padding(0, 0, 30, 2);
            cbCompany.ShowClearButton = true;
            cbCompany.Size = new Size(220, 34);
            cbCompany.SymbolSize = 24;
            cbCompany.TabIndex = 21;
            cbCompany.TextAlignment = ContentAlignment.MiddleLeft;
            cbCompany.Watermark = "";
            cbCompany.TextChanged += Search;
            // 
            // cbCity
            // 
            cbCity.CausesValidation = false;
            cbCity.CheckBoxes = true;
            cbCity.DropDownHeight = 250;
            cbCity.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cbCity.FillColor = Color.White;
            cbCity.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cbCity.Location = new Point(602, 19);
            cbCity.Margin = new Padding(4, 5, 4, 5);
            cbCity.MinimumSize = new Size(63, 0);
            cbCity.Name = "cbCity";
            cbCity.Padding = new Padding(0, 0, 30, 2);
            cbCity.ShowClearButton = true;
            cbCity.Size = new Size(220, 34);
            cbCity.SymbolSize = 24;
            cbCity.TabIndex = 20;
            cbCity.TextAlignment = ContentAlignment.MiddleLeft;
            cbCity.Watermark = "";
            cbCity.TextChanged += Search;
            // 
            // cbCalcTotal
            // 
            cbCalcTotal.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCalcTotal.FormattingEnabled = true;
            cbCalcTotal.Location = new Point(1434, 20);
            cbCalcTotal.Name = "cbCalcTotal";
            cbCalcTotal.Size = new Size(151, 32);
            cbCalcTotal.TabIndex = 16;
            cbCalcTotal.SelectedIndexChanged += CalcTotal;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1791, 26);
            label8.Name = "label8";
            label8.Size = new Size(28, 24);
            label8.TabIndex = 13;
            label8.Text = "元";
            // 
            // lbTicketType
            // 
            lbTicketType.AutoSize = true;
            lbTicketType.Location = new Point(836, 25);
            lbTicketType.Name = "lbTicketType";
            lbTicketType.Size = new Size(46, 24);
            lbTicketType.TabIndex = 11;
            lbTicketType.Text = "票类";
            // 
            // lbCompany
            // 
            lbCompany.AutoSize = true;
            lbCompany.Location = new Point(1111, 24);
            lbCompany.Name = "lbCompany";
            lbCompany.Size = new Size(46, 24);
            lbCompany.TabIndex = 9;
            lbCompany.Text = "出行";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 24);
            label5.Name = "label5";
            label5.Size = new Size(18, 24);
            label5.TabIndex = 8;
            label5.Text = "-";
            // 
            // dtEnd
            // 
            dtEnd.Location = new Point(362, 23);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(169, 30);
            dtEnd.TabIndex = 7;
            dtEnd.ValueChanged += Search;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 25);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 6;
            label4.Text = "结束时间";
            // 
            // dtStart
            // 
            dtStart.Location = new Point(91, 22);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(169, 30);
            dtStart.TabIndex = 5;
            dtStart.Value = new DateTime(2022, 1, 1, 0, 0, 0, 0);
            dtStart.ValueChanged += Search;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 25);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 4;
            label3.Text = "开始时间";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(554, 25);
            label2.Name = "label2";
            label2.Size = new Size(46, 24);
            label2.TabIndex = 2;
            label2.Text = "城市";
            // 
            // tbTotalMoney
            // 
            tbTotalMoney.BackColor = Color.White;
            tbTotalMoney.Location = new Point(1658, 21);
            tbTotalMoney.Name = "tbTotalMoney";
            tbTotalMoney.ReadOnly = true;
            tbTotalMoney.Size = new Size(133, 30);
            tbTotalMoney.TabIndex = 1;
            tbTotalMoney.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1611, 24);
            label1.Name = "label1";
            label1.Size = new Size(46, 24);
            label1.TabIndex = 0;
            label1.Text = "合计";
            // 
            // GvItinerary
            // 
            GvItinerary.AllowUserToOrderColumns = true;
            GvItinerary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            GvItinerary.DefaultCellStyle = dataGridViewCellStyle1;
            GvItinerary.Dock = DockStyle.Fill;
            GvItinerary.Location = new Point(0, 0);
            GvItinerary.Name = "GvItinerary";
            GvItinerary.ReadOnly = true;
            GvItinerary.RowHeadersWidth = 62;
            GvItinerary.RowTemplate.Height = 35;
            GvItinerary.RowTemplate.ReadOnly = true;
            GvItinerary.Size = new Size(2138, 1014);
            GvItinerary.TabIndex = 0;
            GvItinerary.CellPainting += dataGridView1_CellPainting;
            GvItinerary.ColumnHeaderMouseClick += GvItinerary_ColumnHeaderMouseClick;
            GvItinerary.DataBindingComplete += GvItinerary_DataBindingComplete;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2138, 1118);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "发票小助手";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GvItinerary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private SplitContainer splitContainer1;
        private DataGridView GvItinerary;
        private TextBox tbTotalMoney;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dtEnd;
        private Label label4;
        private DateTimePicker dtStart;
        private Label label5;
        private Label lbCompany;
        private Label lbTicketType;
        private Label label8;
        private ToolStripButton tsbTraffic;
        private ToolStripButton tsbHospital;
        private ToolStripButton tsbHotel;
        private ToolStripButton tsbExport;
        private ToolStripDropDownButton toolStripButton2;
        private ToolStripMenuItem 初始化ToolStripMenuItem;
        private ToolStripMenuItem 交通出行ToolStripMenuItem;
        private ComboBox cbCalcTotal;
        private Sunny.UI.UIComboTreeView cbCity;
        private Sunny.UI.UIComboTreeView cbCompany;
        private Sunny.UI.UIComboTreeView cbTicketType;
        private Label label7;
        private Label label6;
        private TextBox lbCount;
        private Label label9;
    }
}
