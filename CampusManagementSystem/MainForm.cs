﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusManagementSystem
{
    public partial class MainForm : Form
    {
 

        public MainForm()
        {
            InitializeComponent();



        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you want to logout?", "Confirmation Massage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void btnDash_Click(object sender, EventArgs e)
        {

            if (dashboardform1 != null)
            {
                dashboardform1.displayTotaldata();
            }

            dashboardform1.Visible = true;
            addStudentForm1.Visible = false;
            addTeacherForm1.Visible = false;
        }


        private void btnaddStu_Click(object sender, EventArgs e)
        {
            dashboardform1.Visible = false;
            addStudentForm1.Visible = true;
            addTeacherForm1.Visible = false;
        }

        private void btnaddTea_Click(object sender, EventArgs e)
        {
            dashboardform1.Visible = false;
            addStudentForm1.Visible = false;
            addTeacherForm1.Visible = true;
        }


    }
}
