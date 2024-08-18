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
            toolStrip1 = new ToolStrip();
            tdb_Run = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            cbTicketType = new ComboBox();
            label7 = new Label();
            cbCompany = new ComboBox();
            label6 = new Label();
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
            tdbDataInit = new ToolStripButton();
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { tdb_Run, tdbDataInit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1545, 33);
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
            splitContainer1.Panel1.Controls.Add(cbTicketType);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(cbCompany);
            splitContainer1.Panel1.Controls.Add(label6);
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
            splitContainer1.Size = new Size(1545, 956);
            splitContainer1.SplitterDistance = 70;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 1;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(991, 23);
            label7.Name = "label7";
            label7.Size = new Size(46, 24);
            label7.TabIndex = 11;
            label7.Text = "票类";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(775, 24);
            label6.Name = "label6";
            label6.Size = new Size(46, 24);
            label6.TabIndex = 9;
            label6.Text = "出行";
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
            tbTotalMoney.Location = new Point(1336, 21);
            tbTotalMoney.Name = "tbTotalMoney";
            tbTotalMoney.ReadOnly = true;
            tbTotalMoney.Size = new Size(150, 30);
            tbTotalMoney.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1289, 24);
            label1.Name = "label1";
            label1.Size = new Size(46, 24);
            label1.TabIndex = 0;
            label1.Text = "合计";
            // 
            // GvItinerary
            // 
            GvItinerary.AllowUserToOrderColumns = true;
            GvItinerary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GvItinerary.Dock = DockStyle.Fill;
            GvItinerary.Location = new Point(0, 0);
            GvItinerary.Name = "GvItinerary";
            GvItinerary.ReadOnly = true;
            GvItinerary.RowHeadersWidth = 62;
            GvItinerary.Size = new Size(1545, 885);
            GvItinerary.TabIndex = 0;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1545, 989);
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
        private Label label6;
        private ComboBox cbTicketType;
        private Label label7;
        private ToolStripButton tdbDataInit;
    }
}
