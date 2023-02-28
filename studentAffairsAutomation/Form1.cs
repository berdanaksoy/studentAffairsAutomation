using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentAffairsAutomation
{
    public partial class mainScreen : Form
    {
        public mainScreen()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void mainScreen_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome. Enter your username and password to enter automation.");
        }
    }
}
