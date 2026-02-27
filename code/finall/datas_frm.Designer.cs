
namespace finall
{
    partial class datas_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.score_gridview = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scorevalue_tbox = new System.Windows.Forms.TextBox();
            this.lesid_tbox = new System.Windows.Forms.TextBox();
            this.stid_tbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inserts_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dlesids_tbox = new System.Windows.Forms.TextBox();
            this.delets_btn = new System.Windows.Forms.Button();
            this.dstids_tbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.updates_btn = new System.Windows.Forms.Button();
            this.uscore_value_tbox = new System.Windows.Forms.TextBox();
            this.ulesid_tbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ustid_tbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.score_gridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // score_gridview
            // 
            this.score_gridview.BackgroundColor = System.Drawing.SystemColors.Window;
            this.score_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.score_gridview.Location = new System.Drawing.Point(12, 12);
            this.score_gridview.Name = "score_gridview";
            this.score_gridview.Size = new System.Drawing.Size(344, 270);
            this.score_gridview.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.groupBox1.Controls.Add(this.scorevalue_tbox);
            this.groupBox1.Controls.Add(this.lesid_tbox);
            this.groupBox1.Controls.Add(this.stid_tbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inserts_btn);
            this.groupBox1.Location = new System.Drawing.Point(362, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(411, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافه کردن";
            // 
            // scorevalue_tbox
            // 
            this.scorevalue_tbox.Location = new System.Drawing.Point(158, 108);
            this.scorevalue_tbox.Name = "scorevalue_tbox";
            this.scorevalue_tbox.Size = new System.Drawing.Size(100, 20);
            this.scorevalue_tbox.TabIndex = 2;
            // 
            // lesid_tbox
            // 
            this.lesid_tbox.Location = new System.Drawing.Point(158, 78);
            this.lesid_tbox.Name = "lesid_tbox";
            this.lesid_tbox.Size = new System.Drawing.Size(100, 20);
            this.lesid_tbox.TabIndex = 2;
            // 
            // stid_tbox
            // 
            this.stid_tbox.Location = new System.Drawing.Point(158, 46);
            this.stid_tbox.Name = "stid_tbox";
            this.stid_tbox.Size = new System.Drawing.Size(100, 20);
            this.stid_tbox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "نمره";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "شماره درس ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "شماره دانشجویی";
            // 
            // inserts_btn
            // 
            this.inserts_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.inserts_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inserts_btn.Location = new System.Drawing.Point(32, 123);
            this.inserts_btn.Name = "inserts_btn";
            this.inserts_btn.Size = new System.Drawing.Size(75, 23);
            this.inserts_btn.TabIndex = 0;
            this.inserts_btn.Text = "ثبت";
            this.inserts_btn.UseVisualStyleBackColor = false;
            this.inserts_btn.Click += new System.EventHandler(this.inserts_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.groupBox2.Controls.Add(this.dlesids_tbox);
            this.groupBox2.Controls.Add(this.delets_btn);
            this.groupBox2.Controls.Add(this.dstids_tbox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(362, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(411, 112);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "حذف اطلاعات";
            // 
            // dlesids_tbox
            // 
            this.dlesids_tbox.Location = new System.Drawing.Point(158, 56);
            this.dlesids_tbox.Name = "dlesids_tbox";
            this.dlesids_tbox.Size = new System.Drawing.Size(100, 20);
            this.dlesids_tbox.TabIndex = 1;
            // 
            // delets_btn
            // 
            this.delets_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.delets_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delets_btn.Location = new System.Drawing.Point(32, 83);
            this.delets_btn.Name = "delets_btn";
            this.delets_btn.Size = new System.Drawing.Size(75, 23);
            this.delets_btn.TabIndex = 2;
            this.delets_btn.Text = "حذف";
            this.delets_btn.UseVisualStyleBackColor = false;
            this.delets_btn.Click += new System.EventHandler(this.delets_btn_Click);
            // 
            // dstids_tbox
            // 
            this.dstids_tbox.Location = new System.Drawing.Point(158, 30);
            this.dstids_tbox.Name = "dstids_tbox";
            this.dstids_tbox.Size = new System.Drawing.Size(100, 20);
            this.dstids_tbox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "شماره درس";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "شماره دانشجویی";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.groupBox3.Controls.Add(this.updates_btn);
            this.groupBox3.Controls.Add(this.uscore_value_tbox);
            this.groupBox3.Controls.Add(this.ulesid_tbox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.ustid_tbox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(761, 135);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ویرایش نمره ";
            // 
            // updates_btn
            // 
            this.updates_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.updates_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updates_btn.Location = new System.Drawing.Point(62, 106);
            this.updates_btn.Name = "updates_btn";
            this.updates_btn.Size = new System.Drawing.Size(75, 23);
            this.updates_btn.TabIndex = 2;
            this.updates_btn.Text = "ویرایش";
            this.updates_btn.UseVisualStyleBackColor = false;
            this.updates_btn.Click += new System.EventHandler(this.updates_btn_Click);
            // 
            // uscore_value_tbox
            // 
            this.uscore_value_tbox.Location = new System.Drawing.Point(287, 37);
            this.uscore_value_tbox.Name = "uscore_value_tbox";
            this.uscore_value_tbox.Size = new System.Drawing.Size(100, 20);
            this.uscore_value_tbox.TabIndex = 1;
            // 
            // ulesid_tbox
            // 
            this.ulesid_tbox.Location = new System.Drawing.Point(508, 75);
            this.ulesid_tbox.Name = "ulesid_tbox";
            this.ulesid_tbox.Size = new System.Drawing.Size(100, 20);
            this.ulesid_tbox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "نمره";
            // 
            // ustid_tbox
            // 
            this.ustid_tbox.Location = new System.Drawing.Point(508, 33);
            this.ustid_tbox.Name = "ustid_tbox";
            this.ustid_tbox.Size = new System.Drawing.Size(100, 20);
            this.ustid_tbox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(661, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "شماره درس";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(648, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "شماره دانشجویی";
            // 
            // datas_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.score_gridview);
            this.Name = "datas_frm";
            this.Text = "جدول نمره ";
            this.TransparencyKey = System.Drawing.SystemColors.Menu;
            this.Load += new System.EventHandler(this.datas_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.score_gridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView score_gridview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button inserts_btn;
        private System.Windows.Forms.TextBox scorevalue_tbox;
        private System.Windows.Forms.TextBox lesid_tbox;
        private System.Windows.Forms.TextBox stid_tbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button delets_btn;
        private System.Windows.Forms.TextBox dstids_tbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dlesids_tbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button updates_btn;
        private System.Windows.Forms.TextBox uscore_value_tbox;
        private System.Windows.Forms.TextBox ulesid_tbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ustid_tbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}