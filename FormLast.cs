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
    public partial class FormLast : Form
    {
        public event EventHandler formLast_yesClick;
        string Course, Semester, Professor, Q1Answer, Q2Answer, Q3Answer;
        public FormLast()
        {
            InitializeComponent();
        }

        public void setAll(string course, string semester, string professor, string Answer1, string Answer2, string Answer3)
        {
            Course = course;
            Semester = semester;
            Professor = professor;
            Q1Answer = Answer1;
            Q2Answer = Answer2;
            Q3Answer = Answer3;
            txtboxAnswers.AppendText("Course Code:" + Course + Environment.NewLine);
            txtboxAnswers.AppendText("Semester:" + Semester + Environment.NewLine);
            txtboxAnswers.AppendText("Professor:" + Professor + Environment.NewLine);
            txtboxAnswers.AppendText("Answers:" + Environment.NewLine);
            txtboxAnswers.AppendText("Overall, I would rate the quality of this course as:" + Q1Answer + Environment.NewLine);
            txtboxAnswers.AppendText("Overall, I would rate this professor’s performance as: " + Q2Answer + Environment.NewLine);
            txtboxAnswers.AppendText("Professor demonstrates a thorough knowledge of the subject: " + Q3Answer + Environment.NewLine);

        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            EventHandler handler = formLast_yesClick;

            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
           this.Close();
        }
    }
}
