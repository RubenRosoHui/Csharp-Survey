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
    public partial class FormQ3 : Form
    {
        public event EventHandler formQ3_nextClick;
        string q3Answer;
        public FormQ3()
        {
            InitializeComponent();
        }
        public string Q3{ get { return q3Answer; }}

        private void btnNext_Click(object sender, EventArgs e)
        {
            var buttons = gboxAnswer1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            q3Answer = buttons.Text;
            EventHandler handler = formQ3_nextClick;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
            this.Close();
        }
    }
}
