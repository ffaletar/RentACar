using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4.Controls
{
    public partial class NavigacijaControl : UserControl
    {
        string otvTab;
        public NavigacijaControl()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        //    string otvoreniTab = ();
        //    switch (otvoreniTab) {
        //        case "Prijava": {
        //            tabControl1.SelectTab(StartPage);
        //            break;
        //            }
        //        case "Registracija": {
        //            tabControl1.SelectTab(StartPage);
        //            break;                    
        //        }
        //        case "Homepage": {
        //            tabControl1.SelectTab(StartPage);
        //            break;       
        //        }
        //        case "Automobili":
        //            {
        //                tabControl1.SelectTab(Homepage);
        //                break;
        //            }
        //        case "Rezervacija":
        //            {
        //                tabControl1.SelectTab(Homepage);
        //                break;
        //            }
        //        case "Fotografije":
        //            {
        //                tabControl1.SelectTab(Homepage);
        //                break;
        //            }
        //        case "Korisnici":
        //            {
        //                tabControl1.SelectTab(Homepage);
        //                break;
        //            }
        //        case "dodajAutomobil":
        //            {
        //                tabControl1.SelectTab(Automobili);
        //                break;
        //            }
        //        case "Usporedba":
        //            {
        //                tabControl1.SelectTab(pregledajAutomobil);
        //                break;
        //            }
        //        case "pregledajAutomobil": 
        //            {
        //                tabControl1.SelectTab(Automobili);
        //                break;       
        //            }
        //        case "Rezervacije":
        //            {
        //                tabControl1.SelectTab(Homepage);
        //                break;
        //            }
        //        case "novaRezervacija":
        //            {
        //                tabControl1.SelectTab(Rezervacije);
        //                break;
        //            }
        //        case "PopisRezervacija":
        //            {
        //                tabControl1.SelectTab(Rezervacije);
        //                break;
        //            }
        //        case "MojeRezervacije":
        //            {
        //                tabControl1.SelectTab(Rezervacije);
        //                break;
        //            }
        //        case "PotvrdaRezervacije":
        //            {
        //                tabControl1.SelectTab(novaRezervacija);
        //                break;
        //            }
        //    }
        //    //tbLozinka.Text = "";
        //    //tbNadimak.Text = "";
        }
        public void OtvoreniTab(string otvoreniTab)
        {

            otvTab = otvoreniTab;
        }
    }
}
