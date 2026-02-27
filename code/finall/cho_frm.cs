using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finall
{
    public partial class cho_frm : Form
    {
        public cho_frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data_frm data_form = new data_frm();
            data_form.Show();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            datal_frm data_form = new datal_frm();
            data_form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            datas_frm data_from = new datas_frm();
            data_from.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataqu_frm data_from = new dataqu_frm();
            data_from.Show();

        }
    }
}
