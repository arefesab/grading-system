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
    public partial class datal_frm : Form
    {
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet data = new DataSet();
        public datal_frm()
        {
            InitializeComponent();
        }

        private void datal_frm_Load(object sender, EventArgs e)
        {
            command.Connection = Form1.connection;
            command.CommandType = CommandType.Text; // اگر پروسیجر داریم باید پروسیجر باشه
            command.CommandText = "select * from lesson";
            command.Parameters.Clear();
            adapter.SelectCommand = command;
            data.Tables.Clear();
            try
            {
                adapter.Fill(data);
            }
            catch
            {
                command.Connection.Close();
                MessageBox.Show("error!");
                return;
            }

            lesson_gridview.DataSource = data.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertl_btn_Click(object sender, EventArgs e)
        {
            command.Connection = Form1.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "insert4_lesson";
            command.Parameters.Clear();

            command.Parameters.AddWithValue("@vahed", vahed_tbox.Text);
            command.Parameters.AddWithValue("@lesname", lname_tbox.Text);
            command.Parameters.AddWithValue("@lesid", lesid_tbox.Text);

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();

            }
            catch
            {
                command.Connection.Close();
                MessageBox.Show("error!");
                return;
            }
            command.Connection = Form1.connection;
            command.CommandType = CommandType.Text; // اگر پروسیجر داریم باید پروسیجر باشه
            command.CommandText = "select * from lesson";
            command.Parameters.Clear();

            adapter.SelectCommand = command;
            data.Tables.Clear();
            try
            {
                adapter.Fill(data);
            }
            catch
            {
                command.Connection.Close();
                MessageBox.Show("error!");
                return;
            }
            lesson_gridview.DataSource = data.Tables[0];
        }

        private void deletel_btn_Click(object sender, EventArgs e)
        {
            command.Connection = Form1.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from lesson where lesid= " + dlesid_tbox.Text;
            command.Parameters.Clear();
            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();

            }
            catch
            {
                command.Connection.Close();
                MessageBox.Show("error!");
                return;
            }
            command.Connection = Form1.connection;
            command.CommandType = CommandType.Text; // اگر پروسیجر داریم باید پروسیجر باشه
            command.CommandText = "select * from lesson";
            command.Parameters.Clear();

            adapter.SelectCommand = command;
            data.Tables.Clear();
            try
            {
                adapter.Fill(data);
            }
            catch
            {
                command.Connection.Close();
                MessageBox.Show("error!");
                return;
            }
            lesson_gridview.DataSource = data.Tables[0];
        }

        private void updatel_btn_Click(object sender, EventArgs e)
        {
            command.Connection = Form1.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "update lesson set lesname=N'" + ulname_tbox.Text + "', vahed=N'" + uvahed_tbox.Text + "' where lesid=" + ulesid_tbox.Text;
            command.Parameters.Clear();
            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();

            }
            catch
            {
                command.Connection.Close();
                MessageBox.Show("error!");
                // MessageBox.Show(ex.ToString());
                return;
            }
            command.Connection = Form1.connection;
            command.CommandType = CommandType.Text; // اگر پروسیجر داریم باید پروسیجر باشه
            command.CommandText = "select * from lesson";
            command.Parameters.Clear();

            adapter.SelectCommand = command;
            data.Tables.Clear();
            try
            {
                adapter.Fill(data);
            }
            catch
            {
                command.Connection.Close();
                MessageBox.Show("error!");
                return;
            }
            lesson_gridview.DataSource = data.Tables[0];
        }
    }
}
