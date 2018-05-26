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
        //private string[] proposalsArr;


        TextAnalyze textAnalyze = new TextAnalyze();
        private Sentence sent;
        private List<Sentence> sentences = new List<Sentence>();
        private Sentence forDataUpd = new Sentence();
        private Sentence forSceneMake = new Sentence();

        public PresentationFormAnotherone(MainForm f1)
        {
            InitializeComponent();
            int n = f1.GetSentencesCount();
            sentences = f1.GetSentences();
            for (int i = 0; i < n; i++)
            {
                sent = sentences[i];
                ProposalsCheckBox.Items.Add(sent.GetSentence());
            }

            /*
            proposalsArr = TextAnalyze.GetProposals(text);
            for (int i = 0; i < proposalsArr.Length; i++)
            {
                ProposalsCheckBox.Items.Add(proposalsArr[i]);
            }
            */
        }

        private void ProposalsCheckBox_ItemCheck(Object sender, ItemCheckEventArgs e)
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

            UpdPersonBox.Clear();
            UpdArtefactBox.Clear();
            UpdLocationBox.Clear();

            foreach (string item in checkedItems)
            {
                for (int i = 0; i < sentences.Count; i++)
                {
                    forDataUpd = sentences[i];

                    if (item == forDataUpd.GetSentence(item))
                    {
                        Dictionary<string, string> dict = new Dictionary<string, string>();
                        dict = forDataUpd.GetGoogleItemsDictionary();

                        foreach (KeyValuePair<string, string> kvp in dict)
                        {
                            if (kvp.Value == "Person")
                            {
                                UpdPersonBox.AppendText(kvp.Key + Environment.NewLine);
                            }

                            if (kvp.Value == "Location")
                            {
                                UpdLocationBox.AppendText(kvp.Key + Environment.NewLine);
                            }

                            if (kvp.Value == "Organization")
                            {
                                UpdLocationBox.AppendText(kvp.Key + Environment.NewLine);
                            }

                            if (kvp.Value == "Other")
                            {
                                UpdArtefactBox.AppendText(kvp.Key + Environment.NewLine);
                            }

                            if (kvp.Value == "WorkOfArt")
                            {
                                UpdArtefactBox.AppendText(kvp.Key + Environment.NewLine);
                            }

                            if (kvp.Value == "ConsumerGood")
                            {
                                UpdArtefactBox.AppendText(kvp.Key + Environment.NewLine);
                            }
                        }
                    }
                }
            }
        }

        private void SceneMakeBtn_Click(object sender, EventArgs e)
        {
            List<string> checkedItems = new List<string>();

            foreach (var item in ProposalsCheckBox.CheckedItems)
                checkedItems.Add(item.ToString());

            List<Sentence> sentencesForAdd = new List<Sentence>();

            for (int i = 0; i < sentences.Count; i++)
            {
                for (int j = 0; j < checkedItems.Count; j++)
                {
                    string str = sentences[i].GetSentence();
                    if (checkedItems[j] == str)
                    {
                        sentencesForAdd.Add(sentences[i]);
                    }

                }
            }

            Scene scene = new Scene(sentencesForAdd, 1);
            //List<Sentence> list = new List<Sentence>();
            foreach (var itm in scene.GetSceneList())
            {
                foreach (string item in checkedItems)
            {
                
                    if (item == itm.GetSentence())
                    {
                        Dictionary<string, string> dict = new Dictionary<string, string>();
                        dict = forSceneMake.GetGoogleItemsDictionary(item);

                        for (int i = 0; i < dict.Count; i++)
                        {
                            foreach (KeyValuePair<string, string> kvp in dict)
                            {
                                if (kvp.Value == "Person")
                                {
                                    PersonInfo.Text = PersonInfo + kvp.Key + ", ";
                                }

                                if (kvp.Value == "Location")
                                {
                                    LocationInfo.Text = LocationInfo + kvp.Key + ", ";
                                }

                                if (kvp.Value == "Organization")
                                {
                                    LocationInfo.Text = LocationInfo + kvp.Key + ", ";
                                }

                                if (kvp.Value == "Other")
                                {
                                    ArtifactInfo.Text = ArtifactInfo + kvp.Key + ", ";
                                }

                                if (kvp.Value == "WorkOfArt")
                                {
                                    ArtifactInfo.Text = ArtifactInfo + kvp.Key + ", ";
                                }

                                if (kvp.Value == "ConsumerGood")
                                {
                                    ArtifactInfo.Text = ArtifactInfo + kvp.Key + ", ";
                                }
                            }
                        }
                    }
                }
                



                

            }
        }
    }
}

