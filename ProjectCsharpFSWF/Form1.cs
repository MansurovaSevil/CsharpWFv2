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
    public partial class FutbolSahesi : Form
    {
        private FutbolSahesiEntities db = new FutbolSahesiEntities();

       private TimeSpan startTime = new TimeSpan(9, 0, 0);
       private TimeSpan endTime = new TimeSpan(2, 0, 0);
        public FutbolSahesi()
        {
            InitializeComponent();
            FillMeydancalarList();

            FillTime();
            FillMushteri();
          
        }

        private void FillMeydancalarList()
        {

            ////////////////////////////// Registration /////////////////////////////////////
            cmbPrice.Items.Clear();
            if (CmbPitch.SelectedItem != null)
            {
                Meydancalar meydanca = new Meydancalar();
                meydanca = db.Meydancalars.FirstOrDefault(m => m.Name == CmbPitch.Text);
                cmbPrice.Items.Add(meydanca.Price);
            }

            CmbPitch.Items.Clear();
            foreach (Meydancalar Item in db.Meydancalars.ToList())
            {
                CmbPitch.Items.Add(Item.Name);
            }

             
            foreach (Otaqlar Item in db.Otaqlars.ToList())
            {
                cmbRoom.Items.Add(Item.Number);
            }

          
        }

        private void CmbPitch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            FillTime();
        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            FillTime();
            
        }

        private void FillTime()
        {
            /////////// TIME //////////

            if (string.IsNullOrEmpty(CmbPitch.Text))
            {
                MessageBox.Show("Select Pitch");
                return;
            }
            CmbTime.Items.Clear();
            CmbTime.Text = " ";

            CmbPerson.Items.Clear();
            lblPerson.Visible = false;
            CmbPerson.Visible = false;
            CmbPerson.Text = " ";
            BtnAddMushteri.Visible = false;


            Meydancalar myd = db.Meydancalars.FirstOrDefault(m => m.Name == CmbPitch.Text);
            {
                //MessageBox.Show(myd.Name.ToString());
            }
            

            int interval = (int)(endTime.Subtract(startTime).TotalHours + 24);

            TimeSpan tmpTime = startTime;

            for (int i=0; i<interval; i++)
            {

                int count = db.Bookings.Where(b => b.MeydancaId == myd.Id && b.Date == dtpDate.Value.Date && b.Time == tmpTime).Count();
                if (count==0)
                {
                    CmbTime.Items.Add(tmpTime.ToString(@"hh\:mm"));
                }


                tmpTime = tmpTime.Add(new TimeSpan(1, 0, 0));

                if (tmpTime.Hours == 0)
                {
                    tmpTime = new TimeSpan(1, 0, 0);
                }
            }

            //MessageBox.Show((endTime.Subtract(startTime).TotalHours+24).ToString());


            //Otaqlar oty = db.Otaqlars.FirstOrDefault(o => o.Number == cmbRoom);

        }
      
        private void FillMushteri()

            //////////////////// Mushteri //////////////////////////////////////////
        {
            CmbPerson.Items.Clear();
            foreach (Mushteri item in db.Mushteris.OrderBy(c => c.Name).OrderBy(c=>c.Surname).ToList()) 
            { 
             CmbPerson.Items.Add(item.Name + "," + item.Surname + "," + item.Phone);
            }

        }

        private void CmbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CmbTime.Text))
            {
                FillMushteri();
                lblPerson.Visible = true;
                CmbPerson.Visible = true;
                BtnAddMushteri.Visible = true;
            }
        }
        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillMushteri();
            FillMeydancalarList();
        }
        public void AddedMushteri(Mushteri msht)
        {
            FillMushteri();
            CmbPerson.Items.Add(msht.Name + "," + msht.Surname + "," + msht.Phone);
        }
        private void BtnAddMushteri_Click(object sender, EventArgs e)
        {
            AddMushteri addMushteri = new AddMushteri(this);
            addMushteri.ShowDialog();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CmbPerson.Text))
            {
                
                MessageBox.Show("Select Person");
                return;
            }

            TimeSpan time  =  new TimeSpan(Convert.ToInt32(CmbTime.Text.Split(':')[0]), 0, 0);
            DateTime date = dtpDate.Value.Date;

            if (time.Hours < startTime.Hours)
            {
              date = date.AddDays(1);
            }

            string phone = CmbPerson.Text.Split(',')[2];


                Booking book = new Booking
            {
                MeydancaId = db.Meydancalars.FirstOrDefault(m=>m.Name == CmbPitch.Text).Id,
                Date = date,
                Time = time,
                CreatedAt = DateTime.Now,
                MushteriId = db.Mushteris.FirstOrDefault(m=>m.Phone == phone).Id
            };

            db.Bookings.Add(book);
            db.SaveChanges();

            ////////////////////

            cmbRoom.Items.Clear();
            cmbRoom.Text = " ";

            CmbTime.Items.Clear();
            CmbTime.Text = " ";
            

            CmbPerson.Items.Clear();
            lblPerson.Visible = false;
            CmbPerson.Visible = false;
            CmbPerson.Text = " ";
            BtnAddMushteri.Visible = false;

            dtpDate.Value = DateTime.Now;
            CmbPitch.Text = " ";


            lblComplited.Visible = true;

        }


        ///////// Table Sifter//////////



        private void FillTable() 
        {
            //foreach (Booking item1 in db.Bookings.Where(b=>b.Date == dtp)
            //{
                
            //}
            
            
            foreach (Booking item in db.Bookings.Where(b => b.Date == dtpSDate.Value.Date).OrderBy(b => b.MeydancaId).OrderBy(b => b.Time).ToList()) 
            {
                dgvSTable.Rows.Add(item.Id, 
                    item.Meydancalar.Name,
                    item.Mushteri.Name + " " + item.Mushteri.Surname,
                    item.Mushteri.Phone,
                    item.Date.ToString("dd.MM.yyyy"), 
                    item.Time.ToString(@"hh\:mm"),
                    item.Price.ToString());
           
            }
        }

        private void btnSifter_Click(object sender, EventArgs e)
        {
            FillTable();
            dgvSTable.Rows.Clear();

            List<Booking> bookings = db.Bookings.Where(b => b.Date == dtpSDate.Value.Date).OrderBy(b => b.MeydancaId).OrderBy(b => b.Time).ToList();

            foreach (Booking item in db.Bookings)
            {
                dgvSTable.Rows.Add(item.Id,
                    item.Meydancalar.Name,
                    item.Mushteri.Name + " " + item.Mushteri.Surname,
                    item.Mushteri.Phone,
                    item.Date.ToString("dd.MM.yyyy"),
                    item.Time.ToString(@"hh\:mm"),
                    item.Price.ToString());

            }



        }

     

      

    }
}
