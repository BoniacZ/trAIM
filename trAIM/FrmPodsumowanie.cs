using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static trAIM.Form1;

namespace trAIM
{
    public partial class FrmPodsumowanie : Form
    {
        public FrmPodsumowanie()
        {
            InitializeComponent();
            podsumowanieStat();
        }

        private void btnZapis_Click(object sender, EventArgs e)
        {
            string sciezka = "statystyki.txt";
            string t = "\t";
            DateTime data = DateTime.Now;
            string linia = dane.gTryb + t + dane.wynik + t + dane.czas + t + dane.kTrafione + "/" + dane.kIlosc + " (" + kProcent() + "%)" + t + dane.oTrafione + "/" + dane.oIlosc + " (" + oProcent() + "%)" + t + data;
            using (StreamWriter txt = File.AppendText(sciezka))
            {
                txt.WriteLine(linia);
            }
            btnZapis.Enabled = false;
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double pktSek()
        {
            double wynik;
            wynik = dane.wynik / dane.czas;
            //zaokrąglenie do 2 miejsc po przecinku
            wynik = Math.Round(wynik, 2);
            return wynik;
        }

        private double kProcent()
        {
            double wynik = (dane.kTrafione / dane.kIlosc) * 100;
            //w przypadku dzielenia przez 0
            if (Double.IsNaN(wynik))
            {
                return 0;
            }
            //zaokrąglenie do 2 miejsc po przecinku
            wynik = Math.Round(wynik, 2);
            return wynik;
        }

        private double oProcent()
        {
            double wynik = (dane.oTrafione / dane.oIlosc) * 100;
            //w przypadku dzielenia przez 0
            if (Double.IsNaN(wynik))
            {
                return 0;
            }
            //zaokrąglenie do 2 miejsc po przecinku
            wynik = Math.Round(wynik, 2);
            return wynik;
        }

        private void podsumowanieStat()
        {
            lbl1.Text = "Wybrany tryb: " + dane.gTryb;
            lbl2.Text = "Uzyskane punkty: " + dane.wynik;
            lbl3.Text = "Punkty na sekundę: " + pktSek();
            lbl4.Text = "Trafione kliknięcia: " + dane.kTrafione + " z " + dane.kIlosc + " (" + kProcent() + "%)";
            lbl5.Text = "Trafione obiekty: " + dane.oTrafione + " z " + dane.oIlosc + " (" + oProcent() + "%)";
        }
    }
}
