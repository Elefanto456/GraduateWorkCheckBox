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
    public partial class PresentationFormAnotherone : Form
    {
        private string[] proposalsArr;

        TextAnalyze textAnalyze = new TextAnalyze();

        public PresentationFormAnotherone(string text)
        {
            InitializeComponent();
            proposalsArr = TextAnalyze.GetProposals(text);
            for (int i = 0; i < proposalsArr.Length; i++)
            {
                ProposalsCheckBox.Items.Add(proposalsArr[i]);
            }
        }

        private void ProposalsCheckBox_ItemCheck(Object sender, ItemCheckEventArgs e)
        {
            List<string> checkedItems = new List<string>();
            foreach (var item in ProposalsCheckBox.CheckedItems)
                checkedItems.Add(item.ToString());

            if (e.NewValue == CheckState.Checked)
                checkedItems.Add(ProposalsCheckBox.Items[e.Index].ToString());

            foreach (string item in checkedItems)
            {
                
            }
        }

            private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
