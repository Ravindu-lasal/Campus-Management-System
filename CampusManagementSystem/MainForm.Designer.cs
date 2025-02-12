namespace CampusManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnaddStu = new System.Windows.Forms.Button();
            this.btnaddTea = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboardform1 = new CampusManagementSystem.Dashboardform();
            this.addStudentForm1 = new CampusManagementSystem.AddStudentForm();
            this.addTeacherForm2 = new CampusManagementSystem.AddTeacherForm();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.addTeacherForm1 = new CampusManagementSystem.AddTeacherForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(220)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 25);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Campus Management System | Main Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1059, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(107)))));
            this.panel2.Controls.Add(this.btnlogout);
            this.panel2.Controls.Add(this.btnaddStu);
            this.panel2.Controls.Add(this.btnaddTea);
            this.panel2.Controls.Add(this.btnDash);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 536);
            this.panel2.TabIndex = 1;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Transparent;
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnlogout.FlatAppearance.BorderSize = 3;
            this.btnlogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnlogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.Location = new System.Drawing.Point(6, 495);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(40, 40);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnaddStu
            // 
            this.btnaddStu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddStu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddStu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddStu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnaddStu.Image = ((System.Drawing.Image)(resources.GetObject("btnaddStu.Image")));
            this.btnaddStu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddStu.Location = new System.Drawing.Point(12, 245);
            this.btnaddStu.Name = "btnaddStu";
            this.btnaddStu.Size = new System.Drawing.Size(200, 40);
            this.btnaddStu.TabIndex = 3;
            this.btnaddStu.Text = "Add Student";
            this.btnaddStu.UseVisualStyleBackColor = true;
            this.btnaddStu.Click += new System.EventHandler(this.btnaddStu_Click);
            // 
            // btnaddTea
            // 
            this.btnaddTea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddTea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddTea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddTea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnaddTea.Image = ((System.Drawing.Image)(resources.GetObject("btnaddTea.Image")));
            this.btnaddTea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddTea.Location = new System.Drawing.Point(12, 300);
            this.btnaddTea.Name = "btnaddTea";
            this.btnaddTea.Size = new System.Drawing.Size(200, 40);
            this.btnaddTea.TabIndex = 2;
            this.btnaddTea.Text = "Add Teacher";
            this.btnaddTea.UseVisualStyleBackColor = true;
            this.btnaddTea.Click += new System.EventHandler(this.btnaddTea_Click);
            // 
            // btnDash
            // 
            this.btnDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDash.Image = ((System.Drawing.Image)(resources.GetObject("btnDash.Image")));
            this.btnDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDash.Location = new System.Drawing.Point(12, 189);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(200, 40);
            this.btnDash.TabIndex = 2;
            this.btnDash.Text = "Dashboard";
            this.btnDash.UseVisualStyleBackColor = true;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(52, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome, Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dashboardform1);
            this.panel3.Controls.Add(this.addStudentForm1);
            this.panel3.Controls.Add(this.addTeacherForm2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(255, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(829, 536);
            this.panel3.TabIndex = 2;
            // 
            // dashboardform1
            // 
            this.dashboardform1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardform1.Location = new System.Drawing.Point(0, 0);
            this.dashboardform1.Name = "dashboardform1";
            this.dashboardform1.Size = new System.Drawing.Size(827, 534);
            this.dashboardform1.TabIndex = 2;
            // 
            // addStudentForm1
            // 
            this.addStudentForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addStudentForm1.Location = new System.Drawing.Point(0, 0);
            this.addStudentForm1.Name = "addStudentForm1";
            this.addStudentForm1.Size = new System.Drawing.Size(827, 534);
            this.addStudentForm1.TabIndex = 1;
            // 
            // addTeacherForm2
            // 
            this.addTeacherForm2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTeacherForm2.Location = new System.Drawing.Point(0, 0);
            this.addTeacherForm2.Name = "addTeacherForm2";
            this.addTeacherForm2.Size = new System.Drawing.Size(827, 534);
            this.addTeacherForm2.TabIndex = 0;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // addTeacherForm1
            // 
            this.addTeacherForm1.Location = new System.Drawing.Point(-1, -1);
            this.addTeacherForm1.Name = "addTeacherForm1";
            this.addTeacherForm1.Size = new System.Drawing.Size(829, 536);
            this.addTeacherForm1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Button btnaddStu;
        private System.Windows.Forms.Button btnaddTea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private AddTeacherForm addTeacherForm1;
        private AddTeacherForm addTeacherForm2;
        private AddStudentForm addStudentForm1;
        private Dashboardform dashboardform1;
    }
}