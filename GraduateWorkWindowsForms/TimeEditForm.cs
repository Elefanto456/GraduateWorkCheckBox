using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraduateWorkWindowsForms
{
    public partial class TimeEditForm : Form
    {
        private delegate void ChangeTextBox(string nText);
        private event ChangeTextBox ChangeTextBox1;

        public TimeEditForm(Form1 f1)
        {
            InitializeComponent();
            ChangeTextBox1 += f1.ChangeTextInTimeVal;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ChangeTextBox1(OtherListEdit.Text);
        }
    }
}
