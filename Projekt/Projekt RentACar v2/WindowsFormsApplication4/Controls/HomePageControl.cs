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
    public partial class HomePageControl : UserControl
    {
        public event EventHandler ButtonAutomobiliClick;
        public event EventHandler ButtonRezervacijeClick;
        public event EventHandler ButtonKorisniciClick;
        public HomePageControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda koja provjerava je li korisnik ili administrator prijavljen i 
        /// s obzirom na ishod postavlja vidljivost 
        /// </summary>
        /// <param name="userType"></param>
        public void PostaviVidljivost(int userType)
        {
            if (userType == 1)
            {
                btnKorisnici.Visible = true;
            }
            else
            {
                btnKorisnici.Visible = false;
            }
        }

        private void btnAutomobili_Click(object sender, EventArgs e)
        {           
            
            ButtonAutomobiliClick(this, EventArgs.Empty);
            
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            ButtonRezervacijeClick(this, EventArgs.Empty);
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            ButtonKorisniciClick(this, EventArgs.Empty);
        }

    }
}
