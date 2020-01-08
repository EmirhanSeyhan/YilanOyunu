using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Simulasyon
{
    public class Yilan
    {

        #region field
        public PictureBox yem=new PictureBox();
        public Button Bas = new Button();
        public Form f = new Form();
        public Duvarlı dv = new Duvarlı();

        Yon yilaninYonu;

        private int adim;
        private bool renkliYilan; 
     
        private List<PictureBox> duvarlar = new List<PictureBox>();
        private List<Button> yilan = new List<Button>();
        bool yonDegisti = false;
        #endregion

        #region method
        //Kurucu metot - nesneyi oluşturduğumuzda çalışır
        //Buraya Kullanacağımız Mataryelleri verya nesneleri yazıyoruz ...
        public Yilan(Button _bas,PictureBox _yem,Form _form,bool _renkliYilan)
        {
            this.Bas = _bas;
            this.yem = _yem;
            this.f = _form;
            this.renkliYilan = _renkliYilan;
            this.adim = _bas.Width;

            yilan.Add(Bas);
        }

        public void YonTespitEt(KeyEventArgs e)
        {
            if (yonDegisti)
                return;
            
            Yon eskiYon = yilaninYonu;



            if (yilaninYonu != Yon.YUKARI)
            {
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                {
                    yilaninYonu = Yon.ASAGI;
                }
            }
            if (yilaninYonu!=Yon.SOL)
            {
                if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
                {
                    yilaninYonu = Yon.SAG;
                }            
            }
            if (yilaninYonu!=Yon.SAG)
            {
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
                {
                    yilaninYonu = Yon.SOL;
                }
            
            }
            if (yilaninYonu != Yon.ASAGI)
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
                {
                    yilaninYonu = Yon.YUKARI;
                }
            }

            if (eskiYon != yilaninYonu)
            {
                yonDegisti = true;
            }
        }

        public bool CarpismaKontrol()
        {
            for (int i = 1; i < yilan.Count - 1; i++)
            {
                if (Bas.Bounds.IntersectsWith(yilan[i].Bounds))
                {
                    return true;                 
                }
            }
            return false;
        }

        public void YemKonumlandir()
        {
            Random rnd = new Random();
            bool yemYerlestir=true;

            
            YEM_YERLESTIR:
            yem.Top = rnd.Next(0, f.Height - 100);
            yem.Left = rnd.Next(0, f.Width - 100);
            for (int i = 0; i < yilan.Count; i++)
            {
                //Çakışma var
                if (yilan[i].Bounds.IntersectsWith(yem.Bounds))
                {
                    goto YEM_YERLESTIR;
                }
            }
    
        }

        public enum Yon
        {
            YUKARI, ASAGI, SAG, SOL
        }

        public void SonsuzGecis()
        {
            if (Bas.Top <= f.Top)
            {
                Bas.Top = f.Bottom;
            }
            else if (Bas.Top >= f.Bottom)
            {
                Bas.Top = f.Top;
            }

            if (Bas.Right > f.Right)
            {
                Bas.Left = f.Left;
            }
            else if (Bas.Left <= f.Left)
            {
                Bas.Left = f.Right;
            }
        }

        public bool DuvaraCarpti(params PictureBox[] eklenecek_duvarlar)
        {
            foreach (PictureBox duvar in eklenecek_duvarlar)
            {
                this.duvarlar.Add(duvar);
            }

            foreach (PictureBox duvar in duvarlar)
            {
                //Döngü ile tüm duvarlara çarpma kontrolü
                if (Bas.Bounds.IntersectsWith(duvar.Bounds))
                {
                    return true;
                }
            }
            return false;

        }

        public void VucutTakip()
        {
                for (int i = yilan.Count; i > 1; i--)
                {
                    yilan[i - 1].Top = yilan[i - 2].Top;
                    yilan[i - 1].Left = yilan[i - 2].Left;
                }
        }

        public void Yonlendir()
        {
                switch (yilaninYonu)
                {
                    case Yon.YUKARI:
                        Bas.Top -= adim;
                        break;
                    case Yon.ASAGI:
                        Bas.Top += adim;
                        break;
                    case Yon.SAG:
                        Bas.Left += adim;
                        break;
                    case Yon.SOL:
                        Bas.Left -= adim;
                        break;   
                }

                yonDegisti = false;
        }

        int x, y, z;
        public void Renklendir()
        {
            Random rnd = new Random();

            x = rnd.Next(255);
            y = rnd.Next(255);
            z = rnd.Next(255);
        }

        public Button YilanBuyut()
        {

            Button yeniKutu = new Button();

            if (renkliYilan)
            {
                Renklendir();
                yeniKutu.BackColor = Color.FromArgb(x, y, z);
            }
            else
            {
                yeniKutu.BackColor = yilan.Last().BackColor;
            }



                yeniKutu.Width = yeniKutu.Height = yilan.Last().Width;
                yeniKutu.Top = yilan.Last().Top;
                yeniKutu.Left = yilan.Last().Left;
                yeniKutu.Enabled = false;
                
                
                switch (yilaninYonu)
                {
                    case Yon.YUKARI:
                        yeniKutu.Top += adim;
                        break;
                    case Yon.ASAGI:
                        yeniKutu.Top -= adim;
                        break;
                    case Yon.SAG:
                        yeniKutu.Left += adim;
                        break;
                    case Yon.SOL:
                        yeniKutu.Left -= adim;
                        break;
                }

                yeniKutu.Text = (yilan.Count() + 1) + "";

                

                yilan.Add(yeniKutu);


                return yeniKutu;
        }

        public bool YemiYedi()
        {
            if (Bas.Bounds.IntersectsWith(yem.Bounds))
                return true;
            return false;
        }
        #endregion
    }
}
