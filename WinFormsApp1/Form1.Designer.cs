namespace WinFormsApp1
{
    partial class Form1
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
            uiAnalogMeter1 = new Sunny.UI.UIAnalogMeter();
            uiComboTreeView1 = new Sunny.UI.UIComboTreeView();
            uiComboBox1 = new Sunny.UI.UIComboBox();
            uiComboDataGridView1 = new Sunny.UI.UIComboDataGridView();
            uiTextBox1 = new Sunny.UI.UITextBox();
            aloneComboBox1 = new ReaLTaiizor.Controls.AloneComboBox();
            aloneCheckBox1 = new ReaLTaiizor.Controls.AloneCheckBox();
            aloneComboBox2 = new ReaLTaiizor.Controls.AloneComboBox();
            comboBoxEdit1 = new ReaLTaiizor.Controls.ComboBoxEdit();
            uiComboBox2 = new Sunny.UI.UIComboBox();
            crownComboBox1 = new ReaLTaiizor.Controls.CrownComboBox();
            SuspendLayout();
            // 
            // uiAnalogMeter1
            // 
            uiAnalogMeter1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiAnalogMeter1.Location = new Point(48, 40);
            uiAnalogMeter1.MaxValue = 100D;
            uiAnalogMeter1.MinimumSize = new Size(1, 1);
            uiAnalogMeter1.MinValue = 0D;
            uiAnalogMeter1.Name = "uiAnalogMeter1";
            uiAnalogMeter1.Renderer = null;
            uiAnalogMeter1.Size = new Size(270, 270);
            uiAnalogMeter1.TabIndex = 0;
            uiAnalogMeter1.Text = "uiAnalogMeter1";
            uiAnalogMeter1.Value = 0D;
            // 
            // uiComboTreeView1
            // 
            uiComboTreeView1.CheckBoxes = true;
            uiComboTreeView1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            uiComboTreeView1.FillColor = Color.White;
            uiComboTreeView1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiComboTreeView1.Location = new Point(639, 264);
            uiComboTreeView1.Margin = new Padding(4, 5, 4, 5);
            uiComboTreeView1.MinimumSize = new Size(63, 0);
            uiComboTreeView1.Name = "uiComboTreeView1";
            uiComboTreeView1.Padding = new Padding(0, 0, 30, 2);
            uiComboTreeView1.Size = new Size(353, 44);
            uiComboTreeView1.StyleDropDown = Sunny.UI.UIStyle.Green;
            uiComboTreeView1.SymbolSize = 24;
            uiComboTreeView1.TabIndex = 1;
            uiComboTreeView1.Text = "uiComboTreeView1";
            uiComboTreeView1.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboTreeView1.Watermark = "";
            // 
            // uiComboBox1
            // 
            uiComboBox1.DataSource = null;
            uiComboBox1.FillColor = Color.White;
            uiComboBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiComboBox1.ItemHoverColor = Color.FromArgb(155, 200, 255);
            uiComboBox1.Items.AddRange(new object[] { "1", "2", "3", "4" });
            uiComboBox1.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            uiComboBox1.Location = new Point(759, 375);
            uiComboBox1.Margin = new Padding(4, 5, 4, 5);
            uiComboBox1.MinimumSize = new Size(63, 0);
            uiComboBox1.Name = "uiComboBox1";
            uiComboBox1.Padding = new Padding(0, 0, 30, 2);
            uiComboBox1.Size = new Size(225, 44);
            uiComboBox1.SymbolSize = 24;
            uiComboBox1.TabIndex = 2;
            uiComboBox1.Text = "uiComboBox1";
            uiComboBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox1.Watermark = "";
            // 
            // uiComboDataGridView1
            // 
            uiComboDataGridView1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            uiComboDataGridView1.FillColor = Color.White;
            uiComboDataGridView1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiComboDataGridView1.Location = new Point(643, 587);
            uiComboDataGridView1.Margin = new Padding(4, 5, 4, 5);
            uiComboDataGridView1.MinimumSize = new Size(63, 0);
            uiComboDataGridView1.Name = "uiComboDataGridView1";
            uiComboDataGridView1.Padding = new Padding(0, 0, 30, 2);
            uiComboDataGridView1.Size = new Size(225, 44);
            uiComboDataGridView1.SymbolSize = 24;
            uiComboDataGridView1.TabIndex = 3;
            uiComboDataGridView1.Text = "uiComboDataGridView1";
            uiComboDataGridView1.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboDataGridView1.Watermark = "";
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTextBox1.Location = new Point(1219, 94);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(225, 44);
            uiTextBox1.TabIndex = 4;
            uiTextBox1.Text = "uiTextBox1";
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "";
            // 
            // aloneComboBox1
            // 
            aloneComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            aloneComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            aloneComboBox1.EnabledCalc = true;
            aloneComboBox1.FormattingEnabled = true;
            aloneComboBox1.ItemHeight = 20;
            aloneComboBox1.Location = new Point(1200, 493);
            aloneComboBox1.Name = "aloneComboBox1";
            aloneComboBox1.Size = new Size(191, 26);
            aloneComboBox1.TabIndex = 5;
            // 
            // aloneCheckBox1
            // 
            aloneCheckBox1.BackColor = Color.Transparent;
            aloneCheckBox1.Checked = false;
            aloneCheckBox1.EnabledCalc = true;
            aloneCheckBox1.ForeColor = Color.FromArgb(124, 133, 142);
            aloneCheckBox1.Location = new Point(1252, 413);
            aloneCheckBox1.Name = "aloneCheckBox1";
            aloneCheckBox1.Size = new Size(177, 17);
            aloneCheckBox1.TabIndex = 6;
            aloneCheckBox1.Text = "aloneCheckBox1";
            // 
            // aloneComboBox2
            // 
            aloneComboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            aloneComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            aloneComboBox2.EnabledCalc = true;
            aloneComboBox2.FormattingEnabled = true;
            aloneComboBox2.ItemHeight = 20;
            aloneComboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            aloneComboBox2.Location = new Point(1103, 657);
            aloneComboBox2.Name = "aloneComboBox2";
            aloneComboBox2.Size = new Size(288, 26);
            aloneComboBox2.TabIndex = 7;
            // 
            // comboBoxEdit1
            // 
            comboBoxEdit1.BackColor = Color.FromArgb(246, 246, 246);
            comboBoxEdit1.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxEdit1.DropDownHeight = 100;
            comboBoxEdit1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEdit1.Font = new Font("Segoe UI", 10F);
            comboBoxEdit1.ForeColor = Color.FromArgb(142, 142, 142);
            comboBoxEdit1.FormattingEnabled = true;
            comboBoxEdit1.HoverSelectionColor = Color.FromArgb(241, 241, 241);
            comboBoxEdit1.IntegralHeight = false;
            comboBoxEdit1.ItemHeight = 20;
            comboBoxEdit1.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBoxEdit1.Location = new Point(872, 776);
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Size = new Size(202, 26);
            comboBoxEdit1.StartIndex = 0;
            comboBoxEdit1.TabIndex = 8;
            // 
            // uiComboBox2
            // 
            uiComboBox2.DataSource = null;
            uiComboBox2.FillColor = Color.White;
            uiComboBox2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiComboBox2.ItemHoverColor = Color.FromArgb(155, 200, 255);
            uiComboBox2.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            uiComboBox2.Location = new Point(938, 496);
            uiComboBox2.Margin = new Padding(4, 5, 4, 5);
            uiComboBox2.MinimumSize = new Size(63, 0);
            uiComboBox2.Name = "uiComboBox2";
            uiComboBox2.Padding = new Padding(0, 0, 30, 2);
            uiComboBox2.Size = new Size(225, 44);
            uiComboBox2.SymbolSize = 24;
            uiComboBox2.TabIndex = 9;
            uiComboBox2.Text = "uiComboBox2";
            uiComboBox2.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox2.Watermark = "";
            // 
            // crownComboBox1
            // 
            crownComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            crownComboBox1.FormattingEnabled = true;
            crownComboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            crownComboBox1.Location = new Point(595, 784);
            crownComboBox1.Name = "crownComboBox1";
            crownComboBox1.Size = new Size(207, 31);
            crownComboBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1663, 979);
            Controls.Add(crownComboBox1);
            Controls.Add(uiComboBox2);
            Controls.Add(comboBoxEdit1);
            Controls.Add(aloneComboBox2);
            Controls.Add(aloneCheckBox1);
            Controls.Add(aloneComboBox1);
            Controls.Add(uiTextBox1);
            Controls.Add(uiComboDataGridView1);
            Controls.Add(uiComboBox1);
            Controls.Add(uiComboTreeView1);
            Controls.Add(uiAnalogMeter1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIAnalogMeter uiAnalogMeter1;
        private Sunny.UI.UIComboTreeView uiComboTreeView1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIComboDataGridView uiComboDataGridView1;
        private Sunny.UI.UITextBox uiTextBox1;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox1;
        private ReaLTaiizor.Controls.AloneCheckBox aloneCheckBox1;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox2;
        private ReaLTaiizor.Controls.ComboBoxEdit comboBoxEdit1;
        private Sunny.UI.UIComboBox uiComboBox2;
        private ReaLTaiizor.Controls.CrownComboBox crownComboBox1;
    }
}
