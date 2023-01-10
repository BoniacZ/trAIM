using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace trAIM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ukrycieMenu();
            przygotowanie();
        }

        private void ukrycieMenu()
        {
            panelTryby.Visible = false;
            panelStaty.Visible = false;
        }

        private void ukrycieOpcji()
        {
            if (panelTryby.Visible == true)
            {
                panelTryby.Visible = false;
            }
            if (panelStaty.Visible == true)
            {
                panelStaty.Visible = false;
            }
        }

        private void pokazanieOpcji(Panel opcja)
        {
            if (opcja.Visible == false)
            {
                ukrycieOpcji();
                opcja.Visible = true;
            }
            else
            {
                opcja.Visible = false;
            }
        }

        #region Tryby
        private void btnTryby_Click(object sender, EventArgs e)
        {
            pokazanieOpcji(panelTryby);
            if (gameTimer.Enabled)
            {
                koniecGry();
            }
        }

        private void btnTryb1_Click(object sender, EventArgs e)
        {
            lblOpis.Text = "opis trybu 1";
            tryb = 1;
            btnStart.Visible = true;
            ukrycieOpcji();
        }

        private void btnTryb2_Click(object sender, EventArgs e)
        {
            lblOpis.Text = "opis trybu 2";
            tryb = 2;
            btnStart.Visible = true;
            ukrycieOpcji();
        }

        private void btnTryb3_Click(object sender, EventArgs e)
        {
            lblOpis.Text = "opis trybu 3";
            tryb = 3;
            btnStart.Visible = true;
            ukrycieOpcji();
        }
        #endregion
        #region Staty

        private void btnStaty_Click(object sender, EventArgs e)
        {
            pokazanieOpcji(panelStaty);
        }

        private void btnStaty1_Click(object sender, EventArgs e)
        {

            ukrycieOpcji();
        }

        private void btnStaty2_Click(object sender, EventArgs e)
        {
            
            ukrycieOpcji();
        }
        #endregion
        private void btnPrzerwij_Click(object sender, EventArgs e)
        {
            koniecGry();
            ukrycieOpcji();
        }

        Random rand = new Random();
        List<PictureBox> obiekty = new List<PictureBox>();
        int punkty;
        int czasSek = 120;
        int sekundy = 0;
        int minuty = 2;
        int tryb = 0;
        int klikIlosc;
        double klikTrafione;
        int obiektyIlosc;
        double obiektyTrafione;
        private void przygotowanie()
        {
            lblOpis.Text = "Wybierz tryb gry aby rozpocząć";
            btnStart.Visible = false;
            lblOpis.Visible = true;
            lblUkrycie();
            punkty = 0;
            sekundy = 0;
            minuty = 2;
            klikIlosc = 0;
            klikTrafione = 0;
            obiektyIlosc = -1;
            obiektyTrafione = 0;
        }

        private async Task MakePictureBoxAsync()
        {
            PictureBox newPic = new PictureBox();
            //rozmiary obiektu
            newPic.Height = 50;
            newPic.Width = 50;
            newPic.BackColor = Color.Crimson;
            //lokalizacja obiektu - wyeliminowanie sytuacji w której część obiektu wystaje poza okno gry
            int x = rand.Next(newPic.Width + 10, panelGame.Width - newPic.Width - 10);
            int y = rand.Next(newPic.Height + 10, panelGame.Height - newPic.Height - 10);
            newPic.Location = new Point(x, y);
            obiekty.Add(newPic);
            this.Controls.Add(newPic);
            panelGame.Controls.Add(newPic);
            obiektyIlosc++;
            newPic.Click += NewPic_Click;
            //usunięcie obiektu po 2.5 sekundy 
            await Task.Delay(2500);
            if (newPic.IsDisposed == false)
            {
                punktyMinus();
            }
            obiekty.Remove(newPic);
            panelGame.Controls.Remove(newPic);
            newPic.Dispose();
            lblUpdate(0);
        }

        private void NewPic_Click(object sender, EventArgs e)
        {
            PictureBox temPic = sender as PictureBox;
            obiekty.Remove(temPic);
            this.Controls.Remove(temPic);
            panelGame.Controls.Remove(temPic);
            temPic.Dispose();
            odtworzDzwiek();
            klikIlosc++;
            klikTrafione++;
            obiektyTrafione++;
            punkty += 10;
            lblUpdate(0);
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            czasSek--;
            stoper();
            if (czasSek < 1)
            {
                koniecGry();
            }
            if (czasSek > 2)
            {
                MakePictureBoxAsync();
            }
            lblUpdate(1);
        }

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void punktyMinus()
        {
            punkty -= 15;
            if (punkty < 0)
            {
                punkty = 0;
            }
        }

        private void lblUpdate(int n)
        {
            if (sekundy < 10)
            {
                lblCzas.Text = minuty.ToString() + ":0" + sekundy.ToString();
            }
            else
            {
                lblCzas.Text = minuty.ToString() + ":" + sekundy.ToString();
            }
            lblLicznikObiektow.Text = "Obiekty: " + obiekty.Count();
            lblPunkty.Text = "Punkty: " + punkty;
            lblCelnosc.Text = "Celność: " + celnosc() + "%";
            if (n == 1)
            {
                lblTrafienia.Text = "Trafienia: " + trafienia() + "%";
            }
        }

        private void lblUkrycie()
        {
            lblCelnosc.Visible = false;
            lblCzas.Visible = false;
            lblLicznikObiektow.Visible = false;
            lblPunkty.Visible = false;
            lblTrafienia.Visible = false;
        }

        private void lblReset()
        {
            lblCelnosc.Text = "Celność: 0%";
            lblCelnosc.Visible = true;
            lblCzas.Text = "2:00";
            lblCzas.Visible = true;
            lblLicznikObiektow.Text = "Obiekty: 0";
            lblLicznikObiektow.Visible = true;
            lblPunkty.Text = "Punkty: 0";
            lblPunkty.Visible = true;
            lblTrafienia.Text = "Trafienia: 0%";
            lblTrafienia.Visible = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            czasSek = 120;
            gameTimer.Start();
            lblReset();
            btnStart.Visible = false;
            lblOpis.Visible = false;
        }

        private void stoper()
        {
            sekundy = czasSek % 60;
            minuty = czasSek / 60;
        }
        private void koniecGry()
        {
            gameTimer.Stop();
            zapisDanych();
            czasSek = 0;
            obiekty.Clear();
            FrmPodsumowanie podsumowanie = new FrmPodsumowanie();
            podsumowanie.Show();
            przygotowanie();
        }

        private double celnosc()
        {
            double accuracy = (klikTrafione / klikIlosc) * 100;
            if (Double.IsNaN(accuracy))
            {
                return 0;
            }
            //zaokrąglenie do 2 miejsc po przecinku
            accuracy = Math.Round(accuracy, 2);
            return accuracy;
        }

        private double trafienia()
        {
            double targets = (obiektyTrafione / obiektyIlosc) * 100;
            if (Double.IsNaN(targets))
            {
                return 0;
            }
            //zaokrąglenie do 2 miejsc po przecinku
            targets = Math.Round(targets, 2);
            return targets;
        }

        private void panelGame_Click(object sender, EventArgs e)
        {
            klikIlosc++;
        }

        private void odtworzDzwiek()
        {
            SoundPlayer odtwarzacz = new SoundPlayer(trAIM.Properties.Resources.Blop_Mark_DiAngelo_79054334);
            odtwarzacz.Play();
        }

        public static class dane
        {
            public static int wynik;
            public static double czas;
            public static int gTryb;
            public static double kTrafione;
            public static int kIlosc;
            public static double oTrafione;
            public static int oIlosc;
        }

        private void zapisDanych()
        {
            dane.wynik = punkty;
            dane.czas = 120 - czasSek;
            dane.gTryb = tryb;
            dane.kTrafione = klikTrafione;
            dane.kIlosc = klikIlosc;
            dane.oTrafione = obiektyTrafione;
            dane.oIlosc = obiektyIlosc;
        }
    }
}
