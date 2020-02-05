using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FormDriverReg : Form
    {
        public FormDriverReg()
        {
            InitializeComponent();
        }

        public static FormDriverReg myD { get; internal set; }

        private void ClickDriver(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveTextFrstNme(object sender, EventArgs e)
        {

        }
       
        private void saveText(object sender, EventArgs e)
        {
            String Text1 = textBox1.Text;
            String Text2 = textBox2.Text;
            String Text3 = textBox3.Text;
            String Text4 = textBox4.Text;


            String bigString;
            bigString = Text1.PadRight(15, ' ') + Text2.PadRight(15, ' ') + Text3.PadRight(1, ' ') + Text4.PadRight(10, ' ');


            string path = @"MySmithDriver.txt";
            string myNumbers = "12345678901234567890123456789012345678901";


            if (!File.Exists(path))
            {
                using (System.IO.StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(myNumbers);
                }

            }
            using (System.IO.StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(bigString);
            }


        }
    }
}
