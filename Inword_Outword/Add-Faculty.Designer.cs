namespace Inword_Outword
{
    partial class Add_Assigned_To
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Assigned_To));
            this.btn_s = new System.Windows.Forms.Button();
            this.btn_u = new System.Windows.Forms.Button();
            this.btn_d = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.dgvfaculty = new System.Windows.Forms.DataGridView();
            this.fidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fdesigDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.akimssDataSet = new Inword_Outword.akimssDataSet();
            this.LBLADDSUB = new System.Windows.Forms.Label();
            this.lblc_name = new System.Windows.Forms.Label();
            this.lblf_desig = new System.Windows.Forms.Label();
            this.lblf_name = new System.Windows.Forms.Label();
            this.lblf_id = new System.Windows.Forms.Label();
            this.cmbc_name = new System.Windows.Forms.ComboBox();
            this.txtf_name = new System.Windows.Forms.TextBox();
            this.lbl_f_id = new System.Windows.Forms.Label();
            this.lbl_c_id = new System.Windows.Forms.Label();
            this.lblc_id = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.cmbdesig = new System.Windows.Forms.ComboBox();
            this.facultyTableAdapter = new Inword_Outword.akimssDataSetTableAdapters.facultyTableAdapter();
            this.LBLOUTREG = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inwardToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.outwardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfaculty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akimssDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_s
            // 
            this.btn_s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_s.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_s.Location = new System.Drawing.Point(189, 677);
            this.btn_s.Name = "btn_s";
            this.btn_s.Size = new System.Drawing.Size(101, 30);
            this.btn_s.TabIndex = 9;
            this.btn_s.Text = "SAVE";
            this.btn_s.UseVisualStyleBackColor = true;
            this.btn_s.Click += new System.EventHandler(this.btn_s_Click);
            // 
            // btn_u
            // 
            this.btn_u.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_u.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_u.Location = new System.Drawing.Point(343, 677);
            this.btn_u.Name = "btn_u";
            this.btn_u.Size = new System.Drawing.Size(124, 30);
            this.btn_u.TabIndex = 10;
            this.btn_u.Text = "MODIFY";
            this.btn_u.UseVisualStyleBackColor = true;
            this.btn_u.Click += new System.EventHandler(this.btn_u_Click);
            // 
            // btn_d
            // 
            this.btn_d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_d.Location = new System.Drawing.Point(517, 677);
            this.btn_d.Name = "btn_d";
            this.btn_d.Size = new System.Drawing.Size(112, 30);
            this.btn_d.TabIndex = 11;
            this.btn_d.Text = "DELETE";
            this.btn_d.UseVisualStyleBackColor = true;
            this.btn_d.Click += new System.EventHandler(this.btn_d_Click);
            // 
            // btn_c
            // 
            this.btn_c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_c.Location = new System.Drawing.Point(46, 677);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(92, 30);
            this.btn_c.TabIndex = 8;
            this.btn_c.Text = "NEW";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // dgvfaculty
            // 
            this.dgvfaculty.AutoGenerateColumns = false;
            this.dgvfaculty.BackgroundColor = System.Drawing.Color.White;
            this.dgvfaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfaculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fidDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.fdesigDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn});
            this.dgvfaculty.DataSource = this.facultyBindingSource;
            this.dgvfaculty.Location = new System.Drawing.Point(687, 263);
            this.dgvfaculty.Name = "dgvfaculty";
            this.dgvfaculty.RowTemplate.Height = 24;
            this.dgvfaculty.Size = new System.Drawing.Size(708, 444);
            this.dgvfaculty.TabIndex = 66;
            this.dgvfaculty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvassigned_CellContentClick);
            this.dgvfaculty.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvassigned_RowHeaderMouseClick);
            // 
            // fidDataGridViewTextBoxColumn
            // 
            this.fidDataGridViewTextBoxColumn.DataPropertyName = "f_id";
            this.fidDataGridViewTextBoxColumn.HeaderText = "Assigned ID";
            this.fidDataGridViewTextBoxColumn.Name = "fidDataGridViewTextBoxColumn";
            this.fidDataGridViewTextBoxColumn.ReadOnly = true;
            this.fidDataGridViewTextBoxColumn.Width = 70;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "f_name";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Assigned Name";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.Width = 130;
            // 
            // fdesigDataGridViewTextBoxColumn
            // 
            this.fdesigDataGridViewTextBoxColumn.DataPropertyName = "f_desig";
            this.fdesigDataGridViewTextBoxColumn.HeaderText = "Assigned Designation";
            this.fdesigDataGridViewTextBoxColumn.Name = "fdesigDataGridViewTextBoxColumn";
            this.fdesigDataGridViewTextBoxColumn.Width = 130;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "c_name";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "Department Name";
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            this.cnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataMember = "faculty";
            this.facultyBindingSource.DataSource = this.akimssDataSet;
            // 
            // akimssDataSet
            // 
            this.akimssDataSet.DataSetName = "akimssDataSet";
            this.akimssDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LBLADDSUB
            // 
            this.LBLADDSUB.AutoSize = true;
            this.LBLADDSUB.BackColor = System.Drawing.Color.DarkOrange;
            this.LBLADDSUB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLADDSUB.ForeColor = System.Drawing.Color.White;
            this.LBLADDSUB.Location = new System.Drawing.Point(671, 125);
            this.LBLADDSUB.Name = "LBLADDSUB";
            this.LBLADDSUB.Size = new System.Drawing.Size(180, 20);
            this.LBLADDSUB.TabIndex = 54;
            this.LBLADDSUB.Text = "ADD ASSIGNED TO";
            // 
            // lblc_name
            // 
            this.lblc_name.AutoSize = true;
            this.lblc_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc_name.Location = new System.Drawing.Point(25, 213);
            this.lblc_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblc_name.Name = "lblc_name";
            this.lblc_name.Size = new System.Drawing.Size(123, 17);
            this.lblc_name.TabIndex = 58;
            this.lblc_name.Text = "Department Name";
            // 
            // lblf_desig
            // 
            this.lblf_desig.AutoSize = true;
            this.lblf_desig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblf_desig.Location = new System.Drawing.Point(71, 439);
            this.lblf_desig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblf_desig.Name = "lblf_desig";
            this.lblf_desig.Size = new System.Drawing.Size(166, 17);
            this.lblf_desig.TabIndex = 57;
            this.lblf_desig.Text = "Assigned To Designation";
            // 
            // lblf_name
            // 
            this.lblf_name.AutoSize = true;
            this.lblf_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblf_name.Location = new System.Drawing.Point(25, 80);
            this.lblf_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblf_name.Name = "lblf_name";
            this.lblf_name.Size = new System.Drawing.Size(128, 17);
            this.lblf_name.TabIndex = 56;
            this.lblf_name.Text = "Assigned To Name";
            // 
            // lblf_id
            // 
            this.lblf_id.AutoSize = true;
            this.lblf_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblf_id.Location = new System.Drawing.Point(25, 15);
            this.lblf_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblf_id.Name = "lblf_id";
            this.lblf_id.Size = new System.Drawing.Size(81, 17);
            this.lblf_id.TabIndex = 55;
            this.lblf_id.Text = "Assigned Id";
            // 
            // cmbc_name
            // 
            this.cmbc_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbc_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbc_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbc_name.FormattingEnabled = true;
            this.cmbc_name.Location = new System.Drawing.Point(294, 504);
            this.cmbc_name.Margin = new System.Windows.Forms.Padding(4);
            this.cmbc_name.Name = "cmbc_name";
            this.cmbc_name.Size = new System.Drawing.Size(255, 24);
            this.cmbc_name.TabIndex = 4;
            this.cmbc_name.SelectedIndexChanged += new System.EventHandler(this.cmbc_name_SelectedIndexChanged);
            this.cmbc_name.DropDownStyleChanged += new System.EventHandler(this.cmbc_name_DropDownStyleChanged);
            this.cmbc_name.SelectedValueChanged += new System.EventHandler(this.cmbc_name_SelectedValueChanged);
            // 
            // txtf_name
            // 
            this.txtf_name.Location = new System.Drawing.Point(294, 371);
            this.txtf_name.Margin = new System.Windows.Forms.Padding(4);
            this.txtf_name.Name = "txtf_name";
            this.txtf_name.Size = new System.Drawing.Size(254, 22);
            this.txtf_name.TabIndex = 2;
            // 
            // lbl_f_id
            // 
            this.lbl_f_id.AutoSize = true;
            this.lbl_f_id.Location = new System.Drawing.Point(291, 309);
            this.lbl_f_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_f_id.Name = "lbl_f_id";
            this.lbl_f_id.Size = new System.Drawing.Size(35, 17);
            this.lbl_f_id.TabIndex = 1;
            this.lbl_f_id.Text = "F_Id";
            // 
            // lbl_c_id
            // 
            this.lbl_c_id.AutoSize = true;
            this.lbl_c_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_c_id.Location = new System.Drawing.Point(145, 540);
            this.lbl_c_id.Name = "lbl_c_id";
            this.lbl_c_id.Size = new System.Drawing.Size(27, 12);
            this.lbl_c_id.TabIndex = 45;
            this.lbl_c_id.Text = "C_ID";
            this.lbl_c_id.Visible = false;
            // 
            // lblc_id
            // 
            this.lblc_id.AutoSize = true;
            this.lblc_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc_id.Location = new System.Drawing.Point(73, 540);
            this.lblc_id.Name = "lblc_id";
            this.lblc_id.Size = new System.Drawing.Size(66, 12);
            this.lblc_id.TabIndex = 64;
            this.lblc_id.Text = "Department ID";
            this.lblc_id.Visible = false;
            // 
            // button_exit
            // 
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.Location = new System.Drawing.Point(1303, 181);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(92, 30);
            this.button_exit.TabIndex = 65;
            this.button_exit.Text = "EXIT";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // cmbdesig
            // 
            this.cmbdesig.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbdesig.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbdesig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdesig.FormattingEnabled = true;
            this.cmbdesig.Items.AddRange(new object[] {
            "Select Designation",
            "Director",
            "Associate Professor",
            "Assistant Professor",
            "Senior Clerk",
            "Junior Clerk",
            "Tranine Clerk",
            "Librarian",
            "Assistant Librarian",
            "Computer Programmer",
            "System Programmer",
            "Peon",
            "Student",
            "General"});
            this.cmbdesig.Location = new System.Drawing.Point(294, 439);
            this.cmbdesig.Name = "cmbdesig";
            this.cmbdesig.Size = new System.Drawing.Size(195, 24);
            this.cmbdesig.TabIndex = 3;
            // 
            // facultyTableAdapter
            // 
            this.facultyTableAdapter.ClearBeforeFill = true;
            // 
            // LBLOUTREG
            // 
            this.LBLOUTREG.AutoSize = true;
            this.LBLOUTREG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLOUTREG.ForeColor = System.Drawing.Color.Black;
            this.LBLOUTREG.Location = new System.Drawing.Point(401, 34);
            this.LBLOUTREG.Name = "LBLOUTREG";
            this.LBLOUTREG.Size = new System.Drawing.Size(679, 75);
            this.LBLOUTREG.TabIndex = 68;
            this.LBLOUTREG.Text = "Bharati Vidyapeeth\r\n(Deemed To Be) University, Pune\r\nAbhijit Kadam Institute of M" +
    "anagement and Social Sciences, Solapur.\r\n";
            this.LBLOUTREG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblf_id);
            this.panel1.Controls.Add(this.lblf_name);
            this.panel1.Controls.Add(this.lblc_name);
            this.panel1.Location = new System.Drawing.Point(46, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 274);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inwardToolStripMenuItem2,
            this.outwardToolStripMenuItem1,
            this.aboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1461, 31);
            this.menuStrip1.TabIndex = 70;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inwardToolStripMenuItem2
            // 
            this.inwardToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inwardToolStripMenuItem2.Name = "inwardToolStripMenuItem2";
            this.inwardToolStripMenuItem2.Size = new System.Drawing.Size(88, 27);
            this.inwardToolStripMenuItem2.Text = "INWARD";
            this.inwardToolStripMenuItem2.Click += new System.EventHandler(this.inwardToolStripMenuItem2_Click);
            // 
            // outwardToolStripMenuItem1
            // 
            this.outwardToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outwardToolStripMenuItem1.Name = "outwardToolStripMenuItem1";
            this.outwardToolStripMenuItem1.Size = new System.Drawing.Size(104, 27);
            this.outwardToolStripMenuItem1.Text = "OUTWARD";
            this.outwardToolStripMenuItem1.Click += new System.EventHandler(this.outwardToolStripMenuItem1_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutUsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(103, 27);
            this.aboutUsToolStripMenuItem.Text = "ABOUT US";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inword_Outword.Properties.Resources.BV;
            this.pictureBox1.Location = new System.Drawing.Point(7, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // Add_Assigned_To
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1461, 741);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cmbdesig);
            this.Controls.Add(this.lblc_id);
            this.Controls.Add(this.lbl_c_id);
            this.Controls.Add(this.cmbc_name);
            this.Controls.Add(this.txtf_name);
            this.Controls.Add(this.lbl_f_id);
            this.Controls.Add(this.lblf_desig);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LBLOUTREG);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.LBLADDSUB);
            this.Controls.Add(this.dgvfaculty);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_d);
            this.Controls.Add(this.btn_u);
            this.Controls.Add(this.btn_s);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Assigned_To";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Faculty";
            this.Load += new System.EventHandler(this.Add_Assigned_To_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfaculty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akimssDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_s;
        private System.Windows.Forms.Button btn_u;
        private System.Windows.Forms.Button btn_d;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.DataGridView dgvfaculty;
        private System.Windows.Forms.Label LBLADDSUB;
        private System.Windows.Forms.Label lblc_name;
        private System.Windows.Forms.Label lblf_desig;
        private System.Windows.Forms.Label lblf_name;
        private System.Windows.Forms.Label lblf_id;
        private System.Windows.Forms.ComboBox cmbc_name;
        private System.Windows.Forms.TextBox txtf_name;
        private System.Windows.Forms.Label lbl_f_id;
        private System.Windows.Forms.Label lbl_c_id;
        private System.Windows.Forms.Label lblc_id;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.ComboBox cmbdesig;
        private akimssDataSet akimssDataSet;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private akimssDataSetTableAdapters.facultyTableAdapter facultyTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBLOUTREG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fdesigDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        protected System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inwardToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem outwardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
    }
}