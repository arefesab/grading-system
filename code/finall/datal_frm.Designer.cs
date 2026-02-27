
namespace finall
{
    partial class datal_frm
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
            this.lesson_gridview = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.insertl_btn = new System.Windows.Forms.Button();
            this.vahed_tbox = new System.Windows.Forms.TextBox();
            this.lname_tbox = new System.Windows.Forms.TextBox();
            this.lesid_tbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deletel_btn = new System.Windows.Forms.Button();
            this.dlesid_tbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.updatel_btn = new System.Windows.Forms.Button();
            this.uvahed_tbox = new System.Windows.Forms.TextBox();
            this.ulname_tbox = new System.Windows.Forms.TextBox();
            this.ulesid_tbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lesson_gridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lesson_gridview
            // 
            this.lesson_gridview.BackgroundColor = System.Drawing.SystemColors.Window;
            this.lesson_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lesson_gridview.Location = new System.Drawing.Point(12, 12);
            this.lesson_gridview.Name = "lesson_gridview";
            this.lesson_gridview.Size = new System.Drawing.Size(356, 274);
            this.lesson_gridview.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.groupBox1.Controls.Add(this.insertl_btn);
            this.groupBox1.Controls.Add(this.vahed_tbox);
            this.groupBox1.Controls.Add(this.lname_tbox);
            this.groupBox1.Controls.Add(this.lesid_tbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(374, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(391, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافه کردن درس";
            // 
            // insertl_btn
            // 
            this.insertl_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.insertl_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insertl_btn.Location = new System.Drawing.Point(41, 121);
            this.insertl_btn.Name = "insertl_btn";
            this.insertl_btn.Size = new System.Drawing.Size(75, 23);
            this.insertl_btn.TabIndex = 2;
            this.insertl_btn.Text = "اضافه کردن";
            this.insertl_btn.UseVisualStyleBackColor = false;
            this.insertl_btn.Click += new System.EventHandler(this.insertl_btn_Click);
            // 
            // vahed_tbox
            // 
            this.vahed_tbox.Location = new System.Drawing.Point(159, 92);
            this.vahed_tbox.Name = "vahed_tbox";
            this.vahed_tbox.Size = new System.Drawing.Size(100, 20);
            this.vahed_tbox.TabIndex = 1;
            this.vahed_tbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lname_tbox
            // 
            this.lname_tbox.Location = new System.Drawing.Point(159, 66);
            this.lname_tbox.Name = "lname_tbox";
            this.lname_tbox.Size = new System.Drawing.Size(100, 20);
            this.lname_tbox.TabIndex = 1;
            this.lname_tbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lesid_tbox
            // 
            this.lesid_tbox.Location = new System.Drawing.Point(159, 40);
            this.lesid_tbox.Name = "lesid_tbox";
            this.lesid_tbox.Size = new System.Drawing.Size(100, 20);
            this.lesid_tbox.TabIndex = 1;
            this.lesid_tbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "واحد";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام درس";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "شماره درس";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.groupBox2.Controls.Add(this.deletel_btn);
            this.groupBox2.Controls.Add(this.dlesid_tbox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(374, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(391, 111);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "حذف درس";
            // 
            // deletel_btn
            // 
            this.deletel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.deletel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deletel_btn.Location = new System.Drawing.Point(41, 67);
            this.deletel_btn.Name = "deletel_btn";
            this.deletel_btn.Size = new System.Drawing.Size(75, 23);
            this.deletel_btn.TabIndex = 2;
            this.deletel_btn.Text = "حذف";
            this.deletel_btn.UseVisualStyleBackColor = false;
            this.deletel_btn.Click += new System.EventHandler(this.deletel_btn_Click);
            // 
            // dlesid_tbox
            // 
            this.dlesid_tbox.Location = new System.Drawing.Point(159, 37);
            this.dlesid_tbox.Name = "dlesid_tbox";
            this.dlesid_tbox.Size = new System.Drawing.Size(100, 20);
            this.dlesid_tbox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "شماره درس";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.groupBox3.Controls.Add(this.updatel_btn);
            this.groupBox3.Controls.Add(this.uvahed_tbox);
            this.groupBox3.Controls.Add(this.ulname_tbox);
            this.groupBox3.Controls.Add(this.ulesid_tbox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(753, 134);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ویرایش دروس";
            // 
            // updatel_btn
            // 
            this.updatel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.updatel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updatel_btn.Location = new System.Drawing.Point(85, 92);
            this.updatel_btn.Name = "updatel_btn";
            this.updatel_btn.Size = new System.Drawing.Size(75, 23);
            this.updatel_btn.TabIndex = 2;
            this.updatel_btn.Text = "ویرایش";
            this.updatel_btn.UseVisualStyleBackColor = false;
            this.updatel_btn.Click += new System.EventHandler(this.updatel_btn_Click);
            // 
            // uvahed_tbox
            // 
            this.uvahed_tbox.Location = new System.Drawing.Point(275, 43);
            this.uvahed_tbox.Name = "uvahed_tbox";
            this.uvahed_tbox.Size = new System.Drawing.Size(100, 20);
            this.uvahed_tbox.TabIndex = 1;
            // 
            // ulname_tbox
            // 
            this.ulname_tbox.Location = new System.Drawing.Point(521, 36);
            this.ulname_tbox.Name = "ulname_tbox";
            this.ulname_tbox.Size = new System.Drawing.Size(100, 20);
            this.ulname_tbox.TabIndex = 1;
            // 
            // ulesid_tbox
            // 
            this.ulesid_tbox.Location = new System.Drawing.Point(521, 92);
            this.ulesid_tbox.Name = "ulesid_tbox";
            this.ulesid_tbox.Size = new System.Drawing.Size(100, 20);
            this.ulesid_tbox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(656, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "شماره درس";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "واحد";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "نام درس";
            // 
            // datal_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lesson_gridview);
            this.Name = "datal_frm";
            this.Text = "جدول دروس";
            this.TransparencyKey = System.Drawing.SystemColors.Info;
            this.Load += new System.EventHandler(this.datal_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lesson_gridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lesson_gridview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button insertl_btn;
        private System.Windows.Forms.TextBox lesid_tbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vahed_tbox;
        private System.Windows.Forms.TextBox lname_tbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deletel_btn;
        private System.Windows.Forms.TextBox dlesid_tbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button updatel_btn;
        private System.Windows.Forms.TextBox uvahed_tbox;
        private System.Windows.Forms.TextBox ulname_tbox;
        private System.Windows.Forms.TextBox ulesid_tbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}