using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace studentAffairsAutomation
{
    public partial class loginScreen : Form
    {
        SqlConnection con = new SqlConnection("Data Source=BERDAN\\SQLEXPRESS;Initial Catalog=studentAffairsAutomation;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;

        public loginScreen()
        {
            InitializeComponent();
        }

        private void mainScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            mainScreen mainScreen = new mainScreen();
            mainScreen.Show();
            this.Hide();
        }

        private void loginScreen_Load(object sender, EventArgs e)
        {
            con.Open();
            MessageBox.Show("Welcome. Enter your username and password to enter automation.");
        }
    }
}
