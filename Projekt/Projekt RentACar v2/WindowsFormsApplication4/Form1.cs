using RentACar.BL.EventArguments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentACar.BL.EventArguments;




namespace WindowsFormsApplication4
{
    
    public partial class Form1 : Form
    {
        public string odabraniTab;
        public int idAutomobila;
      
        DB baza = new DB();

        public string odabir = "dodaj";
        public int urediAutomobilID;
        public Form1()
        {
            InitializeComponent();
            loginControl1.KorisnikPrijavljen += loginControl1_KorisnikPrijavljen;
            registerControl1.KorisnikRegistriran += registerControl1_KorisnikRegistriran;
            startPageControl1.PrijavaClick += startPageControl1_PrijavaClick;
            startPageControl1.RegistracijaClick += startPageControl1_RegistracijaClick;
            homePageControl1.ButtonAutomobiliClick += homePageControl1_ButtonAutomobiliClick;
            homePageControl1.ButtonRezervacijeClick += homePageControl1_ButtonRezervacijeClick;
            homePageControl1.ButtonKorisniciClick += homePageControl1_ButtonKorisniciClick;
            automobiliControl1.ButtonPregledajClick += automobiliControl1_ButtonPregledajClick;
            automobiliControl1.DodajAutomobilClick += automobiliControl1_DodajAutomobilClick;
            rezervacijeControl1.MojeRezervacijeClick += rezervacijeControl1_MojeRezervacijeClick;
            rezervacijeControl1.PopisRezervacijaClick += rezervacijeControl1_PopisRezervacijaClick;
            rezervacijeControl1.NovaRezervacijaClick += rezervacijeControl1_NovaRezervacijaClick;
            novaRezervacija1.PotvrdaRezervacijeClick += novaRezervacija1_PotvrdaRezervacijeClick;
            automobiliControl1.UrediAutomobilClick += automobiliControl1_UrediAutomobilClick;
            popisRezervacija1.RacunClick += popisRezervacija1_RacunClick;
            
            
        }

        private void popisRezervacija1_RacunClick(object sender, RacunEventArguments e)
        {
            racun1.DohvatiIDRezervacije(e.rezervacijaID);
            racun1.PopuniRacun();
            tabControl1.SelectTab(Racun);
        }

        private void automobiliControl1_UrediAutomobilClick(object sender, RentACar.BL.EventArguments.DodajAutomobilEventArgs e)
        {
            dodajAutomobilControl1.ispuniAutomobil(e.automobilID);

            tabControl1.SelectTab(DodajAutomobil1);
        }

        private void novaRezervacija1_PotvrdaRezervacijeClick(object sender, PotvrdaRezervacijeEventArgs e)
        {
            potvrdaRezervacijeControl1.IspuniPotvrdu(e.datumRezervacije, e.pocetakPosudbe, e.krajPosudbe, e.korisnikNadimak, e.marka, e.model, e.tip, e.cijena);

            tabControl1.SelectTab(PotvrdaRezervacije);               
        }

        private void rezervacijeControl1_NovaRezervacijaClick(object sender, EventArgs e)
        {
            //btnNovaRezervacija_Click(this, new NovaRezervacijaEventArgs() { korisnikID = userID });
            novaRezervacija1.PopuniUserID(userID, userType);
            novaRezervacija1.PopuniComboMarka();
            tabControl1.SelectTab(novaRezervacija);
        }


        private void rezervacijeControl1_PopisRezervacijaClick(object sender, EventArgs e)
        {
            popisRezervacija1.PopuniComboKorisnici();
            tabControl1.SelectTab(PopisRezervacija);
        }

        private void rezervacijeControl1_MojeRezervacijeClick(object sender, EventArgs e)
        {
            mojeRezervacije1.IspuniMojeRezervacijeControl(userID);

            tabControl1.SelectTab(MojeRezervacije);
        }

        private void automobiliControl1_DodajAutomobilClick(object sender, DodajAutomobilEventArgs e)
        {
            dodajAutomobilControl1.ispuniAutomobil(-1);

            tabControl1.SelectTab(DodajAutomobil1);
        }        

        private void automobiliControl1_ButtonPregledajClick(object sender, AutomobilEventArgs e)
        {

            pregledajAutomobilControl1.IspuniAutomobilControl(e.AutomobilId);

            tabControl1.SelectTab(pregledajAutomobil);               
        }

        private void homePageControl1_ButtonKorisniciClick(object sender, EventArgs e)
        {
            korisniciControl1.PopuniKorisnici();
            tabControl1.SelectTab(Korisnici);
        }

        private void homePageControl1_ButtonRezervacijeClick(object sender, EventArgs e)
        {
            rezervacijeControl1.PostaviVidljivost(userType);
            tabControl1.SelectTab(Rezervacije);
        }

        private void homePageControl1_ButtonAutomobiliClick(object sender, EventArgs e)
        {
            
            automobiliControl1.PrimiUserType(userType);
            automobiliControl1.PopuniGridAutomobili();
            automobiliControl1.PostaviVidljivost();
            tabControl1.SelectTab(Automobili);
        }

        private void startPageControl1_RegistracijaClick(object sender, EventArgs e)
        {
            tabControl1.SelectTab(Registracija);
        }

        private void startPageControl1_PrijavaClick(object sender, EventArgs e)
        {
            tabControl1.SelectTab(Prijava);
        }

        private void registerControl1_KorisnikRegistriran(object sender, EventArgs e)
        {
            tabControl1.SelectTab(StartPage);
        }

        void loginControl1_KorisnikPrijavljen(object sender, EventArgs e)
        {            
            userID = loginControl1.UserId;
            userType = loginControl1.UserType;
            homePageControl1.PostaviVidljivost(userType);
            tabControl1.SelectTab(Homepage);
        }
       
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(Prijava);
        }
        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(Registracija);
        }
        private void Odjava_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(StartPage);
            //tbLozinka.Text = "";
            //tbNadimak.Text = "";           
        }

        public int automobilIDPregled = 0;
        public bool popunjenostRegistracije;
        //public int vracenaPopunjenost = 0;
        //public int popunjenost = 0;
        public int markaID, tipID, cijenaID;
        public int aCijena = 0, bCijena = 0;
        public int userType = 1;
        public int userID = 0;
        public int aaa = 0;


        //pritiskom na tipku Automobili otvara se tab Automobili u kojem ce biti dostupan pregled automobila
        //u comboBoxu Marka se dohvacaju sve marke automobila iz baze koje imamo u garaži
        private void btnAutomobili_Click(object sender, EventArgs e)
        {
            
        }



        public int pomoc = 0;

        private void btnDodajAutomobil_Click(object sender, EventArgs e)
        {

            
        }

        private void buttonDodajAutomobil_Click(object sender, EventArgs e)
        {
            int id;
            
           
        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboModel_SelectedIndexChanged(object sender, EventArgs e)
        {        
                
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            labelSnaga.Text = Convert.ToString(trackBar1.Value); //u labelu se zapisuje vrijednost trackBara
        }

        private void buttonVratiSe_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(Automobili); //tipka za vracanje na prethodni tab
        }

        private void buttonVrati_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(Homepage);
        }

        private void Odjava_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(StartPage); //odjava iz aplikacije, vracanje na StartPage
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            promjeniVisibility();            
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //prilikom pritiska na gumb "Prethodno" brišu se svi textboxovi iz trenutnog taba
            if (tabControl1.SelectedTab == Registracija || tabControl1.SelectedTab == Prijava)
            {
                Control trenutnaKontrola = tabControl1.SelectedTab.Controls.OfType<UserControl>().First<UserControl>();
                foreach (TextBox t in trenutnaKontrola.Controls.OfType<TextBox>())
                {
                    t.Text = "";
                }
            }
            

            string otvoreniTab = odabraniTab;
            switch (otvoreniTab) {
                case "Prijava": {
                    tabControl1.SelectTab(StartPage);
                    break;
                    }
                case "Registracija": {
                    tabControl1.SelectTab(StartPage);
                    break;                    
                }
                case "Homepage": {
                    tabControl1.SelectTab(StartPage);
                    break;       
                }
                case "Automobili":
                    {
                        tabControl1.SelectTab(Homepage);
                        break;
                    }
                case "Rezervacija":
                    {
                        tabControl1.SelectTab(Homepage);
                        break;
                    }
                case "Fotografije":
                    {
                        tabControl1.SelectTab(Homepage);
                        break;
                    }
                case "Korisnici":
                    {
                        tabControl1.SelectTab(Homepage);
                        break;
                    }
                case "dodajAutomobil":
                    {
                        tabControl1.SelectTab(Automobili);
                        break;
                    }
                case "Usporedba":
                    {
                        tabControl1.SelectTab(pregledajAutomobil);
                        break;
                    }
                case "pregledajAutomobil": 
                    {
                        tabControl1.SelectTab(Automobili);
                        break;       
                    }
                case "Rezervacije":
                    {
                        tabControl1.SelectTab(Homepage);
                        break;
                    }
                case "novaRezervacija":
                    {
                        tabControl1.SelectTab(Rezervacije);
                        break;
                    }
                case "PopisRezervacija":
                    {
                        tabControl1.SelectTab(Rezervacije);
                        break;
                    }
                case "MojeRezervacije":
                    {
                        tabControl1.SelectTab(Rezervacije);
                        break;
                    }
                case "PotvrdaRezervacije":
                    {
                        tabControl1.SelectTab(novaRezervacija);
                        break;
                    }
                case "DodajAutomobil1":
                    {
                        tabControl1.SelectTab(Automobili);
                        break;
                    }
                case "Racun":
                    {
                        tabControl1.SelectTab(Rezervacije);
                        break;
                    }
            }
        }     
        

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            odabraniTab = tabControl1.SelectedTab.AccessibleName.ToString();
            promjeniVisibility(); //kada korisnik promjeni tab u tabControli poziva se funkcija promjeniVisibility koja mijenja visibility navigacijskih
            //zato što ikona "Prethodno" mora biti dostupna na svim tabovima osim na StartPage-u, ikona "Home" i ikonica "Odjava" moraju biti dostupne kada je korisnik prijavljen
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Homepage;
        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = StartPage;
        }
             
        
        public void promjeniVisibility()
        {
            if (tabControl1.SelectedTab == StartPage)
            {
                label22.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
            }
            else if (tabControl1.SelectedTab == Prijava || tabControl1.SelectedTab == Registracija)
            {
                label22.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else
            {

                label22.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                if (tabControl1.SelectedTab == Homepage)
                {
                    pictureBox4.Visible = false;
                }
            }
        }


        

        private void btnSvi_Click(object sender, EventArgs e)
        {
            
        }


        private void btnRegistracija_MouseLeave(object sender, EventArgs e) 
        {
        }


        public string tb { get; set; }

        private void btnUrediAutomobil_Click(object sender, EventArgs e)
        {
            

        }

        private void btnObrisiAutomobil_Click(object sender, EventArgs e)
        {            
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {            

        }

        

        private void KorisniciGrid_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBrisiKorisnika_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNovaRezervacija_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPopisRezervacija_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMojeRezervacije_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Registracija_Click(object sender, EventArgs e)
        {

        }

        private void mojeRezervacijeGrid_SelectionChanged(object sender, EventArgs e)
        {
                           


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }   
        int idAutomobilaPreg;
        

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void PopisRezervacijaGrid_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }      




        private void tbNadimak_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void registerControl1_Load(object sender, EventArgs e)
        {

        }

        private void homePageControl1_Load(object sender, EventArgs e)
        {

        }

        private void rezervacijeControl1_Load(object sender, EventArgs e)
        {

        }

        private void automobiliControl1_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void StartPage_Click(object sender, EventArgs e)
        {

        }
    }

    //pomoću ove klase uklanjamo headere svakog taba u tabControli kako bi korisnicko sucelje bilo jednostavnije za koristenje
    //klasa myTabControl nasljedjuje TabControl 

    //i unutar pozadinskog koda, tj koda koji se sam generira u funkciji InitializeComponent() postavljeno je da
    //se pri inicijalizaciji Forme ne otvara klasa TabControl nego uređena klasa pod nazivom myTabControl

    //na taj nacin sam dobio ovaj izgled aplikacije bez ikakvih tabova i izbornika na vrhu (nesto kao mobilna aplikacija) 
   
    //rješenje je pronađeno na internetu

    class myTabControl : TabControl {
        protected override void WndProc(ref Message m)
        {
            if(m.Msg == 0x1328 && !DesignMode){
                m.Result = (IntPtr)1;
            }else base.WndProc(ref m);
        }    
    }

    

    
}
