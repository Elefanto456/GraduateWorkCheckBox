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
    public partial class Form1 : Form
    {
        private string workOfArt;

        private Dictionary<string, string> forAnalyze = new Dictionary<string, string>();
        //private string[] proposalsArr;

        TextAnalyze textAnalyze = new TextAnalyze();

        public Form1()
        {
            InitializeComponent();
        }

        private void personEdit_click(object sender, EventArgs e)
        {
            //PersonEditForm personEditForm = new PersonEditForm(this);
            //personEditForm.Show();
        }

        private void locationEdit_click(object sender, EventArgs e)
        {
            //LocationEditForm locationEditForm = new LocationEditForm(this);
            //locationEditForm.Show();
        }

        private void artifactEdit_click(object sender, EventArgs e)
        {
            ArtifactEditForm organisationEditForm = new ArtifactEditForm(this);
            organisationEditForm.Show();
        }

        private void timeEdit_click(object sender, EventArgs e)
        {
            TimeEditForm otherEditForm = new TimeEditForm(this);
            otherEditForm.Show();
        }

        private void analizeText_click(object sender, EventArgs e)
        {
            //string[] personType = { "man", "people", "stranger", "ropers", "saddlers", "tanners", "bridle" };
            //PersonListView.Items.AddRange(personType);          
            
            forAnalyze = textAnalyze.AnalyzeEntitiesFromText(FullText.Text);

            foreach (KeyValuePair<string, string> kvp in forAnalyze)
            {
                if (kvp.Value == "Other")
                    OtherList.Text = OtherList.Text + kvp.Key + "\n";
                if (kvp.Value == "Person")
                    PersonList.Text = PersonList.Text + kvp.Key + "\n";
                if (kvp.Value == "WorkOfArt")
                    workOfArt = workOfArt + kvp.Key + "\n";
                if (kvp.Value == "Location")
                    LocationList.Text = LocationList.Text + kvp.Key + "\n";
                if (kvp.Value == "ConsumerGood")
                    ConsumerGoodList.Text = ConsumerGoodList.Text + kvp.Key + "\n";
                if (kvp.Value == "Organization")
                    OrganisationList.Text = OrganisationList.Text + kvp.Key + "\n";              
            }
            
        }

        public void ChangeTextInPersonListUpd(string newText)
        {
            PersonListUpd.Text = newText;
        }

        public void ChangeTextInLocationListUpd(string newText)
        {
            LocationListUpd.Text = newText;
        }

        public void ChangeTextInArtifactUpd(string newText)
        {
            ArtefactList.Text = newText;
        }

        public void ChangeTextInTimeVal(string newText)
        {
            TimeVal.Text = newText;
        }

        private void showPrototype (object sender, EventArgs e)
        {
            PresentationForm presentationForm = new PresentationForm();
            presentationForm.Show();

            /*
            proposalsArr = TextAnalyze.GetProposals(FullText.Text);
            for (int i = 0; i < proposalsArr.Length; i++)
            {
                ProposalsBox.Text = ProposalsBox.Text + proposalsArr[i] + "\n";
            }
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void OtherListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PersonListUpd_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
