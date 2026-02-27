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

namespace finall
{
    public partial class Form1 : Form
    {
        public static SqlConnection connection = new SqlConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection_str = "Data Source=DESKTOP-BRN3KQV;Initial Catalog=systmnom ; Integrated Security=True  ; user ID=" + username_tbox.Text + ";password=" + password_tbox.Text ;

            connection.ConnectionString = connection_str;


            try
            {
                connection.Open();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //ret
            }
            MessageBox.Show("connect!");
            cho_frm data_from = new cho_frm();
            data_from.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


