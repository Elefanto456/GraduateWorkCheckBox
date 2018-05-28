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
    public partial class EditForm : Form
    {

        Sentence sentence = new Sentence();

        public EditForm(MainForm f1)
        {
            InitializeComponent();

        }

        public EditForm(Sentence stn)
        {
            InitializeComponent();

            sentence = stn;

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict = stn.GetGoogleItemsDictionary();

            foreach (KeyValuePair<string, string> kvp in dict)
            {
                if (kvp.Value == "Person")
                {
                    PersonEditBox.AppendText(kvp.Key + Environment.NewLine);
                }

                if (kvp.Value == "Location")
                {
                    LocationEditBox.AppendText(kvp.Key + Environment.NewLine);
                }

                if (kvp.Value == "Organization")
                {
                    LocationEditBox.AppendText(kvp.Key + Environment.NewLine);
                }

                if (kvp.Value == "Other")
                {
                    ArtefactEditBox.AppendText(kvp.Key + Environment.NewLine);
                }

                if (kvp.Value == "WorkOfArt")
                {
                    ArtefactEditBox.AppendText(kvp.Key + Environment.NewLine);
                }

                if (kvp.Value == "ConsumerGood")
                {
                    ArtefactEditBox.AppendText(kvp.Key + Environment.NewLine);
                }

                if (kvp.Value == "Artefact")
                {
                    ArtefactEditBox.AppendText(kvp.Key + Environment.NewLine);
                }
            }

        }

        private void SaveEditBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            string[] newPerson = getNamesFromBox(PersonEditBox);
            string[] newLocation = getNamesFromBox(LocationEditBox);
            string[] newArtefact = getNamesFromBox(ArtefactEditBox);

            for (int i = 0; i < newPerson.Length - 1; i++)
            {
                try
                {
                    dictionary.Add(newPerson[i], "Person");
                }
                catch (ArgumentException)
                {

                }
            }
            for (int i = 0; i < newLocation.Length - 1; i++)
            {
                try
                {
                    dictionary.Add(newLocation[i], "Location");
                }
                catch (ArgumentException)
                {

                }
                
            }
            for (int i = 0; i < newArtefact.Length - 1; i++)
            {
                try
                {
                    dictionary.Add(newArtefact[i], "Artefact");
                }
                catch (ArgumentException)
                {

                }                
            }

            //выполнить метод upd googleDict
            sentence.UpdGoogleItemsDictionary(dictionary);
            Close();
        }

        private string[] getNamesFromBox(RichTextBox richTextBox)
        {
            String[] lines = StringFromRichTextBox(richTextBox).Split('\n');
            return lines;
        }

        private string StringFromRichTextBox(RichTextBox richTextBox)
        {
            return richTextBox.Text;
        }


    }
}
