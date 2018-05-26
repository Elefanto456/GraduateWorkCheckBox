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
    public partial class MainForm : Form
    {
        private string[] proposalsArr;
        private List<Sentence> sentences = new List<Sentence>();
        private Sentence forDataUpd = new Sentence();
        private List<string> personList = new List<string>();
        private List<string> locationList = new List<string>();
        private List<string> artefactList = new List<string>();



        TextAnalyze textAnalyze = new TextAnalyze();

        public MainForm()
        {
            InitializeComponent();
        }

        private void TextAnalysisButton_Click(object sender, EventArgs e)
        {
            proposalsArr = TextAnalyze.GetProposals(MainTextBox.Text);
            for (int i = 0; i < proposalsArr.Length; i++)
            {
                ProposalsCheckBox.Items.Add(proposalsArr[i]);
            }

            for (int i = 0; i < proposalsArr.Length; i++)
            {
                sentences.Add(new Sentence(proposalsArr[i]));
            }
            AnalysisStatus.Text = "Done";

        }

        private void PrototypeMakeBtn_Click(object sender, EventArgs e)
        {
            PresentationFormAnotherone presentationForm = new PresentationFormAnotherone(MainTextBox.Text);
            presentationForm.Show();
        }

        private void PersonEditBtn_Click(object sender, EventArgs e)
        {
            PersonEditForm personEditForm = new PersonEditForm(this);
            personEditForm.Show();
        }

        public void ChangeTextInPersonListUpd(string newText)
        {
            PersonBox.Text = newText;
        }

        private void LocationEditBtn_Click(object sender, EventArgs e)
        {
            LocationEditForm locationEditForm = new LocationEditForm(this);
            locationEditForm.Show();
        }

        public void ChangeTextInLocationListUpd(string newText)
        {
            LocationBox.Text = newText;
        }

        ////https://stackoverflow.com/questions/3666682/which-checkedlistbox-event-triggers-after-a-item-is-checked?utm_medium=organic&utm_source=google_rich_qa&utm_campaign=google_rich_qa
        private void ProposalsCheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            List<string> uncheckedItems = new List<string>();
            List<string> checkedItems = new List<string>();

            foreach (var item in ProposalsCheckBox.CheckedItems)
                checkedItems.Add(item.ToString());

            if (e.NewValue == CheckState.Checked)
            {
                checkedItems.Add(ProposalsCheckBox.Items[e.Index].ToString());
            }

            if (e.NewValue == CheckState.Unchecked)
            {
                uncheckedItems.Add(ProposalsCheckBox.Items[e.Index].ToString());

                for (int i = 0; i < checkedItems.Count; i++)
                {
                    for (int j = 0; j < uncheckedItems.Count; j++)
                    {
                        if (checkedItems[i] == uncheckedItems[j])
                        {
                            checkedItems.Remove(checkedItems[i]);
                        }
                    }
                }

            }

            PersonBox.Clear();
            ArtefactBox.Clear();
            LocationBox.Clear();

            foreach (string item in checkedItems)
            {
                for (int i = 0; i < sentences.Count; i++)
                {
                    forDataUpd = sentences[i];

                    if (item == forDataUpd.GetSentence(item))
                    {
                        Dictionary<string, string> dict = new Dictionary<string, string>();
                        dict = forDataUpd.GetGoogleItemsDictionary(item);

                        foreach (KeyValuePair<string, string> kvp in dict)
                        {
                            if (kvp.Value == "Person")
                            {
                                PersonBox.AppendText(kvp.Key + Environment.NewLine);
                            }

                            if (kvp.Value == "Location")
                            {
                                LocationBox.AppendText(kvp.Key + Environment.NewLine);

                            if (kvp.Value == "Organization")
                            {
                                LocationBox.AppendText(kvp.Key + Environment.NewLine);
                            }

                            if (kvp.Value == "Other")
                            {
                                ArtefactBox.AppendText(kvp.Key + Environment.NewLine);
                            }

                            if (kvp.Value == "WorkOfArt")
                            {
                                ArtefactBox.AppendText(kvp.Key + Environment.NewLine);
                            }

                            if (kvp.Value == "ConsumerGood")
                            {
                                ArtefactBox.AppendText(kvp.Key + Environment.NewLine);
                            }
                        }
                    }
                }
            }
        }
    }
}