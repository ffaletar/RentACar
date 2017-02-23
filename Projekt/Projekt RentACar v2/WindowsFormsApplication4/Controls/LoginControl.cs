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

namespace WindowsFormsApplication4.Controls
{
    public partial class LoginControl : UserControl
    {

        private int userId;
        private int userType;

        public event EventHandler KorisnikPrijavljen;
       

        public LoginControl()
        {
            InitializeComponent();
            tbLoz.PasswordChar = '*';
            tbLoz.MaxLength = 14;
        }


        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = new Korisnik();
            
            DataTable dtKorisnikLogin = korisnik.DohvatiKorisnika(tbNadimak.Text);

            int korisnikID = dtKorisnikLogin.Rows[0].Field<int>(2);
            int tip = dtKorisnikLogin.Rows[0].Field<int>(1);
            string lozinka = dtKorisnikLogin.Rows[0].Field<string>(0);


            if (lozinka == "")
            { //ukoliko korisnicko ime ne postoji
                MessageBox.Show("Ovo korisničko ime ne postoji. Molimo Vas da se registrirate");
                tbNadimak.Text = "";
                tbLoz.Text = "";
            }
            else if (tbLoz.Text == lozinka)
            { //ukoliko je sve ispravno
                userId = korisnikID;
                userType = tip;

                //ovo je event handler koji se pokrece kada se korisnik uspjesno prijavi
                KorisnikPrijavljen(this, EventArgs.Empty);
                tbNadimak.Text = "";
                tbLoz.Text = "";
            }
            else if (tbLoz.Text != lozinka)
            { //ukoliko lozinka nije ispravna
                MessageBox.Show("Upisali ste krivu lozinku");
                tbLoz.Text = "";
            }
            tbNadimak.Text = "";
            tbLoz.Text = "";            
        }


        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public int UserType
        {
            get { return userType; }
            set { userType = value; }
        }

        private void tbLoz_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void tbLoz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Korisnik korisnik = new Korisnik();

                DataTable dtKorisnikLogin = korisnik.DohvatiKorisnika(tbNadimak.Text);

                int korisnikID = dtKorisnikLogin.Rows[0].Field<int>(2);
                int tip = dtKorisnikLogin.Rows[0].Field<int>(1);
                string lozinka = dtKorisnikLogin.Rows[0].Field<string>(0);


                if (lozinka == "")
                { //ukoliko korisnicko ime ne postoji
                    MessageBox.Show("Ovo korisničko ime ne postoji. Molimo Vas da se registrirate");
                    tbNadimak.Text = "";
                    tbLoz.Text = "";
                }
                else if (tbLoz.Text == lozinka)
                { //ukoliko je sve ispravno
                    userId = korisnikID;
                    userType = tip;

                    //ovo je event handler koji se pokrece kada se korisnik uspjesno prijavi
                    KorisnikPrijavljen(this, EventArgs.Empty);
                    tbNadimak.Text = "";
                    tbLoz.Text = "";
                }
                else if (tbLoz.Text != lozinka)
                { //ukoliko lozinka nije ispravna
                    MessageBox.Show("Upisali ste krivu lozinku");
                    tbLoz.Text = "";
                }
                tbNadimak.Text = "";
                tbLoz.Text = "";          

            }
        }


    }
}
