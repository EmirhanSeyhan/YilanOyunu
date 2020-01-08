using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Simulasyon
{
    public partial class Baslangıc : Form
    {
        public Baslangıc()
        {
            InitializeComponent();
        }
        public static bool renkli = false;
        private void Baslangıc_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (checkBox2.Checked)
            {
                renkli = true;
                Form1 frm = new Form1();
                this.Hide();
                frm.Show();
            }
            else if (checkBox1.Checked)
            {
                renkli = false;
                Form1 frm = new Form1();
                this.Hide();
                frm.Show();
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                renkli = true;
                Duvarlı frm = new Duvarlı();
                this.Hide();
                frm.Show();
            }
            else if (checkBox1.Checked)
            {
                renkli = false;
                Duvarlı frm = new Duvarlı();
                this.Hide();
                frm.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
