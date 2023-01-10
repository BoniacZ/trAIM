using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            lbl1.Text = "Punkty: ";
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double pktSek()
        {
            double wynik;
            wynik = dane.wynik / dane.czas;
            wynik = Math.Round(wynik, 2);
            return wynik;
        }

        private double kProcent()
        {
            double wynik = (dane.kTrafione / dane.kIlosc) * 100;
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
