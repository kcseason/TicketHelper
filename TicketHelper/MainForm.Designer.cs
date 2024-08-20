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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            tdb_Run = new ToolStripButton();
            tdbDataInit = new ToolStripButton();
            tsbTraffic = new ToolStripButton();
            tsbHotel = new ToolStripButton();
            tsbHospital = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            label8 = new Label();
            cbTicketType = new ComboBox();
            lbTicketType = new Label();
            cbCompany = new ComboBox();
            lbCompany = new Label();
            label5 = new Label();
            dtEnd = new DateTimePicker();
            label4 = new Label();
            dtStart = new DateTimePicker();
            label3 = new Label();
            cbCity = new ComboBox();
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { tdb_Run, tdbDataInit, tsbTraffic, tsbHotel, tsbHospital });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1827, 33);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tdb_Run
            // 
            tdb_Run.Image = (Image)resources.GetObject("tdb_Run.Image");
            tdb_Run.ImageTransparentColor = Color.Magenta;
            tdb_Run.Name = "tdb_Run";
            tdb_Run.Size = new Size(74, 28);
            tdb_Run.Text = "运行";
            tdb_Run.Click += tdb_Run_Click;
            // 
            // tdbDataInit
            // 
            tdbDataInit.Image = (Image)resources.GetObject("tdbDataInit.Image");
            tdbDataInit.ImageTransparentColor = Color.Magenta;
            tdbDataInit.Name = "tdbDataInit";
            tdbDataInit.Size = new Size(92, 28);
            tdbDataInit.Text = "初始化";
            tdbDataInit.Click += tdbDataInit_Click;
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
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(cbTicketType);
            splitContainer1.Panel1.Controls.Add(lbTicketType);
            splitContainer1.Panel1.Controls.Add(cbCompany);
            splitContainer1.Panel1.Controls.Add(lbCompany);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(dtEnd);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(dtStart);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(cbCity);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(tbTotalMoney);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(GvItinerary);
            splitContainer1.Size = new Size(1827, 1085);
            splitContainer1.SplitterDistance = 70;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1444, 27);
            label8.Name = "label8";
            label8.Size = new Size(28, 24);
            label8.TabIndex = 13;
            label8.Text = "元";
            // 
            // cbTicketType
            // 
            cbTicketType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTicketType.FormattingEnabled = true;
            cbTicketType.Location = new Point(1042, 19);
            cbTicketType.Name = "cbTicketType";
            cbTicketType.Size = new Size(150, 32);
            cbTicketType.TabIndex = 12;
            cbTicketType.SelectedIndexChanged += Search;
            // 
            // lbTicketType
            // 
            lbTicketType.AutoSize = true;
            lbTicketType.Location = new Point(991, 23);
            lbTicketType.Name = "lbTicketType";
            lbTicketType.Size = new Size(46, 24);
            lbTicketType.TabIndex = 11;
            lbTicketType.Text = "票类";
            // 
            // cbCompany
            // 
            cbCompany.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCompany.FormattingEnabled = true;
            cbCompany.Location = new Point(826, 20);
            cbCompany.Name = "cbCompany";
            cbCompany.Size = new Size(150, 32);
            cbCompany.TabIndex = 10;
            cbCompany.SelectedIndexChanged += Search;
            // 
            // lbCompany
            // 
            lbCompany.AutoSize = true;
            lbCompany.Location = new Point(775, 24);
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
            // cbCity
            // 
            cbCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCity.FormattingEnabled = true;
            cbCity.Location = new Point(609, 21);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(150, 32);
            cbCity.TabIndex = 3;
            cbCity.SelectedIndexChanged += Search;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(558, 25);
            label2.Name = "label2";
            label2.Size = new Size(46, 24);
            label2.TabIndex = 2;
            label2.Text = "城市";
            // 
            // tbTotalMoney
            // 
            tbTotalMoney.Location = new Point(1311, 21);
            tbTotalMoney.Name = "tbTotalMoney";
            tbTotalMoney.ReadOnly = true;
            tbTotalMoney.Size = new Size(133, 30);
            tbTotalMoney.TabIndex = 1;
            tbTotalMoney.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1264, 24);
            label1.Name = "label1";
            label1.Size = new Size(46, 24);
            label1.TabIndex = 0;
            label1.Text = "合计";
            // 
            // GvItinerary
            // 
            GvItinerary.AllowUserToOrderColumns = true;
            GvItinerary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            GvItinerary.DefaultCellStyle = dataGridViewCellStyle2;
            GvItinerary.Dock = DockStyle.Fill;
            GvItinerary.Location = new Point(0, 0);
            GvItinerary.Name = "GvItinerary";
            GvItinerary.ReadOnly = true;
            GvItinerary.RowHeadersWidth = 62;
            GvItinerary.RowTemplate.Height = 35;
            GvItinerary.RowTemplate.ReadOnly = true;
            GvItinerary.Size = new Size(1827, 1014);
            GvItinerary.TabIndex = 0;
            GvItinerary.CellPainting += dataGridView1_CellPainting;
            GvItinerary.ColumnHeaderMouseClick += GvItinerary_ColumnHeaderMouseClick;
            GvItinerary.DataBindingComplete += GvItinerary_DataBindingComplete;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1827, 1118);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "发票小助手";
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
        private ToolStripButton tdb_Run;
        private SplitContainer splitContainer1;
        private DataGridView GvItinerary;
        private TextBox tbTotalMoney;
        private Label label1;
        private ComboBox cbCity;
        private Label label2;
        private Label label3;
        private DateTimePicker dtEnd;
        private Label label4;
        private DateTimePicker dtStart;
        private Label label5;
        private ComboBox cbCompany;
        private Label lbCompany;
        private ComboBox cbTicketType;
        private Label lbTicketType;
        private ToolStripButton tdbDataInit;
        private Label label8;
        private ToolStripButton tsbTraffic;
        private ToolStripButton tsbHospital;
        private ToolStripButton tsbHotel;
    }
}
