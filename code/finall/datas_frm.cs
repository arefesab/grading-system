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
    public partial class datas_frm : Form
    {
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet data = new DataSet();
        public datas_frm()
        {
            InitializeComponent();
        }

        private void datas_frm_Load(object sender, EventArgs e)
        {
            command.Connection = Form1.connection;
            command.CommandType = CommandType.Text; // اگر پروسیجر داریم باید پروسیجر باشه
            command.CommandText = "select * from score";
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

            score_gridview.DataSource = data.Tables[0];
        }

        private void inserts_btn_Click(object sender, EventArgs e)
        {
            command.Connection = Form1.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "insert_score";
            command.Parameters.Clear();

            command.Parameters.AddWithValue("@stid", stid_tbox.Text);
            command.Parameters.AddWithValue("@score_value", scorevalue_tbox.Text);
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
            command.CommandText = "select * from score";
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
            score_gridview.DataSource = data.Tables[0];
        }

        private void delets_btn_Click(object sender, EventArgs e)
        {
            command.Connection = Form1.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from score where stid= " + dstids_tbox.Text + "and lesid="+dlesids_tbox.Text;
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
            command.CommandText = "select * from score";
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
            score_gridview.DataSource = data.Tables[0];
        }

        private void updates_btn_Click(object sender, EventArgs e)
        {
            command.Connection = Form1.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "update score set score_value=N'" + uscore_value_tbox.Text + "' where lesid=" + ulesid_tbox.Text + "and stid=" + ustid_tbox.Text ;
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
            command.CommandText = "select * from score";
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
            score_gridview.DataSource = data.Tables[0];
        }
    }
    }

