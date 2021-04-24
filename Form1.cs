using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        string Course, Semester, Professor, Q1Answer, Q2Answer, Q3Answer;
        public Form1()
        {
            InitializeComponent();   
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void clear_text()
        {
            txtCC.Text = "";
            txtProf.Text = "";
            txtSem.Text = "";
        }
        private void setQ1(string q1) { Q1Answer = q1; }
        private void setQ2(string q2) { Q2Answer = q2; }
        private void setQ3(string q3) { Q3Answer = q3; }


       
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            Course = txtCC.Text;
            Semester = txtSem.Text;
            Professor = txtProf.Text;
            
            FormQ1 fQ1 = new FormQ1();
            FormQ2 fQ2 = new FormQ2();
            FormQ3 fQ3 = new FormQ3();
            FormLast fLast = new FormLast();
            
            fQ1.Show();
            fQ1.formQ1_nextClick += (sender2, e2) => setQ1(fQ1.Q1);
            fQ1.formQ1_nextClick += (sender2, e2) => fQ2.Show();
            
            fQ2.formQ2_nextClick += (sender2, e2) => setQ2(fQ2.Q2);
            fQ2.formQ2_nextClick += (sender2, e2) => fQ3.Show();
            
            fQ3.formQ3_nextClick += (sender2, e2) => setQ3(fQ3.Q3);
            fQ3.formQ3_nextClick += (sender2, e2) =>fLast.setAll(Course, Semester, Professor, Q1Answer, Q2Answer, Q3Answer);
            fQ3.formQ3_nextClick += (sender2, e2) => fLast.Show();
            
            fLast.formLast_yesClick += (sender2, e2) => clear_text();
        }
    }
}
