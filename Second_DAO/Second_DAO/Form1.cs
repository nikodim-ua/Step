using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_DAO
{
    public partial class Form1 : Form
    {
        CountryDAO countryDAO = new CountryDAO(@"Data Source=|DataDirectory|\Database1.sdf");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var c = new Country();
            c.Name = "Ukrain";
            countryDAO.Insert(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cl = new List<Country>();
            cl = countryDAO.Select();
            for (int i = 0; i < cl.Count; i++)
            {
                listBox1.Items.Add(cl[i].Name);
            }
        }
    }
}
