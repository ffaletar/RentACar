using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RentACar.BL;
using RentACar.BL.EventArguments;

namespace WindowsFormsApplication4.Controls
{
    public partial class AutomobiliControl : UserControl
    {
        public int userType;
        public event AutomobilEventHandler ButtonPregledajClick;
        public event DodajAutomobilEventHandler DodajAutomobilClick;
        public event DodajAutomobilEventHandler UrediAutomobilClick;

        
        /// <summary>
        /// EventHandleri su definirani u BL-u kako bi se za odabrani 
        /// Automobil dohvatio ID i poslao u metodu UrediAutomobil
        /// </summary>
        
       

        public int vracenaPopunjenost = 0;
        public int popunjenost = 0;
        public int aaa = 0;
        public int aCijena = 0, bCijena = 0;

        DB baza = new DB();

        public void PrimiUserType(int type)
        {
            userType = type;
        }
        public AutomobiliControl()
        {
            InitializeComponent();
        }
        

        /// <summary>
        /// DGV se popunjava karakteristima automobila, za dohvat podataka koristi se metoda DohvatiAutomobile koja je
        /// definirana u RentACar.BL
        /// </summary>

        public void PopuniGridAutomobili()
        {
            Automobil automobil = new Automobil();
            DataTable dtAutomobili = automobil.DohvatiAutomobile();
            dtAutomobili.Columns[0].ColumnName = "AutomobilID";
            dtAutomobili.Columns[1].ColumnName = "Marka";
            dtAutomobili.Columns[2].ColumnName = "Model";
            dtAutomobili.Columns[3].ColumnName = "Tip";
            
            dtAutomobili.Columns[4].ColumnName = "Snaga";
            dtAutomobili.Columns[5].ColumnName = "Opis";
            dtAutomobili.Columns[6].ColumnName = "Cijena (kn/dan)";

            autiGrid.AutoGenerateColumns = true;
            autiGrid.DataSource = dtAutomobili;
            autiGrid.Columns[1].Width = 150;
            autiGrid.Columns[2].Width = 150;
            autiGrid.Columns[3].Width = 150;
            autiGrid.Columns[4].Width = 150;

            autiGrid.Columns[4].Visible = false;
            autiGrid.Columns[5].Visible = false;
         


            autiGrid.Sort(autiGrid.Columns[1], ListSortDirection.Ascending);


            List<string> listaMarki = new List<string>();
            List<string> listaTipova = new List<string>();
            Automobil auto = new Automobil();
            listaMarki = auto.DohvatiMarke();

            cbMarka.DataSource = listaMarki;

            autiGrid.Columns[0].Visible = false;
        }

        private void btnSvi_Click(object sender, EventArgs e)
        {
            autiGrid.Columns[0].Visible = false;
            cbMarka.SelectedIndex = 0;


            Automobil automobil = new Automobil();
            DataTable dtAutomobili = automobil.DohvatiAutomobile();
            dtAutomobili.Columns["naziv"].ColumnName = "Marka";
            dtAutomobili.Columns["automobilID"].ColumnName = "ID automobila";
            dtAutomobili.Columns["naziv1"].ColumnName = "Model";
            dtAutomobili.Columns["tip"].ColumnName = "Tip";
            dtAutomobili.Columns["cijena"].ColumnName = "Cijena";


            autiGrid.AutoGenerateColumns = true;
            autiGrid.DataSource = dtAutomobili;
            autiGrid.Columns[1].Width = 150;
            autiGrid.Columns[2].Width = 150;
            autiGrid.Columns[3].Width = 150;

            autiGrid.Columns[0].Visible = false;

            autiGrid.Sort(autiGrid.Columns[1], ListSortDirection.Ascending);
        }


        private void cbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            autiGrid.Columns[0].Visible = false;
            foreach (DataGridViewRow dgwr in autiGrid.Rows)
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[this.autiGrid.DataSource];
                cm.SuspendBinding();
                dgwr.Visible = true;
                cm.ResumeBinding();
            }
            foreach (DataGridViewRow dgr in autiGrid.Rows)
            {
                if (cbMarka.SelectedValue.ToString() == "")
                {
                    foreach (DataGridViewRow dgwr in autiGrid.Rows)
                    {
                        CurrencyManager cm = (CurrencyManager)BindingContext[this.autiGrid.DataSource];
                        cm.SuspendBinding();
                        dgwr.Visible = true;
                        cm.ResumeBinding();
                    }
                    break;
                }
                else if (dgr.Cells[1].Value.ToString() != cbMarka.SelectedValue.ToString())
                {
                    CurrencyManager cm = (CurrencyManager)BindingContext[this.autiGrid.DataSource];
                    cm.SuspendBinding();
                    dgr.Visible = false;
                    cm.ResumeBinding();
                }

            }
            autiGrid.Sort(autiGrid.Columns[1], ListSortDirection.Ascending);
        }

        private void btnObrisiAutomobil_Click(object sender, EventArgs e)
        {
            

            DataGridViewRow selectedRow = autiGrid.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells[0].Value);

            //provjerava ima li automobil trenutne rezervacije
            Rezervacija rez = new Rezervacija();
            bool imaRezervacije = rez.AutoImaRezervacije(id);

            if (imaRezervacije == true)
            {
                MessageBox.Show("Auto je rezerviran. Ne možete izbrisati rezervirani automobil.");
            }
            else
            {
                //brisanje automobila
                Automobil auto = new Automobil();
                auto.ObrisiAutomobil(id);


                //ponovno se dohvacaju automobili za grid
                Automobil automobil = new Automobil();
                DataTable dtAutomobili = automobil.DohvatiAutomobile();
                dtAutomobili.Columns["naziv"].ColumnName = "Marka";
                dtAutomobili.Columns["automobilID"].ColumnName = "ID automobila";
                dtAutomobili.Columns["naziv1"].ColumnName = "Model";
                dtAutomobili.Columns["tip"].ColumnName = "Tip";
                dtAutomobili.Columns["cijena"].ColumnName = "Cijena (kn)";



                autiGrid.AutoGenerateColumns = true;
                autiGrid.DataSource = dtAutomobili; //ovdje postavljamo datasource za auti grid, datatable dtAutomobili
                autiGrid.Columns[1].Width = 150;
                autiGrid.Columns[2].Width = 150;
                autiGrid.Columns[3].Width = 150;
                autiGrid.Columns[4].Width = 150;

                autiGrid.Sort(autiGrid.Columns[1], ListSortDirection.Ascending); //sortiranje grid-a

                autiGrid.Columns[0].Visible = false; //skrivam prvi stupac koji sadrži automobilID
            }            
        }
        public void PostaviVidljivost()
        {
            if (userType == 1)
            {
                btnDodajAutomobil.Visible = true;
                btnUrediAutomobil.Visible = true;
                btnObrisiAutomobil.Visible = true;
            }
            else
            {
                btnDodajAutomobil.Visible = false;
                btnUrediAutomobil.Visible = false;
                btnObrisiAutomobil.Visible = false;
            }
        }
        private void btnPregledaj_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = autiGrid.SelectedRows[0];
            int idAutomobila = Convert.ToInt32(selectedRow.Cells[0].Value);
            idAuto = idAutomobila;
            ButtonPregledajClick(this, new AutomobilEventArgs() { AutomobilId = idAutomobila });
        }
        public int idAuto;

     

        private void btnDodajAutomobil_Click(object sender, EventArgs e)
        {
            DodajAutomobilClick(this, new DodajAutomobilEventArgs() { automobilID = idAuto});
        }

        private void btnUrediAutomobil_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = autiGrid.SelectedRows[0];
            int idAutomobila = Convert.ToInt32(selectedRow.Cells[0].Value);
            UrediAutomobilClick(this, new DodajAutomobilEventArgs() { automobilID = idAutomobila });
        }
    }
}

