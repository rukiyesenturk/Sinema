using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sİnema
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        
        void salonlar(string filmadi)
        {
            Form4 frm = new Form4();           
            Form2 frm1 = new Form2();
            //frm1.Show();
            frm.Show();
        
            for (int i = 1; i < 6; i++)
            {
                Button btn = new Button();
                btn.Width = 60;
                btn.Height = 60;
                btn.BackColor = Color.Green;
                btn.ForeColor = Color.Black;
                btn.Text = i.ToString();
                frm.flowLayoutPanel1.Controls.Add(btn);
                btn.Click += btn_Clik;
                frm.label1.Text = filmadi.ToString() + " - SALONLAR";
                string ad = filmadi;
                btn.Tag = filmadi;
                frm1.label1.Text = filmadi.ToString()+" - SALONLAR" + " - ODALAR";
                
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            salonlar("HARRY POTTER");
            this.Hide(); 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            salonlar("AVATAR");
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            salonlar("MADAGASCAR");
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            salonlar("TITANIC");
            this.Hide();
        }

        public void btn_Clik(object sender, EventArgs e)
        {
            Form2 frm1 = new Form2();
            frm1.Show();
            Form4 frm = new Form4();
            frm.Hide();
            for (int i = 1; i < 31; i++)
            {
                Button btn = new Button();
               
                btn.Width = 45;
                btn.Height = 45;
                btn.BackColor = Color.Green;
                btn.ForeColor = Color.Black;
                btn.Text = i.ToString();
                frm1.flowLayoutPanel1.Controls.Add(btn);
                btn.Click += btnoda_Clik;
                frm1.label1.Text =  "ODALAR";
            }
           
        }
        public void btnoda_Clik(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Hide();
            Button btn = (Button)sender;
            if (btn.ForeColor == Color.Black)
            {
                btn.ForeColor = Color.AliceBlue;
            }
            else if (btn.ForeColor == Color.AliceBlue)
            {
                btn.ForeColor = Color.Black;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
