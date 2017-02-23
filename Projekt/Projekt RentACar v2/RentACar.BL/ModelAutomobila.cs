using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    public class ModelAutomobila
    {
        private int id;
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
