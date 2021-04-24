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
    public partial class FormQ2 : Form
    {
        string q2Answer;
        
        public event EventHandler formQ2_nextClick;

        public FormQ2()
        {
            InitializeComponent();
        }
        public string Q2 { get { return q2Answer; } }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var buttons = gboxAnswer1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            q2Answer = buttons.Text;
            EventHandler handler = formQ2_nextClick;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
            this.Close();
        }
    }
}
