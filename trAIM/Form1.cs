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
using System.Diagnostics;
using System.IO;

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

        #region Obsługa menu
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
        #endregion

        #region Przyciski trybów
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
            lblOpis.Location = new Point(190, 200);
            lblOpis.Text = "Klikaj w znikające obiekty aby zdobyć punkty\n\n\n\nKliknij aby rozpocząć";
            tryb = 1;
            btnStart.Visible = true;
            ukrycieOpcji();
        }

        private void btnTryb2_Click(object sender, EventArgs e)
        {
            lblOpis.Location = new Point(100, 200);
            tryb = 2;
            btnStart.Visible = true;
            tryb2Cel(2);
            obiektyIlosc = 0;
            ukrycieOpcji();
        }

        private void btnTryb3_Click(object sender, EventArgs e)
        {
            lblOpis.Location = new Point(50, 200);
            lblOpis.Text = "Klikaj w obiekty o kolorze podanym na ekranie aby zdobyć punkty\n\n\n\nKliknij aby rozpocząć";
            tryb = 3;
            btnStart.Visible = true;
            obiektyIlosc = 0;
            ukrycieOpcji();
        }
        #endregion

        #region Przyciski statystyk

        private void btnStaty_Click(object sender, EventArgs e)
        {
            pokazanieOpcji(panelStaty);
            if (gameTimer.Enabled)
            {
                koniecGry();
            }
        }

        private void btnStaty1_Click(object sender, EventArgs e)
        {
            Process.Start("statystyki.txt");
            ukrycieOpcji();
        }

        private void btnStaty2_Click(object sender, EventArgs e)
        {
            string sciezka = "statystyki.txt";
            string naglowek = "Tryb\tPunkty\tCzas gry\tKliknięcia\tObiekty\tData i godzina\n";
            File.WriteAllText(sciezka, naglowek);
            ukrycieOpcji();
        }
        #endregion

        #region Przycisk przerwij
        private void btnPrzerwij_Click(object sender, EventArgs e)
        {
            koniecGry();
            ukrycieOpcji();
        }
        #endregion

        #region Zmienne globalne
        Random rand = new Random();
        List<PictureBox> obiekty = new List<PictureBox>();
        int punkty;
        int czasSek = 120;
        int sekundy = 0;
        int minuty = 2;
        int tryb = 0;
        int tryb2Kolor;
        double combo;
        int klikIlosc;
        double klikTrafione;
        int obiektyIlosc;
        double obiektyTrafione;
        #endregion

        #region Działanie trybów
        private async Task MakePictureBoxAsync()
        {
            PictureBox newPic = new PictureBox();
            //rozmiary obiektu
            newPic.Height = 50 - poziomTrudnosci();
            newPic.Width = 50 - poziomTrudnosci();
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

        private async Task tryb2()
        {
            PictureBox newPic = new PictureBox();
            //rozmiary obiektu
            newPic.Height = 50 - poziomTrudnosci();
            newPic.Width = 50 - poziomTrudnosci();
            newPic.BackColor = wyborKoloru();
            //lokalizacja obiektu - wyeliminowanie sytuacji w której część obiektu wystaje poza okno gry
            int x = rand.Next(newPic.Width + 10, panelGame.Width - newPic.Width - 10);
            int y = rand.Next(newPic.Height + 10, panelGame.Height - newPic.Height - 10);
            newPic.Location = new Point(x, y);
            obiekty.Add(newPic);
            this.Controls.Add(newPic);
            panelGame.Controls.Add(newPic);
            if (newPic.BackColor == sprawdzenieKoloru(tryb2Kolor))
            {
                obiektyIlosc++;
            }
            newPic.Click += tryb2_Click;
            //usunięcie obiektu po 2.5 sekundy 
            await Task.Delay(2500);
            obiekty.Remove(newPic);
            panelGame.Controls.Remove(newPic);
            newPic.Dispose();
            lblUpdate(0);
        }

        private async Task tryb3()
        {
            PictureBox newPic = new PictureBox();
            //rozmiary obiektu
            newPic.Height = 50 - poziomTrudnosci();
            newPic.Width = 50 - poziomTrudnosci();
            newPic.BackColor = wyborKoloru();
            lblOpis.Visible = true;
            //lokalizacja obiektu - wyeliminowanie sytuacji w której część obiektu wystaje poza okno gry
            int x = rand.Next(newPic.Width + 10, panelGame.Width - newPic.Width - 10);
            int y = rand.Next(newPic.Height + 10, panelGame.Height - newPic.Height - 10);
            newPic.Location = new Point(x, y);
            obiekty.Add(newPic);
            this.Controls.Add(newPic);
            panelGame.Controls.Add(newPic);
            if (newPic.BackColor == sprawdzenieKoloru(tryb2Kolor))
            {
                obiektyIlosc++;
            }
            newPic.Click += tryb2_Click;
            //usunięcie obiektu po 1 sekundzie
            await Task.Delay(1000);
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
            mnoznikPunktow(1);
            punktyPlus();
            lblUpdate(0);
        }

        private void tryb2_Click(object sender, EventArgs e)
        {
            PictureBox temPic = sender as PictureBox;
            if (temPic.BackColor == sprawdzenieKoloru(tryb2Kolor))
            {
                klikTrafione++;
                obiektyTrafione++;
                mnoznikPunktow(1);
                punktyPlus();
            }
            else
            {
                punktyMinus();
                mnoznikPunktow(0);
            }
            obiekty.Remove(temPic);
            this.Controls.Remove(temPic);
            panelGame.Controls.Remove(temPic);
            temPic.Dispose();
            odtworzDzwiek();
            klikIlosc++;
            lblUpdate(0);
        }
        #endregion

        #region Funkcje timera
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
                if (tryb == 1)
                {
                    MakePictureBoxAsync();
                }
                else if (tryb == 2)
                {
                    tryb2();
                    tryb2();
                }
                else if (tryb == 3)
                {
                    tryb2Cel(3);
                    tryb3();
                }
            }
            lblUpdate(1);
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

        private void przygotowanie()
        {
            lblOpis.Location = new Point(298, 243);
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
            combo = 0.9;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            czasSek = 120;
            gameTimer.Start();
            lblReset();
            btnStart.Visible = false;
            lblOpis.Visible = false;
            if (tryb == 3)
            {
                lblOpis.Location = new Point(450, 5);
            }
        }
        #endregion

        #region Funkcje kolorów
        private Color wyborKoloru()
        {
            int k = rand.Next(1, 7);
            if (k == 1)
            {
                return Color.Crimson;
            }
            else if (k == 2)
            {
                return Color.Lime;
            }
            else if (k == 3)
            {
                return Color.Blue;
            }
            else if (k == 4)
            {
                return Color.Yellow;
            }
            else if (k == 5)
            {
                return Color.Purple;
            }
            else if (k == 6)
            {
                return Color.DeepPink;
            }
            else
            {
                return Color.Crimson;
            }
        }

        private Color sprawdzenieKoloru(int kol)
        {
            if (kol == 1)
            {
                return Color.Crimson;
            }
            else if (kol == 2)
            {
                return Color.Lime;
            }
            else if (kol == 3)
            {
                return Color.Blue;
            }
            else if (kol == 4)
            {
                return Color.Yellow;
            }
            else if (kol == 5)
            {
                return Color.Purple;
            }
            else if (kol == 6)
            {
                return Color.DeepPink;
            }
            else
            {
                return Color.Crimson;
            }
        }

        private void tryb2Cel(int t)
        {
            tryb2Kolor = rand.Next(1, 7);
            if (t == 2)
            {
                if (tryb2Kolor == 1)
                {
                    lblOpis.Text = "Klikaj tylko w obiekty o kolorze czerwonym aby zdobyć punkty\n\n\n\nKliknij aby rozpocząć";
                }
                else if (tryb2Kolor == 2)
                {
                    lblOpis.Text = "Klikaj tylko w obiekty o kolorze zielonym aby zdobyć punkty\n\n\n\nKliknij aby rozpocząć";
                }
                else if (tryb2Kolor == 3)
                {
                    lblOpis.Text = "Klikaj tylko w obiekty o kolorze niebieskim aby zdobyć punkty\n\n\n\nKliknij aby rozpocząć";
                }
                else if (tryb2Kolor == 4)
                {
                    lblOpis.Text = "Klikaj tylko w obiekty o kolorze żółtym aby zdobyć punkty\n\n\n\nKliknij aby rozpocząć";
                }
                else if (tryb2Kolor == 5)
                {
                    lblOpis.Text = "Klikaj tylko w obiekty o kolorze fioletowym aby zdobyć punkty\n\n\n\nKliknij aby rozpocząć";
                }
                else if (tryb2Kolor == 6)
                {
                    lblOpis.Text = "Klikaj tylko w obiekty o kolorze różowym aby zdobyć punkty\n\n\n\nKliknij aby rozpocząć";
                }
            }
            else if (t == 3)
            {
                if (tryb2Kolor == 1)
                {
                    lblOpis.Text = "czerwony";
                }
                else if (tryb2Kolor == 2)
                {
                    lblOpis.Text = "zielony";
                }
                else if (tryb2Kolor == 3)
                {
                    lblOpis.Text = "niebieski";
                }
                else if (tryb2Kolor == 4)
                {
                    lblOpis.Text = "żółty";
                }
                else if (tryb2Kolor == 5)
                {
                    lblOpis.Text = "fioletowy";
                }
                else if (tryb2Kolor == 6)
                {
                    lblOpis.Text = "różowy";
                }
            }
        }
        #endregion

        #region Funkcje lbl
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
        #endregion

        #region Obliczanie punktów i statystyk
        private void punktyMinus()
        {
            punkty -= 15;
            if (punkty < 0)
            {
                punkty = 0;
            }
        }

        private void punktyPlus()
        {
            //bazowa liczba punktów za poprawne kliknięcie to 10
            //klikanie tylko w poprawne obiekty zwiększa otrzymywaną liczbę punktów o 1
            //za każde dobre kliknięcie aż do maksymalnie 20
            double i = 10;
            i = i * combo;
            punkty += Convert.ToInt32(i);
        }

        private double celnosc()
        {
            double accuracy = (klikTrafione / klikIlosc) * 100;
            //w przypadku dzielenia przez 0
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
            //w przypadku dzielenia przez 0
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
            //zresetowanie mnożnika punktów - brak trafienia w obiekt
            mnoznikPunktow(0);
        }

        private int poziomTrudnosci()
        {
            //funkcja adaptująca poziom trudności zależnie od wyniku gracza
            //każde 10 punktów zmniejsza rozmiar pojawiających się obiektów o 1 pixel
            //początkowy rozmiar to 50x50, minimalny to 10x10
            int modyfikator;
            modyfikator = punkty / 10;
            if (modyfikator > 40)
            {
                modyfikator = 40;
            }
            return modyfikator;
        }

        private void mnoznikPunktow(int n)
        {
            //funkcja zwiększa otrzymywane punkty za kliknięcie
            //dodatkowe 10% (czyli 1 punkt) za każde poprawne kliknięcie w serii
            //maksymalnie dodatkowe 100% (10 punktów)
            if (n == 1)
            {
                combo += 0.1;
                if (combo >= 2)
                {
                    combo = 2;
                }
            }
            if (n == 0)
            {
                combo = 0.9;
            }
        }
        #endregion

        #region Funkcje dźwięku
        private void odtworzDzwiek()
        {
            SoundPlayer odtwarzacz = new SoundPlayer(trAIM.Properties.Resources.Blop_Mark_DiAngelo_79054334);
            odtwarzacz.Play();
        }
        #endregion

        #region Zbieranie danych
        public static class dane
        {
            //klasa używana do przekazania danych do podsumowania
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
        #endregion
    }
}