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
    public partial class FormQ1 : Form
    {
        public event EventHandler formQ1_nextClick; 
        string q1Answer;
        public FormQ1()
        {
            InitializeComponent();
        }
        public string Q1 { get { return q1Answer; } }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var buttons = gboxAnswer1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            q1Answer = buttons.Text;
            EventHandler handler = formQ1_nextClick;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
            this.Close();
        }
    }
}
