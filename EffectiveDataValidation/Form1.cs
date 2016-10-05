using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EffectiveDataValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //matching words
            //string s1 = "sample";
            //string s2 = "sample";

            //mismatching words
            //string s1 = "water";
            //string s2 = "sand";

            //mis-matching doubles
              //string s1 = "124.594";
              //string s2 = "124.954";

            //matching doubles with trailing zeros

            string s1 = "124.595";
            string s2 = "124.594000";

            double d1 = 0.0;
            double d2 = 0.0;

            var pass = new List<string>();

            var fail = new List<string>();

            if (double.TryParse(s1, out d1) && double.TryParse(s2, out d2))
            {
                if(Math.Abs(d1 - d2) <= 0.1)
                {
                    pass.Add(String.Join(" , ", s1, s2));
                }
                else
                {
                    fail.Add(String.Join(" , ", s1, s2));
                }
            }
            else
            {
                if (s1 == s2)
                {
                    pass.Add(String.Join(" , ", s1, s2));
                }
                else
                {
                    fail.Add(String.Join(" , ", s1, s2));
                }
            }
        }
    }
}
