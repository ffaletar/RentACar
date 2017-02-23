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
    public partial class PregledajAutomobilControl : UserControl
    {
       public int idAutomobila;
        public PregledajAutomobilControl()
        {
            InitializeComponent();
        }
        
        public void IspuniAutomobilControl(int id)
        {
            idAutomobila = id;


            Automobil auto = new Automobil();
            DataRow rowAutoDAL = auto.DohvatiAutomobilPremaID(idAutomobila);

            labelIDautomobila.Text = rowAutoDAL.Field<int>("automobilID").ToString();
            PregSnaga.Text = rowAutoDAL.Field<int>("snaga").ToString();
            PregPogon.Text = rowAutoDAL.Field<string>("pogon");
            PregMotor.Text = rowAutoDAL.Field<string>("motor");
            PregMarka.Text = rowAutoDAL.Field<string>("marka");
            PregModel.Text = rowAutoDAL.Field<string>("tip");
            PregTip.Text= rowAutoDAL.Field<string>("model");


            richTextBox1.Text = rowAutoDAL.Field<string>("opis");
            labelCijena.Text = rowAutoDAL.Field<int>("cijena").ToString();



            DateTime pocetakPosudbe;
            DateTime krajPosudbe;

            monthCalendar2.BoldedDates = null;


            foreach(DataRow dr in auto.DohvatiDatume(idAutomobila).Rows){
                pocetakPosudbe = dr.Field<DateTime>(0);
                krajPosudbe = dr.Field<DateTime>(1);

                int pocetak = Convert.ToInt32(pocetakPosudbe.DayOfYear);
                int kraj = Convert.ToInt32(krajPosudbe.DayOfYear);

                List<int> listaDay = new List<int>();

                for (int i = pocetak; i <= kraj; i++)
                {
                    listaDay.Add(i);
                }

                List<DateTime> listaDana = new List<DateTime>();

                foreach (int objekt in listaDay)
                {
                    DateTime datum = new DateTime(pocetakPosudbe.Year, 1, 1).AddDays(objekt - 1);
                    listaDana.Add(datum);
                }

                foreach (var element in listaDana)
                {
                    monthCalendar2.AddBoldedDate(element);
                }
            }          

            monthCalendar2.Update();
            monthCalendar2.UpdateBoldedDates();

        }

        private void PregledajAutomobilControl_Load(object sender, EventArgs e)
        {

        }
    }
}
