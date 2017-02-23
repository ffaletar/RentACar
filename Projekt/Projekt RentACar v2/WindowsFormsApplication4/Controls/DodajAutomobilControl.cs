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
using RentACar.DAL;

namespace WindowsFormsApplication4.Controls
{
    public partial class DodajAutomobilControl : UserControl
    {
        int id;
        public DodajAutomobilControl()
        {
            InitializeComponent();
        }
        Automobil auto = new Automobil();
      
               
        /// <summary>
        /// metoda koja omogućuje dodavanje novih automobila
        /// </summary>
        /// <param name="idAutomobila"></param>
        public void ispuniAutomobil(int idAutomobila)
        {

            id = idAutomobila;
            buttonDodajAutomobil.Visible = true;
            buttonUredi.Visible = false;

            List<MarkaAutomobilaBL> listaMarkiBL;
            listaMarkiBL = auto.DohvatiMarkeFull();

           

            comboMarka.DataSource = listaMarkiBL;
            comboMarka.ValueMember = "MarkaID";
            comboMarka.DisplayMember = "Naziv";

            if (idAutomobila != -1)
            {
                buttonDodajAutomobil.Visible = false;
                buttonUredi.Visible = true;
                labelPoruka.Visible = false;

                DataRow drAuto = auto.DohvatiAutomobilaIzID(idAutomobila);
                
                comboMarka.SelectedValue = drAuto.Field<int>(1);
                comboModel.SelectedValue = drAuto.Field<int>(2);
                comboTip.SelectedValue = drAuto.Field<int>(3);

                string pogon = drAuto.Field<string>(4);
                string motor = drAuto.Field<string>(5);

                trackBar1.Value = drAuto.Field<int>(6);
                rtbOpis.Text = drAuto.Field<string>(7);
                tbCijena.Text = drAuto.Field<int>(8).ToString();

            }

        }

        private void DodajAutomobilControl_Load(object sender, EventArgs e)
        {

        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboModel.DataSource = null;
            if (comboTip.Items.Count > 0)
            {
                comboTip.SelectedIndex = 0;
            }
            
            if ((int)comboMarka.SelectedIndex !=0)
            {
                int x = (int)comboMarka.SelectedValue;
                Automobil auto = new Automobil();
                if (x != -1)
                {
                    List<ModelAutomobilaBL> listaModela = new List<ModelAutomobilaBL>();
                    listaModela = auto.DohvatiModelFull(x);
                   

                    comboModel.DataSource = listaModela;
                    comboModel.ValueMember = "modelID";
                    comboModel.DisplayMember = "Naziv";
                }
                

            }
        }

        private void comboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)comboModel.SelectedIndex != 0 && comboModel.SelectedItem != null)
            {
                int y = (int)comboModel.SelectedValue;
                Automobil auto = new Automobil();
                
                if (y != -1)
                {
                    List<TipAutomobilaBL> lista = new List<TipAutomobilaBL>();
                    lista = auto.DohvatiTip(y);
                   

                    comboTip.DataSource = lista;
                    comboTip.ValueMember = "TipID";
                    comboTip.DisplayMember = "Tip";
                }
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            labelSnaga.Text = trackBar1.Value.ToString();
        }

        private void buttonDodajAutomobil_Click(object sender, EventArgs e)
        {
            if (comboMarka.SelectedIndex != 0 && comboModel.SelectedIndex != 0 && comboTip.SelectedIndex != 0 && tbCijena.Text != "" && labelSnaga.Text != "")
            {

                Automobil auto = new Automobil();
                auto.UpisiNoviAutomobil(Convert.ToInt32(label4.Text), Convert.ToInt32(labelSnaga.Text), rtbOpis.Text, Convert.ToInt32(tbCijena.Text));


                MessageBox.Show("Uspješno ste dodali novi automobil!");

                comboMarka.SelectedIndex = 0;
                comboModel.SelectedIndex = -1;
                comboTip.SelectedIndex = 0;
                tbCijena.Text = "";
                trackBar1.Value = 0;
                rtbOpis.Text = "";
            }
            
        }

        private void buttonUredi_Click(object sender, EventArgs e)
        {
            if (comboMarka.SelectedIndex != 0 && comboModel.SelectedIndex != 0 && comboTip.SelectedIndex != 0 && tbCijena.Text != "" && labelSnaga.Text != ""){
                Automobil auto = new Automobil(id, Convert.ToInt32(label4.Text), Convert.ToInt32(labelSnaga.Text), rtbOpis.Text, Convert.ToInt32(tbCijena.Text));
                auto.urediAutomobil();

                MessageBox.Show("Uspješno ste uredili automobil!");

                comboMarka.SelectedIndex = 0;
                comboModel.SelectedIndex = -1;
                comboTip.SelectedIndex = 0;
                tbCijena.Text = "";
                trackBar1.Value = 0;
                rtbOpis.Text = "";

                buttonUredi.Visible = false;
                buttonDodajAutomobil.Visible = true;
            }

        }
        
        private void comboTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            Automobil auto = new Automobil();
            if (comboModel.SelectedIndex != 0 && comboTip.SelectedIndex != 0)
            {
                int modelTipID = auto.DohvatiModelTipID((int)comboModel.SelectedValue, (int)comboTip.SelectedValue);
                label4.Text = modelTipID.ToString();
            }
            else
            {
                label4.Text = "-1";
            }
            
        }

        private void label4_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label4.Text) == -1)
            {
                label5.Visible = false;
                label6.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
            }
            else
            {
                label5.Visible = true;
                label6.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                Automobil auto = new Automobil();

                int pogonMotor = Convert.ToInt32(label4.Text);
                DataTable dr = auto.DohvatiPogonMotor(pogonMotor);

                label5.Text = dr.Rows[0].Field<string>(0);
                label6.Text = dr.Rows[0].Field<string>(1);
            }
          
        }
    }
}
