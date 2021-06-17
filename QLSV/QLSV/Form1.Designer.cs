
namespace QLSV
{
    partial class Form1
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
            this.gb_TT = new System.Windows.Forms.GroupBox();
            this.gb_gender = new System.Windows.Forms.GroupBox();
            this.radio_famale = new System.Windows.Forms.RadioButton();
            this.radio_male = new System.Windows.Forms.RadioButton();
            this.txt_DC = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.cbb_LHP = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_MSSV = new System.Windows.Forms.TextBox();
            this.lb_DC = new System.Windows.Forms.Label();
            this.lb_NS = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.lb_LHP = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_MSSV = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_LHP2 = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_sort = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.dtdv_SV = new System.Windows.Forms.DataGridView();
            this.cbb_sort = new System.Windows.Forms.ComboBox();
            this.button_show = new System.Windows.Forms.Button();
            this.gb_TT.SuspendLayout();
            this.gb_gender.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtdv_SV)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_TT
            // 
            this.gb_TT.Controls.Add(this.gb_gender);
            this.gb_TT.Controls.Add(this.txt_DC);
            this.gb_TT.Controls.Add(this.dateTimePicker1);
            this.gb_TT.Controls.Add(this.txt_phone);
            this.gb_TT.Controls.Add(this.cbb_LHP);
            this.gb_TT.Controls.Add(this.txt_name);
            this.gb_TT.Controls.Add(this.txt_MSSV);
            this.gb_TT.Controls.Add(this.lb_DC);
            this.gb_TT.Controls.Add(this.lb_NS);
            this.gb_TT.Controls.Add(this.lb_Phone);
            this.gb_TT.Controls.Add(this.lb_LHP);
            this.gb_TT.Controls.Add(this.lb_Name);
            this.gb_TT.Controls.Add(this.lb_MSSV);
            this.gb_TT.Location = new System.Drawing.Point(12, 12);
            this.gb_TT.Name = "gb_TT";
            this.gb_TT.Size = new System.Drawing.Size(776, 155);
            this.gb_TT.TabIndex = 0;
            this.gb_TT.TabStop = false;
            this.gb_TT.Text = "Thông Tin Chi Tiết";
            // 
            // gb_gender
            // 
            this.gb_gender.Controls.Add(this.radio_famale);
            this.gb_gender.Controls.Add(this.radio_male);
            this.gb_gender.Location = new System.Drawing.Point(577, 28);
            this.gb_gender.Name = "gb_gender";
            this.gb_gender.Size = new System.Drawing.Size(193, 90);
            this.gb_gender.TabIndex = 12;
            this.gb_gender.TabStop = false;
            this.gb_gender.Text = "Gender";
            // 
            // radio_famale
            // 
            this.radio_famale.AutoSize = true;
            this.radio_famale.Location = new System.Drawing.Point(16, 56);
            this.radio_famale.Name = "radio_famale";
            this.radio_famale.Size = new System.Drawing.Size(75, 21);
            this.radio_famale.TabIndex = 1;
            this.radio_famale.TabStop = true;
            this.radio_famale.Text = "Famale";
            this.radio_famale.UseVisualStyleBackColor = true;
            // 
            // radio_male
            // 
            this.radio_male.AutoSize = true;
            this.radio_male.Location = new System.Drawing.Point(16, 29);
            this.radio_male.Name = "radio_male";
            this.radio_male.Size = new System.Drawing.Size(59, 21);
            this.radio_male.TabIndex = 0;
            this.radio_male.TabStop = true;
            this.radio_male.Text = "Male";
            this.radio_male.UseVisualStyleBackColor = true;
            // 
            // txt_DC
            // 
            this.txt_DC.Location = new System.Drawing.Point(371, 94);
            this.txt_DC.Name = "txt_DC";
            this.txt_DC.Size = new System.Drawing.Size(200, 22);
            this.txt_DC.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(371, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(371, 28);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(200, 22);
            this.txt_phone.TabIndex = 9;
            // 
            // cbb_LHP
            // 
            this.cbb_LHP.FormattingEnabled = true;
            this.cbb_LHP.Location = new System.Drawing.Point(135, 92);
            this.cbb_LHP.Name = "cbb_LHP";
            this.cbb_LHP.Size = new System.Drawing.Size(133, 24);
            this.cbb_LHP.TabIndex = 8;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(135, 62);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(133, 22);
            this.txt_name.TabIndex = 7;
            // 
            // txt_MSSV
            // 
            this.txt_MSSV.Location = new System.Drawing.Point(135, 28);
            this.txt_MSSV.Name = "txt_MSSV";
            this.txt_MSSV.Size = new System.Drawing.Size(133, 22);
            this.txt_MSSV.TabIndex = 6;
            // 
            // lb_DC
            // 
            this.lb_DC.AutoSize = true;
            this.lb_DC.Location = new System.Drawing.Point(291, 101);
            this.lb_DC.Name = "lb_DC";
            this.lb_DC.Size = new System.Drawing.Size(57, 17);
            this.lb_DC.TabIndex = 5;
            this.lb_DC.Text = "Địa Chỉ ";
            // 
            // lb_NS
            // 
            this.lb_NS.AutoSize = true;
            this.lb_NS.Location = new System.Drawing.Point(291, 62);
            this.lb_NS.Name = "lb_NS";
            this.lb_NS.Size = new System.Drawing.Size(73, 17);
            this.lb_NS.TabIndex = 4;
            this.lb_NS.Text = "Ngày Sinh";
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Location = new System.Drawing.Point(291, 28);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(49, 17);
            this.lb_Phone.TabIndex = 3;
            this.lb_Phone.Text = "Phone";
            // 
            // lb_LHP
            // 
            this.lb_LHP.AutoSize = true;
            this.lb_LHP.Location = new System.Drawing.Point(70, 101);
            this.lb_LHP.Name = "lb_LHP";
            this.lb_LHP.Size = new System.Drawing.Size(55, 17);
            this.lb_LHP.TabIndex = 2;
            this.lb_LHP.Text = "Lớp HP";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(70, 62);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(45, 17);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "Name";
            // 
            // lb_MSSV
            // 
            this.lb_MSSV.AutoSize = true;
            this.lb_MSSV.Location = new System.Drawing.Point(70, 28);
            this.lb_MSSV.Name = "lb_MSSV";
            this.lb_MSSV.Size = new System.Drawing.Size(46, 17);
            this.lb_MSSV.TabIndex = 0;
            this.lb_MSSV.Text = "MSSV";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_show);
            this.groupBox2.Controls.Add(this.cbb_sort);
            this.groupBox2.Controls.Add(this.dtdv_SV);
            this.groupBox2.Controls.Add(this.cbb_LHP2);
            this.groupBox2.Controls.Add(this.txt_search);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button_sort);
            this.groupBox2.Controls.Add(this.button_del);
            this.groupBox2.Controls.Add(this.button_update);
            this.groupBox2.Controls.Add(this.button_add);
            this.groupBox2.Controls.Add(this.button_search);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách SV";
            // 
            // cbb_LHP2
            // 
            this.cbb_LHP2.FormattingEnabled = true;
            this.cbb_LHP2.Location = new System.Drawing.Point(87, 26);
            this.cbb_LHP2.Name = "cbb_LHP2";
            this.cbb_LHP2.Size = new System.Drawing.Size(121, 24);
            this.cbb_LHP2.TabIndex = 7;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(568, 27);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 22);
            this.txt_search.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Lớp HP";
            // 
            // button_sort
            // 
            this.button_sort.Location = new System.Drawing.Point(472, 236);
            this.button_sort.Name = "button_sort";
            this.button_sort.Size = new System.Drawing.Size(75, 23);
            this.button_sort.TabIndex = 4;
            this.button_sort.Text = "Sort";
            this.button_sort.UseVisualStyleBackColor = true;
            // 
            // button_del
            // 
            this.button_del.Location = new System.Drawing.Point(371, 236);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(75, 23);
            this.button_del.TabIndex = 3;
            this.button_del.Text = "Del";
            this.button_del.UseVisualStyleBackColor = true;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(180, 236);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(87, 236);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(674, 26);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 0;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // dtdv_SV
            // 
            this.dtdv_SV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtdv_SV.Location = new System.Drawing.Point(29, 61);
            this.dtdv_SV.Name = "dtdv_SV";
            this.dtdv_SV.RowHeadersWidth = 51;
            this.dtdv_SV.RowTemplate.Height = 24;
            this.dtdv_SV.Size = new System.Drawing.Size(725, 150);
            this.dtdv_SV.TabIndex = 8;
            // 
            // cbb_sort
            // 
            this.cbb_sort.FormattingEnabled = true;
            this.cbb_sort.Location = new System.Drawing.Point(577, 235);
            this.cbb_sort.Name = "cbb_sort";
            this.cbb_sort.Size = new System.Drawing.Size(151, 24);
            this.cbb_sort.TabIndex = 9;
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(273, 236);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(75, 23);
            this.button_show.TabIndex = 10;
            this.button_show.Text = "Show";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_TT);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLSV";
            this.gb_TT.ResumeLayout(false);
            this.gb_TT.PerformLayout();
            this.gb_gender.ResumeLayout(false);
            this.gb_gender.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtdv_SV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_TT;
        private System.Windows.Forms.Label lb_DC;
        private System.Windows.Forms.Label lb_NS;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.Label lb_LHP;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_MSSV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gb_gender;
        private System.Windows.Forms.RadioButton radio_famale;
        private System.Windows.Forms.RadioButton radio_male;
        private System.Windows.Forms.TextBox txt_DC;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.ComboBox cbb_LHP;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_MSSV;
        private System.Windows.Forms.ComboBox cbb_LHP2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_sort;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ComboBox cbb_sort;
        private System.Windows.Forms.DataGridView dtdv_SV;
        private System.Windows.Forms.Button button_show;
    }
}

