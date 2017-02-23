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
    public partial class StartPageControl : UserControl
    {
        public event EventHandler PrijavaClick;
        public event EventHandler RegistracijaClick;
        public StartPageControl()
        {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            RegistracijaClick(this, EventArgs.Empty);
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            PrijavaClick(this, EventArgs.Empty);
        }
    }
}
