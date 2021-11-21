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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int c = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
        
        }

           
        private void btnfilmleredön_Click_1(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }

        private void btnson_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void btnsatinal_Click(object sender, EventArgs e)
        {
            foreach (Button btn in flowLayoutPanel1.Controls)
            {
                if (btn.ForeColor == Color.AliceBlue)
                {
                    btn.BackColor = Color.Red;
                    btn.ForeColor = Color.Black;
                }
            }
           
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            foreach (Button btn in flowLayoutPanel1.Controls)
            {
                if (btn.ForeColor == Color.AliceBlue)
                {
                    btn.BackColor = Color.Green;
                    btn.ForeColor = Color.Black;
                }
            }
        }

        private void btnodeme_Click(object sender, EventArgs e)
        {

        }
    }
}
