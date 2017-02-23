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
    public partial class MojeRezervacijeControl : UserControl
    {
        public MojeRezervacijeControl()
        {
            InitializeComponent();
        }
        int userID;
        /// <summary>
        /// Metoda koja prikazuje podatke o rezervaciji 
        /// </summary>
        /// <param name="id"></param>
        public void IspuniMojeRezervacijeControl(int id)
        {
            userID = id;
            groupBox8.Visible = true;

            Rezervacija rezervacija = new Rezervacija();
            DataTable dtRezervacije = rezervacija.DohvatiMojeRezervacije(id);

            dtRezervacije.Columns[0].ColumnName = "ID rezervacije";
            dtRezervacije.Columns[1].ColumnName = "Datum rezervacije";
            dtRezervacije.Columns[2].ColumnName = "Početak posudbe";
            dtRezervacije.Columns[3].ColumnName = "Kraj posudbe";
            dtRezervacije.Columns[4].ColumnName = "Marka automobila";
            dtRezervacije.Columns[5].ColumnName = "Model automobila";
            dtRezervacije.Columns[6].ColumnName = "Tip automobila";
            dtRezervacije.Columns[7].ColumnName = "Status rezervacije";
            mojeRezervacijeGrid.DataSource = dtRezervacije;

            mojeRezervacijeGrid.Columns[0].Visible = false;
            mojeRezervacijeGrid.Columns[7].Visible = false;

            foreach (DataGridViewRow red in mojeRezervacijeGrid.Rows)
            {            
                if (red.Cells[7].Value.ToString() != "aktivna")
                {
                    
                    red.DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    red.DefaultCellStyle.BackColor = Color.White;
                }
            }
            mojeRezervacijeGrid.Update();

            if (mojeRezervacijeGrid.RowCount == 0)
            {
                groupBox8.Visible = false;
            }

        }

        private void mojeRezervacijeGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (mojeRezervacijeGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow1 = mojeRezervacijeGrid.SelectedRows[0];
                int idMojeRezervacije = Convert.ToInt32(selectedRow1.Cells[0].Value);

                label80.Text = selectedRow1.Cells[4].Value.ToString() + "  " +selectedRow1.Cells[5].Value.ToString() + "  " + selectedRow1.Cells[6].Value.ToString();
                DateTime datumRez = (DateTime)selectedRow1.Cells[1].Value;
                DateTime pocetPos = (DateTime)selectedRow1.Cells[2].Value;
                DateTime krajPos = (DateTime)selectedRow1.Cells[3].Value;
                label79.Text = datumRez.ToShortDateString();
                label81.Text = pocetPos.ToShortDateString();
                label82.Text = krajPos.ToShortDateString();
                label84.Text = selectedRow1.Cells[7].Value.ToString();

            }                     
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = mojeRezervacijeGrid.SelectedRows[0];
            int idMojeRezervacije = Convert.ToInt32(selectedRow.Cells[0].Value);

            Rezervacija rez = new Rezervacija();
            rez.DeaktivirajOdabranuRezervaciju(idMojeRezervacije);



            groupBox8.Visible = true;

            Rezervacija rezervacija = new Rezervacija();
            DataTable dtRezervacije = rezervacija.DohvatiMojeRezervacije(userID);

            dtRezervacije.Columns[0].ColumnName = "ID rezervacije";
            dtRezervacije.Columns[1].ColumnName = "Datum rezervacije";
            dtRezervacije.Columns[2].ColumnName = "Početak posudbe";
            dtRezervacije.Columns[3].ColumnName = "Kraj posudbe";
            dtRezervacije.Columns[4].ColumnName = "Marka automobila";
            dtRezervacije.Columns[5].ColumnName = "Model automobila";
            dtRezervacije.Columns[6].ColumnName = "Tip automobila";
            dtRezervacije.Columns[7].ColumnName = "Status rezervacije";
            mojeRezervacijeGrid.DataSource = dtRezervacije;

            mojeRezervacijeGrid.Columns[0].Visible = false;
            mojeRezervacijeGrid.Columns[7].Visible = false;


            if (mojeRezervacijeGrid.RowCount == 0)
            {
                groupBox8.Visible = false;
            }
        }
    }
}
