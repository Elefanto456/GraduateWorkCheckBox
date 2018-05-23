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
    public partial class PresentationForm : Form
    {
        public PresentationForm()
        {
            InitializeComponent();
            SceneNum.Text = "Scene 1";
            PersonInfo.Text = "man";
            LocationInfo.Text = "north, Ropers Gate";
            ArtifactInfo.Text = "horse, bridle";
        }

        private void next_Button (object sender, EventArgs e)
        {

        }

        private void firstScene_Click(object sender, EventArgs e)
        {
            SceneNum.Text = "Scene 1";
            PersonInfo.Text = "man";
            LocationInfo.Text = "north, Ropers Gate";
            ArtifactInfo.Text = "horse, bridle";
            TimeInfo.Text = "";
        }

        private void secondScene_Click(object sender, EventArgs e)
        {
            SceneNum.Text = "Scene 2";
            PersonInfo.Text = "man";
            LocationInfo.Text = "street";
            ArtifactInfo.Text = "horse, roper’s stalls, saddler’s stalls, tanner’s stalls";
            TimeInfo.Text = "late afternoon";
        }

        private void ThirdScene_Click(object sender, EventArgs e)
        {
            SceneNum.Text = "Scene 3";
            PersonInfo.Text = "man";
            LocationInfo.Text = "street";
            ArtifactInfo.Text = "horse, coat";
            TimeInfo.Text = "late afternoon";
        }

        private void fourthScene_Click(object sender, EventArgs e)
        {
            SceneNum.Text = "Scene 4";
            PersonInfo.Text = "man";
            LocationInfo.Text = "street, Old Narakort Inn tavern";
            ArtifactInfo.Text = "horse, hubbub, people";
            TimeInfo.Text = "late afternoon";
        }

        private void fifthScene_Click(object sender, EventArgs e)
        {
            SceneNum.Text = "Scene 5";
            PersonInfo.Text = "man";
            LocationInfo.Text = "street, The Fox tavern";
            ArtifactInfo.Text = "horse";
            TimeInfo.Text = "late afternoon";
        }
    }
}
