using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectCsharpFSWF.Models;

namespace ProjectCsharpFSWF
{
    public partial class AddMushteri : Form
    {
        private FutbolSahesiEntities db = new FutbolSahesiEntities();
        private FutbolSahesi HomeForm;
        public AddMushteri(FutbolSahesi frm)
        {
            HomeForm = frm;
            InitializeComponent();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {

            int errCount = 0;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errCount++;
                lblMName.ForeColor = Color.DarkRed;
            }
            else
            {
                errCount--;
                lblMName.ForeColor = SystemColors.ControlText;
            }

            //////////////////////////////////////////////////

            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                errCount++;
                lblMSurname.ForeColor = Color.DarkRed;
            }
            else
            {
                errCount--;
                lblMSurname.ForeColor = SystemColors.ControlText;
            }

            ///////////////////////////////////////////////////////

            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                errCount++;
                lblMPhone.ForeColor = Color.DarkRed;
            }
            else
            {
                errCount--;
                lblMPhone.ForeColor = SystemColors.ControlText;
            }

            if (errCount > 0)
            {
                return;

            }

            if (db.Mushteris.FirstOrDefault(m => m.Phone == txtPhone.Text) == null)
            {

                Mushteri msht = new Mushteri
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Phone = txtPhone.Text
            };
                db.Mushteris.Add(msht);
                db.SaveChanges();
                HomeForm.AddedMushteri(msht);

            }

            else
           {
            Mushteri msht = db.Mushteris.FirstOrDefault(m => m.Phone == txtPhone.Text);
            
             HomeForm.AddedMushteri(msht);
            }

            this.Close();
        }
    }
}
