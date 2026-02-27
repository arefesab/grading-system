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
    public partial class data_frm : Form
    {
        SqlCommand command = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet data = new DataSet();
        string imgLoc = "";
        Image img;
        public data_frm()
        {
            InitializeComponent();
        }

        private void data_frm_Load(object sender, EventArgs e)
        {
            command.Connection = Form1.connection;
            command.CommandType = CommandType.Text; // اگر پروسیجر داریم باید پروسیجر باشه
            command.CommandText = "select * from student";
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

            student_gridview.DataSource = data.Tables[0];


        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream mymemory = new System.IO.MemoryStream();
            img.Save(mymemory, picture_student.Image.RawFormat);
            byte[] myarry = mymemory.GetBuffer();
            command.Connection = Form1.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "insertnew_student";
            command.Parameters.Clear();

            command.Parameters.AddWithValue("@name", name_tbox.Text);
            command.Parameters.AddWithValue("@fname", fname_tbox.Text);
            command.Parameters.AddWithValue("@stid", stid_tbox.Text);
            command.Parameters.AddWithValue("@birthdate", birthdate_tbox.Text);
            command.Parameters.AddWithValue("@image", myarry);

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
            picture_student.Image = null;
            birthdate_tbox.Text = null;
            stid_tbox.Text = null;
            fname_tbox.Text = null;
            name_tbox.Text = null;
            command.Connection = Form1.connection;
            command.CommandType = CommandType.Text; // اگر پروسیجر داریم باید پروسیجر باشه
            command.CommandText = "select * from student";
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
            student_gridview.DataSource = data.Tables[0];
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            command.Connection = Form1.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from student where stid= " + dstid_tbox.Text;
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
            dstid_tbox.Text = null;
            command.Connection = Form1.connection;
            command.CommandType = CommandType.Text; // اگر پروسیجر داریم باید پروسیجر باشه
            command.CommandText = "select * from student";
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
            student_gridview.DataSource = data.Tables[0];
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream mymemory = new System.IO.MemoryStream();
            img.Save(mymemory, pictureu_student.Image.RawFormat);
            byte[] myarry = mymemory.GetBuffer();
            command.Connection = Form1.connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "update_student ";
            command.Parameters.Clear();

            command.Parameters.AddWithValue("@name", uname_tbox.Text);
            command.Parameters.AddWithValue("@fname", ufname_tbox.Text);
            command.Parameters.AddWithValue("@stid", ustid_tbox.Text);
            command.Parameters.AddWithValue("@birthdate", ubirthdate_tbox.Text);
            command.Parameters.AddWithValue("@image", myarry);
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
            ustid_tbox.Text = uname_tbox.Text =ufname_tbox.Text = ubirthdate_tbox.Text = " ";
            pictureu_student.Image = null;
            command.Connection = Form1.connection;
            command.CommandType = CommandType.Text; // اگر پروسیجر داریم باید پروسیجر باشه
            command.CommandText = "select * from student";
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
            student_gridview.DataSource = data.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "select student Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    picture_student.ImageLocation = imgLoc;
                }
                img = Image.FromFile(dlg.FileName);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "select student Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pictureu_student.ImageLocation = imgLoc;
                }
                img = Image.FromFile(dlg.FileName);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
