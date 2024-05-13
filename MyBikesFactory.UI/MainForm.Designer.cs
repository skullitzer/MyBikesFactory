namespace MyBikesFactory.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbBikeType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSuspensionType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTireType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtManufacturingYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbDisplayAll = new System.Windows.Forms.RadioButton();
            this.rbDisplayMountain = new System.Windows.Forms.RadioButton();
            this.rbDisplayRoad = new System.Windows.Forms.RadioButton();
            this.lstBikes = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtOriginalSerialNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bike Type:";
            // 
            // cbBikeType
            // 
            this.cbBikeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBikeType.FormattingEnabled = true;
            this.cbBikeType.Items.AddRange(new object[] {
            "Mountain",
            "Road"});
            this.cbBikeType.Location = new System.Drawing.Point(34, 51);
            this.cbBikeType.Name = "cbBikeType";
            this.cbBikeType.Size = new System.Drawing.Size(148, 28);
            this.cbBikeType.TabIndex = 1;
            this.cbBikeType.SelectedIndexChanged += new System.EventHandler(this.cbBikeType_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Serial Number:";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(238, 52);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(148, 27);
            this.txtSerialNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(447, 52);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(148, 27);
            this.txtModel.TabIndex = 5;
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Red",
            "Green"});
            this.cbColor.Location = new System.Drawing.Point(34, 204);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(148, 28);
            this.cbColor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Color:";
            // 
            // cbSuspensionType
            // 
            this.cbSuspensionType.FormattingEnabled = true;
            this.cbSuspensionType.Items.AddRange(new object[] {
            "Front",
            "Rear",
            "Dual"});
            this.cbSuspensionType.Location = new System.Drawing.Point(238, 204);
            this.cbSuspensionType.Name = "cbSuspensionType";
            this.cbSuspensionType.Size = new System.Drawing.Size(148, 28);
            this.cbSuspensionType.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Suspension Type:";
            // 
            // cbTireType
            // 
            this.cbTireType.FormattingEnabled = true;
            this.cbTireType.Items.AddRange(new object[] {
            "Regular",
            "Commuter",
            "Gravel"});
            this.cbTireType.Location = new System.Drawing.Point(447, 204);
            this.cbTireType.Name = "cbTireType";
            this.cbTireType.Size = new System.Drawing.Size(148, 28);
            this.cbTireType.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tire Type:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(34, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(273, 42);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(322, 270);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(273, 42);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // txtManufacturingYear
            // 
            this.txtManufacturingYear.Location = new System.Drawing.Point(349, 135);
            this.txtManufacturingYear.Name = "txtManufacturingYear";
            this.txtManufacturingYear.Size = new System.Drawing.Size(148, 27);
            this.txtManufacturingYear.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Manufacturing Year:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Display Bikes:";
            // 
            // rbDisplayAll
            // 
            this.rbDisplayAll.AutoSize = true;
            this.rbDisplayAll.Checked = true;
            this.rbDisplayAll.Location = new System.Drawing.Point(154, 354);
            this.rbDisplayAll.Name = "rbDisplayAll";
            this.rbDisplayAll.Size = new System.Drawing.Size(48, 24);
            this.rbDisplayAll.TabIndex = 17;
            this.rbDisplayAll.TabStop = true;
            this.rbDisplayAll.Text = "All";
            this.rbDisplayAll.UseVisualStyleBackColor = true;
            // 
            // rbDisplayMountain
            // 
            this.rbDisplayMountain.AutoSize = true;
            this.rbDisplayMountain.Location = new System.Drawing.Point(291, 354);
            this.rbDisplayMountain.Name = "rbDisplayMountain";
            this.rbDisplayMountain.Size = new System.Drawing.Size(131, 24);
            this.rbDisplayMountain.TabIndex = 18;
            this.rbDisplayMountain.Text = "Mountain Bikes";
            this.rbDisplayMountain.UseVisualStyleBackColor = true;
            // 
            // rbDisplayRoad
            // 
            this.rbDisplayRoad.AutoSize = true;
            this.rbDisplayRoad.Location = new System.Drawing.Point(492, 354);
            this.rbDisplayRoad.Name = "rbDisplayRoad";
            this.rbDisplayRoad.Size = new System.Drawing.Size(103, 24);
            this.rbDisplayRoad.TabIndex = 19;
            this.rbDisplayRoad.Text = "Road Bikes";
            this.rbDisplayRoad.UseVisualStyleBackColor = true;
            // 
            // lstBikes
            // 
            this.lstBikes.FormattingEnabled = true;
            this.lstBikes.ItemHeight = 20;
            this.lstBikes.Location = new System.Drawing.Point(34, 415);
            this.lstBikes.Name = "lstBikes";
            this.lstBikes.Size = new System.Drawing.Size(561, 124);
            this.lstBikes.TabIndex = 20;
            this.lstBikes.SelectedIndexChanged += new System.EventHandler(this.lstBikes_SelectedIndexChanged_1);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(34, 555);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(126, 50);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(181, 555);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(126, 52);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(322, 555);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 50);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(469, 555);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 50);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // txtOriginalSerialNumber
            // 
            this.txtOriginalSerialNumber.Location = new System.Drawing.Point(135, 135);
            this.txtOriginalSerialNumber.Name = "txtOriginalSerialNumber";
            this.txtOriginalSerialNumber.Size = new System.Drawing.Size(148, 27);
            this.txtOriginalSerialNumber.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(135, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Original Serial Number:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 619);
            this.Controls.Add(this.txtOriginalSerialNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstBikes);
            this.Controls.Add(this.rbDisplayRoad);
            this.Controls.Add(this.rbDisplayMountain);
            this.Controls.Add(this.rbDisplayAll);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtManufacturingYear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbTireType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSuspensionType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBikeType);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbBikeType;
        private Label label2;
        private TextBox txtSerialNumber;
        private Label label3;
        private TextBox txtModel;
        private ComboBox cbColor;
        private Label label4;
        private ComboBox cbSuspensionType;
        private Label label5;
        private ComboBox cbTireType;
        private Label label6;
        private Button btnAdd;
        private Button btnUpdate;
        private TextBox txtManufacturingYear;
        private Label label7;
        private Label label8;
        private RadioButton rbDisplayAll;
        private RadioButton rbDisplayMountain;
        private RadioButton rbDisplayRoad;
        private ListBox lstBikes;
        private Button btnRemove;
        private Button btnSearch;
        private Button btnSave;
        private Button btnExit;
        private TextBox txtOriginalSerialNumber;
        private Label label9;
    }
}