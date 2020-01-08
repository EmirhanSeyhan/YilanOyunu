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
    public partial class Duvarlı : Form
    {
        public Duvarlı()
        {
            InitializeComponent();
        }
        Baslangıc frm = new Baslangıc();
        int skor = 0;
        Random rnd = new Random();
        Yilan yilan;




        private void Duvarlı_Load(object sender, EventArgs e)
        {
            timer5.Start();
            yilan = new Yilan(Bas, yem, this, Baslangıc.renkli);
            yilan.DuvaraCarpti(pictureBox1, pictureBox2, pictureBox3, pictureBox4);
            yem.Top = rnd.Next(0, 500);
            yem.Left = rnd.Next(0, 500);
            
        }

        private void Duvarlı_KeyDown(object sender, KeyEventArgs e)
        {
            yilan.YonTespitEt(e);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (yilan.CarpismaKontrol())
            {
                timer5.Stop();
                MessageBox.Show("Yandınız Skorunuz :" + label1.Text);
                this.Close();
                frm.Show();
            }

            if (yilan.DuvaraCarpti())
            {
                timer5.Stop();
                MessageBox.Show("Yandınız Skorunuz :" + label1.Text);
                this.Close();
                frm.Show();
            }

            yilan.VucutTakip();
            yilan.Yonlendir();

            #region Yem

            if (yilan.YemiYedi())
            {
                yilan.YemKonumlandir();


                if (timer5.Interval != 2)
                {
                    timer5.Interval -= 2;
                }

                skor += 10;
                label1.Text = skor + "";

                this.Controls.Add(yilan.YilanBuyut());

            }
            #endregion
        }
    }
}
