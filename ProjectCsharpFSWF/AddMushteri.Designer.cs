namespace ProjectCsharpFSWF
{
    partial class AddMushteri
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
            this.lblMName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblMSurname = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblMPhone = new System.Windows.Forms.Label();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Location = new System.Drawing.Point(12, 14);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(35, 13);
            this.lblMName.TabIndex = 0;
            this.lblMName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Info;
            this.txtName.Location = new System.Drawing.Point(12, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.SystemColors.Info;
            this.txtSurname.Location = new System.Drawing.Point(12, 91);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(181, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // lblMSurname
            // 
            this.lblMSurname.AutoSize = true;
            this.lblMSurname.Location = new System.Drawing.Point(12, 75);
            this.lblMSurname.Name = "lblMSurname";
            this.lblMSurname.Size = new System.Drawing.Size(49, 13);
            this.lblMSurname.TabIndex = 2;
            this.lblMSurname.Text = "Surname";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Info;
            this.txtPhone.Location = new System.Drawing.Point(12, 149);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(181, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // lblMPhone
            // 
            this.lblMPhone.AutoSize = true;
            this.lblMPhone.Location = new System.Drawing.Point(12, 133);
            this.lblMPhone.Name = "lblMPhone";
            this.lblMPhone.Size = new System.Drawing.Size(38, 13);
            this.lblMPhone.TabIndex = 4;
            this.lblMPhone.Text = "Phone";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackColor = System.Drawing.Color.DarkViolet;
            this.btnAddPerson.Location = new System.Drawing.Point(12, 198);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(181, 46);
            this.btnAddPerson.TabIndex = 6;
            this.btnAddPerson.Text = "Add";
            this.btnAddPerson.UseVisualStyleBackColor = false;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // AddMushteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(262, 311);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblMPhone);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblMSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMushteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblMSurname;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblMPhone;
        private System.Windows.Forms.Button btnAddPerson;
    }
}