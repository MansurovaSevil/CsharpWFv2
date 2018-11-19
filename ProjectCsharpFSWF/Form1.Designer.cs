namespace ProjectCsharpFSWF
{
    partial class FutbolSahesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FutbolSahesi));
            this.pnlTable = new System.Windows.Forms.Panel();
            this.lblPitchs = new System.Windows.Forms.Label();
            this.cmbSPitchs = new System.Windows.Forms.ComboBox();
            this.btnSifter = new System.Windows.Forms.Button();
            this.lblSDate = new System.Windows.Forms.Label();
            this.dtpSDate = new System.Windows.Forms.DateTimePicker();
            this.dgvSTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbPitch = new System.Windows.Forms.ComboBox();
            this.lblPitch = new System.Windows.Forms.Label();
            this.pnlRegistration = new System.Windows.Forms.Panel();
            this.cmbPrice = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblComplited = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.BtnAddMushteri = new System.Windows.Forms.Button();
            this.CmbPerson = new System.Windows.Forms.ComboBox();
            this.lblPerson = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.llblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.CmbTime = new System.Windows.Forms.ComboBox();
            this.pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTable)).BeginInit();
            this.pnlRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTable
            // 
            this.pnlTable.Controls.Add(this.lblPitchs);
            this.pnlTable.Controls.Add(this.cmbSPitchs);
            this.pnlTable.Controls.Add(this.btnSifter);
            this.pnlTable.Controls.Add(this.lblSDate);
            this.pnlTable.Controls.Add(this.dtpSDate);
            this.pnlTable.Controls.Add(this.dgvSTable);
            this.pnlTable.Controls.Add(this.label2);
            this.pnlTable.Location = new System.Drawing.Point(354, 9);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(704, 445);
            this.pnlTable.TabIndex = 1;
            // 
            // lblPitchs
            // 
            this.lblPitchs.AutoSize = true;
            this.lblPitchs.Location = new System.Drawing.Point(16, 66);
            this.lblPitchs.Name = "lblPitchs";
            this.lblPitchs.Size = new System.Drawing.Size(36, 13);
            this.lblPitchs.TabIndex = 29;
            this.lblPitchs.Text = "Pitchs";
            // 
            // cmbSPitchs
            // 
            this.cmbSPitchs.FormattingEnabled = true;
            this.cmbSPitchs.Location = new System.Drawing.Point(19, 82);
            this.cmbSPitchs.Name = "cmbSPitchs";
            this.cmbSPitchs.Size = new System.Drawing.Size(121, 21);
            this.cmbSPitchs.TabIndex = 28;
            // 
            // btnSifter
            // 
            this.btnSifter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSifter.Location = new System.Drawing.Point(24, 210);
            this.btnSifter.Name = "btnSifter";
            this.btnSifter.Size = new System.Drawing.Size(121, 37);
            this.btnSifter.TabIndex = 27;
            this.btnSifter.Text = "Sifter";
            this.btnSifter.UseVisualStyleBackColor = false;
            this.btnSifter.Click += new System.EventHandler(this.btnSifter_Click);
            // 
            // lblSDate
            // 
            this.lblSDate.AutoSize = true;
            this.lblSDate.Location = new System.Drawing.Point(21, 125);
            this.lblSDate.Name = "lblSDate";
            this.lblSDate.Size = new System.Drawing.Size(30, 13);
            this.lblSDate.TabIndex = 24;
            this.lblSDate.Text = "Date";
            // 
            // dtpSDate
            // 
            this.dtpSDate.CustomFormat = "dd.MM.yyyy";
            this.dtpSDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSDate.Location = new System.Drawing.Point(19, 141);
            this.dtpSDate.Name = "dtpSDate";
            this.dtpSDate.Size = new System.Drawing.Size(124, 20);
            this.dtpSDate.TabIndex = 23;
            // 
            // dgvSTable
            // 
            this.dgvSTable.AllowUserToAddRows = false;
            this.dgvSTable.AllowUserToDeleteRows = false;
            this.dgvSTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvSTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvSTable.Location = new System.Drawing.Point(165, 37);
            this.dgvSTable.Name = "dgvSTable";
            this.dgvSTable.Size = new System.Drawing.Size(517, 384);
            this.dgvSTable.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Pitch";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Person";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Hours";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Price";
            this.Column7.Name = "Column7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Table";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // CmbPitch
            // 
            this.CmbPitch.FormattingEnabled = true;
            this.CmbPitch.Location = new System.Drawing.Point(16, 117);
            this.CmbPitch.Name = "CmbPitch";
            this.CmbPitch.Size = new System.Drawing.Size(214, 21);
            this.CmbPitch.TabIndex = 1;
            this.CmbPitch.SelectedIndexChanged += new System.EventHandler(this.CmbPitch_SelectedIndexChanged);
            // 
            // lblPitch
            // 
            this.lblPitch.AutoSize = true;
            this.lblPitch.Location = new System.Drawing.Point(14, 103);
            this.lblPitch.Name = "lblPitch";
            this.lblPitch.Size = new System.Drawing.Size(31, 13);
            this.lblPitch.TabIndex = 2;
            this.lblPitch.Text = "Pitch";
            // 
            // pnlRegistration
            // 
            this.pnlRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlRegistration.Controls.Add(this.cmbPrice);
            this.pnlRegistration.Controls.Add(this.lblPrice);
            this.pnlRegistration.Controls.Add(this.cmbRoom);
            this.pnlRegistration.Controls.Add(this.lblRoom);
            this.pnlRegistration.Controls.Add(this.lblComplited);
            this.pnlRegistration.Controls.Add(this.btnSend);
            this.pnlRegistration.Controls.Add(this.BtnAddMushteri);
            this.pnlRegistration.Controls.Add(this.CmbPerson);
            this.pnlRegistration.Controls.Add(this.lblPerson);
            this.pnlRegistration.Controls.Add(this.lblTime);
            this.pnlRegistration.Controls.Add(this.llblDate);
            this.pnlRegistration.Controls.Add(this.dtpDate);
            this.pnlRegistration.Controls.Add(this.CmbTime);
            this.pnlRegistration.Controls.Add(this.lblPitch);
            this.pnlRegistration.Controls.Add(this.CmbPitch);
            this.pnlRegistration.Controls.Add(this.label1);
            this.pnlRegistration.Location = new System.Drawing.Point(0, 9);
            this.pnlRegistration.Name = "pnlRegistration";
            this.pnlRegistration.Size = new System.Drawing.Size(332, 445);
            this.pnlRegistration.TabIndex = 0;
            // 
            // cmbPrice
            // 
            this.cmbPrice.FormattingEnabled = true;
            this.cmbPrice.Location = new System.Drawing.Point(18, 347);
            this.cmbPrice.Name = "cmbPrice";
            this.cmbPrice.Size = new System.Drawing.Size(212, 21);
            this.cmbPrice.TabIndex = 26;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(19, 331);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 25;
            this.lblPrice.Text = "Price";
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(18, 294);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(212, 21);
            this.cmbRoom.TabIndex = 23;
            this.cmbRoom.SelectedIndexChanged += new System.EventHandler(this.cmbRoom_SelectedIndexChanged);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(15, 278);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(35, 13);
            this.lblRoom.TabIndex = 22;
            this.lblRoom.Text = "Room";
            // 
            // lblComplited
            // 
            this.lblComplited.AutoSize = true;
            this.lblComplited.Location = new System.Drawing.Point(57, 423);
            this.lblComplited.Name = "lblComplited";
            this.lblComplited.Size = new System.Drawing.Size(115, 13);
            this.lblComplited.TabIndex = 20;
            this.lblComplited.Text = "Registration completed";
            this.lblComplited.Visible = false;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Lime;
            this.btnSend.Location = new System.Drawing.Point(42, 385);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(141, 35);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // BtnAddMushteri
            // 
            this.BtnAddMushteri.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnAddMushteri.Location = new System.Drawing.Point(236, 66);
            this.BtnAddMushteri.Name = "BtnAddMushteri";
            this.BtnAddMushteri.Size = new System.Drawing.Size(45, 21);
            this.BtnAddMushteri.TabIndex = 9;
            this.BtnAddMushteri.Text = "Add";
            this.BtnAddMushteri.UseVisualStyleBackColor = false;
            this.BtnAddMushteri.Visible = false;
            this.BtnAddMushteri.Click += new System.EventHandler(this.BtnAddMushteri_Click);
            // 
            // CmbPerson
            // 
            this.CmbPerson.FormattingEnabled = true;
            this.CmbPerson.Location = new System.Drawing.Point(17, 66);
            this.CmbPerson.Name = "CmbPerson";
            this.CmbPerson.Size = new System.Drawing.Size(213, 21);
            this.CmbPerson.TabIndex = 8;
            this.CmbPerson.Visible = false;
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(14, 50);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(40, 13);
            this.lblPerson.TabIndex = 7;
            this.lblPerson.Text = "Person";
            this.lblPerson.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(14, 222);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time";
            // 
            // llblDate
            // 
            this.llblDate.AutoSize = true;
            this.llblDate.Location = new System.Drawing.Point(15, 161);
            this.llblDate.Name = "llblDate";
            this.llblDate.Size = new System.Drawing.Size(30, 13);
            this.llblDate.TabIndex = 5;
            this.llblDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(17, 177);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(213, 20);
            this.dtpDate.TabIndex = 4;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // CmbTime
            // 
            this.CmbTime.FormattingEnabled = true;
            this.CmbTime.Location = new System.Drawing.Point(18, 238);
            this.CmbTime.Name = "CmbTime";
            this.CmbTime.Size = new System.Drawing.Size(212, 21);
            this.CmbTime.TabIndex = 3;
            this.CmbTime.SelectedIndexChanged += new System.EventHandler(this.CmbTime_SelectedIndexChanged);
            // 
            // FutbolSahesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1070, 478);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.pnlRegistration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FutbolSahesi";
            this.Text = "Soccer field";
            this.pnlTable.ResumeLayout(false);
            this.pnlTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSTable)).EndInit();
            this.pnlRegistration.ResumeLayout(false);
            this.pnlRegistration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbPitch;
        private System.Windows.Forms.Label lblPitch;
        private System.Windows.Forms.Panel pnlRegistration;
        private System.Windows.Forms.ComboBox CmbPerson;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label llblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox CmbTime;
        private System.Windows.Forms.Button BtnAddMushteri;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblComplited;
        private System.Windows.Forms.Button btnSifter;
        private System.Windows.Forms.Label lblSDate;
        private System.Windows.Forms.DataGridView dgvSTable;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ComboBox cmbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPitchs;
        private System.Windows.Forms.ComboBox cmbSPitchs;
        private System.Windows.Forms.DateTimePicker dtpSDate;
    }
}

