namespace WeatherChart.Display.Greeting
{
    partial class GreetingForm
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
            panelRoot = new TableLayoutPanel();
            panelOperation = new TableLayoutPanel();
            panelCitySelection = new TableLayoutPanel();
            cbProvince = new ComboBox();
            cbCity = new ComboBox();
            cbDistrict = new ComboBox();
            panelButtons = new TableLayoutPanel();
            btnConfirm = new Button();
            btnAbout = new Button();
            lblClock = new Label();
            panelRoot.SuspendLayout();
            panelOperation.SuspendLayout();
            panelCitySelection.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelRoot
            // 
            panelRoot.ColumnCount = 1;
            panelRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelRoot.Controls.Add(panelOperation, 0, 1);
            panelRoot.Controls.Add(lblClock, 0, 0);
            panelRoot.Dock = DockStyle.Fill;
            panelRoot.Location = new Point(0, 0);
            panelRoot.Name = "panelRoot";
            panelRoot.RowCount = 2;
            panelRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            panelRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            panelRoot.Size = new Size(695, 382);
            panelRoot.TabIndex = 0;
            // 
            // panelOperation
            // 
            panelOperation.ColumnCount = 3;
            panelOperation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            panelOperation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            panelOperation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            panelOperation.Controls.Add(panelCitySelection, 1, 1);
            panelOperation.Controls.Add(panelButtons, 1, 2);
            panelOperation.Dock = DockStyle.Fill;
            panelOperation.Location = new Point(3, 117);
            panelOperation.Name = "panelOperation";
            panelOperation.RowCount = 4;
            panelOperation.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panelOperation.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panelOperation.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panelOperation.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            panelOperation.Size = new Size(689, 262);
            panelOperation.TabIndex = 0;
            // 
            // panelCitySelection
            // 
            panelCitySelection.ColumnCount = 3;
            panelCitySelection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            panelCitySelection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            panelCitySelection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            panelCitySelection.Controls.Add(cbProvince, 0, 0);
            panelCitySelection.Controls.Add(cbCity, 1, 0);
            panelCitySelection.Controls.Add(cbDistrict, 2, 0);
            panelCitySelection.Dock = DockStyle.Fill;
            panelCitySelection.Location = new Point(140, 68);
            panelCitySelection.Name = "panelCitySelection";
            panelCitySelection.RowCount = 1;
            panelCitySelection.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelCitySelection.Size = new Size(407, 59);
            panelCitySelection.TabIndex = 0;
            // 
            // cbProvince
            // 
            cbProvince.Dock = DockStyle.Fill;
            cbProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProvince.FormattingEnabled = true;
            cbProvince.Location = new Point(3, 3);
            cbProvince.Name = "cbProvince";
            cbProvince.Size = new Size(129, 33);
            cbProvince.TabIndex = 0;
            // 
            // cbCity
            // 
            cbCity.Dock = DockStyle.Fill;
            cbCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCity.FormattingEnabled = true;
            cbCity.Location = new Point(138, 3);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(129, 33);
            cbCity.TabIndex = 1;
            // 
            // cbDistrict
            // 
            cbDistrict.Dock = DockStyle.Fill;
            cbDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDistrict.FormattingEnabled = true;
            cbDistrict.Location = new Point(273, 3);
            cbDistrict.Name = "cbDistrict";
            cbDistrict.Size = new Size(131, 33);
            cbDistrict.TabIndex = 2;
            // 
            // panelButtons
            // 
            panelButtons.ColumnCount = 2;
            panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelButtons.Controls.Add(btnConfirm, 0, 0);
            panelButtons.Controls.Add(btnAbout, 1, 0);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(140, 133);
            panelButtons.Name = "panelButtons";
            panelButtons.RowCount = 1;
            panelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panelButtons.Size = new Size(407, 59);
            panelButtons.TabIndex = 1;
            // 
            // btnConfirm
            // 
            btnConfirm.Dock = DockStyle.Fill;
            btnConfirm.Location = new Point(2, 7);
            btnConfirm.Margin = new Padding(2, 7, 2, 7);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(199, 45);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "拉取数据";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            btnAbout.Dock = DockStyle.Fill;
            btnAbout.Location = new Point(205, 7);
            btnAbout.Margin = new Padding(2, 7, 2, 7);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(200, 45);
            btnAbout.TabIndex = 1;
            btnAbout.Text = "关于软件";
            btnAbout.UseVisualStyleBackColor = true;
            // 
            // lblClock
            // 
            lblClock.Anchor = AnchorStyles.Bottom;
            lblClock.AutoSize = true;
            lblClock.Font = new Font("Microsoft YaHei UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblClock.Location = new Point(151, 68);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(392, 46);
            lblClock.TabIndex = 1;
            lblClock.Text = "0000/00/00 00:00:00";
            // 
            // GreetingForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 382);
            Controls.Add(panelRoot);
            Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Margin = new Padding(5, 4, 5, 4);
            Name = "GreetingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "天气走势图";
            panelRoot.ResumeLayout(false);
            panelRoot.PerformLayout();
            panelOperation.ResumeLayout(false);
            panelCitySelection.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel panelRoot;
        private TableLayoutPanel panelOperation;
        private TableLayoutPanel panelCitySelection;
        private TableLayoutPanel panelButtons;
        private Button btnConfirm;
        private Button btnAbout;
        private Label lblClock;
        private ComboBox cbProvince;
        private ComboBox cbCity;
        private ComboBox cbDistrict;
    }
}
