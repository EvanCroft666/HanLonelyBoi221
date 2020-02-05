using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FormMainMenu : Form
    {

        public FormMainMenu()
        {
            InitializeComponent();
        }


        private void CloseApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ClickOpenDriver(object sender, EventArgs e)
        {

            FormDriverReg myD = new FormDriverReg();
            myD.ShowDialog();
        }
    }
}
