using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linqEx1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCounties_Click(object sender, EventArgs e)
        {
            string[] counties = new[]
            {
              "Antrim",
              "Armagh",
              "Carlow",
              "Cavan",
              "Clare",
              "Cork",
              "Derry",
              "Donegal",
              "Down",
              "Dublin",
              "Fermanagh",
              "Galway",
              "Kerry",
              "Kildare",
              "Kilkenny",
              "Laois",
              "Leitrim",
              "Limerick",
              "Longford",
              "Louth",
              "Mayo",
              "Meath",
              "Monaghan",
              "Offaly",
              "Roscommon",
              "Sligo",
              "Tipperary",
              "Tyrone",
              "Waterford",
              "Westmeath",
              "Wexford",
              "Wicklow"
            };


            var result =
                from c in counties
                where c.StartsWith("L") || c.StartsWith("W")
                select c;

            foreach(string s in result)
            {
                lstCounties.Items.Add(s);
            }
            
        }
    }
}
