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
    public partial class dataqu_frm : Form
    {
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet data = new DataSet();
     
        public dataqu_frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command.Connection = Form1.connection;
            command.CommandType = CommandType.StoredProcedure; // اگر پروسیجر داریم باید پروسیجر باشه
            command.CommandText = "INFO";
            command.Parameters.Clear();
            adapter.SelectCommand = command;
            data.Tables.Clear();
            command.Parameters.AddWithValue("@stidd", stidd_tbox.Text);
            try
            {
                command.Connection.Open();
                adapter.Fill(data);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            catch
            {
                command.Connection.Close();
                MessageBox.Show("error!");
                return;
            }
            quary_gridview.DataSource = data.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            try
            {
                command.Connection = Form1.connection;
                command.CommandType = CommandType.StoredProcedure; // اگر پروسیجر داریم باید پروسیجر باشه
                command.CommandText = "LIST";
                command.Parameters.Clear();
                adapter.SelectCommand = command;
                data.Tables.Clear();
                command.Parameters.AddWithValue("@lesidd", lesidd_tbox.Text);
                command.Connection.Open();
                adapter.Fill(data);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            catch
            {
                command.Connection.Close();
                MessageBox.Show("error!");
                return;
            }
            quary_gridview.DataSource = data.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            command.Connection = Form1.connection;
            command.CommandType = CommandType.StoredProcedure; // اگر پروسیجر داریم باید پروسیجر باشه
            command.CommandText = "TOP";
            command.Parameters.Clear();
            adapter.SelectCommand = command;
            data.Tables.Clear();

            try
            {
                command.Connection.Open();
                adapter.Fill(data);
                // command.ExecuteNonQuery();
                command.Connection.Close();
            }
            catch
            {
                command.Connection.Close();
                MessageBox.Show("error!");
                return;
            }
            quary_gridview.DataSource = data.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {

            command.Connection = Form1.connection;
            command.CommandType = CommandType.StoredProcedure; // اگر پروسیجر داریم باید پروسیجر باشه
            command.CommandText = "FAIL";
            command.Parameters.Clear();
            adapter.SelectCommand = command;
            data.Tables.Clear();

            try
            {
                command.Connection.Open();
                adapter.Fill(data);
                // command.ExecuteNonQuery();
                command.Connection.Close();
            }
            catch
            {
                command.Connection.Close();
                MessageBox.Show("error!");
                return;
            }
            quary_gridview.DataSource = data.Tables[0];
        }
    }
}
