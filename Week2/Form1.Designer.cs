namespace Week2
{
    partial class frm_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Registration));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grbox_registration = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_strand = new System.Windows.Forms.Label();
            this.lbl_course = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.grd_search = new System.Windows.Forms.DataGridView();
            this.grbox_searchname = new System.Windows.Forms.GroupBox();
            this.btn_showall = new System.Windows.Forms.Button();
            this.lbl_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbox_registration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_search)).BeginInit();
            this.grbox_searchname.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 94);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(379, 35);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(529, 39);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Faculty of Information Technology";
            // 
            // grbox_registration
            // 
            this.grbox_registration.Controls.Add(this.textBox4);
            this.grbox_registration.Controls.Add(this.textBox3);
            this.grbox_registration.Controls.Add(this.txt_address);
            this.grbox_registration.Controls.Add(this.txt_name);
            this.grbox_registration.Controls.Add(this.lbl_strand);
            this.grbox_registration.Controls.Add(this.lbl_course);
            this.grbox_registration.Controls.Add(this.lbl_address);
            this.grbox_registration.Controls.Add(this.lbl_name);
            this.grbox_registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbox_registration.Location = new System.Drawing.Point(55, 154);
            this.grbox_registration.Name = "grbox_registration";
            this.grbox_registration.Size = new System.Drawing.Size(494, 314);
            this.grbox_registration.TabIndex = 8;
            this.grbox_registration.TabStop = false;
            this.grbox_registration.Text = "Class Registration";
            this.grbox_registration.Enter += new System.EventHandler(this.grbox_registration_Enter);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(187, 256);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(274, 30);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(187, 188);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(274, 30);
            this.textBox3.TabIndex = 8;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(187, 124);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(274, 30);
            this.txt_address.TabIndex = 7;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(187, 68);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(274, 30);
            this.txt_name.TabIndex = 6;
            this.txt_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lbl_strand
            // 
            this.lbl_strand.AutoSize = true;
            this.lbl_strand.Location = new System.Drawing.Point(67, 261);
            this.lbl_strand.Name = "lbl_strand";
            this.lbl_strand.Size = new System.Drawing.Size(70, 25);
            this.lbl_strand.TabIndex = 3;
            this.lbl_strand.Text = "Strand";
            // 
            // lbl_course
            // 
            this.lbl_course.AutoSize = true;
            this.lbl_course.Location = new System.Drawing.Point(67, 193);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(82, 25);
            this.lbl_course.TabIndex = 2;
            this.lbl_course.Text = "Course:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(67, 129);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(91, 25);
            this.lbl_address.TabIndex = 1;
            this.lbl_address.Text = "Address:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(67, 68);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(70, 25);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name:";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(33, 46);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(240, 30);
            this.txt_search.TabIndex = 10;
            this.txt_search.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(332, 498);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(90, 44);
            this.btn_update.TabIndex = 13;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_button_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(439, 498);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(77, 44);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // grd_search
            // 
            this.grd_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_search.Location = new System.Drawing.Point(33, 101);
            this.grd_search.Name = "grd_search";
            this.grd_search.RowTemplate.Height = 24;
            this.grd_search.Size = new System.Drawing.Size(394, 185);
            this.grd_search.TabIndex = 12;
            this.grd_search.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_search_CellClick);
            this.grd_search.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // grbox_searchname
            // 
            this.grbox_searchname.Controls.Add(this.btn_showall);
            this.grbox_searchname.Controls.Add(this.txt_search);
            this.grbox_searchname.Controls.Add(this.grd_search);
            this.grbox_searchname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbox_searchname.Location = new System.Drawing.Point(580, 182);
            this.grbox_searchname.Name = "grbox_searchname";
            this.grbox_searchname.Size = new System.Drawing.Size(459, 339);
            this.grbox_searchname.TabIndex = 13;
            this.grbox_searchname.TabStop = false;
            this.grbox_searchname.Text = "Search Name";
            // 
            // btn_showall
            // 
            this.btn_showall.Location = new System.Drawing.Point(295, 46);
            this.btn_showall.Name = "btn_showall";
            this.btn_showall.Size = new System.Drawing.Size(132, 30);
            this.btn_showall.TabIndex = 13;
            this.btn_showall.Text = "Show All";
            this.btn_showall.UseVisualStyleBackColor = true;
            this.btn_showall.Click += new System.EventHandler(this.btn_showall_Click);
            // 
            // lbl_label
            // 
            this.lbl_label.AutoSize = true;
            this.lbl_label.Location = new System.Drawing.Point(580, 123);
            this.lbl_label.Name = "lbl_label";
            this.lbl_label.Size = new System.Drawing.Size(0, 17);
            this.lbl_label.TabIndex = 14;
            // 
            // frm_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 611);
            this.Controls.Add(this.lbl_label);
            this.Controls.Add(this.grbox_searchname);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.grbox_registration);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.frm_Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbox_registration.ResumeLayout(false);
            this.grbox_registration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_search)).EndInit();
            this.grbox_searchname.ResumeLayout(false);
            this.grbox_searchname.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grbox_registration;
        private System.Windows.Forms.Label lbl_strand;
        private System.Windows.Forms.Label lbl_course;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView grd_search;
        private System.Windows.Forms.GroupBox grbox_searchname;
        private System.Windows.Forms.Button btn_showall;
        private System.Windows.Forms.Label lbl_label;
    }
}

