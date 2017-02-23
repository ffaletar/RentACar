using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentACar.BL;
using RentACar.BL.EventArguments;

namespace WindowsFormsApplication4.Controls
{
    public partial class RezervacijeControl : UserControl
    {
        int userID;
        public event EventHandler MojeRezervacijeClick;
        public event EventHandler PopisRezervacijaClick;
        public event EventHandler NovaRezervacijaClick;
        public RezervacijeControl()
        {
            InitializeComponent();
        }

        private void btnMojeRezervacije_Click(object sender, EventArgs e)
        {
            MojeRezervacijeClick(this, EventArgs.Empty);
        }

        private void btnPopisRezervacija_Click(object sender, EventArgs e)
        {
            PopisRezervacijaClick(this, EventArgs.Empty);
        }
        

        private void RezervacijeControl_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// metoda koja postavlja (ne)vidljivost popisa rezervacija ovisno o tipu korisnika
        /// </summary>
        /// <param name="userType"></param>
        public void PostaviVidljivost(int userType)
        {
            if (userType == 1)
            {
                btnPopisRezervacija.Visible = true;
            }
            else
            {
                btnPopisRezervacija.Visible = false;
            }
        }

        private void btnNovaRezervacija_Click(object sender, EventArgs e)
        {
            
            NovaRezervacijaClick(this, EventArgs.Empty);
        }

    }
}
