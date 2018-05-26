namespace GraduateWorkWindowsForms
{
    partial class PresentationFormAnotherone
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProposalsLbl = new System.Windows.Forms.Label();
            this.SceneMakeBtn = new System.Windows.Forms.Button();
            this.ProposalsCheckBox = new System.Windows.Forms.CheckedListBox();
            this.ArtefactLbl = new System.Windows.Forms.Label();
            this.LocationLbl = new System.Windows.Forms.Label();
            this.PesonLbl = new System.Windows.Forms.Label();
            this.UpdArtefactBox = new System.Windows.Forms.RichTextBox();
            this.UpdLocationBox = new System.Windows.Forms.RichTextBox();
            this.UpdPersonBox = new System.Windows.Forms.RichTextBox();
            this.ArtifactInfo = new System.Windows.Forms.TextBox();
            this.LocationInfo = new System.Windows.Forms.TextBox();
            this.PersonInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SceneNum = new System.Windows.Forms.Label();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProposalsLbl
            // 
            this.ProposalsLbl.AutoSize = true;
            this.ProposalsLbl.Location = new System.Drawing.Point(21, 19);
            this.ProposalsLbl.Name = "ProposalsLbl";
            this.ProposalsLbl.Size = new System.Drawing.Size(53, 13);
            this.ProposalsLbl.TabIndex = 1;
            this.ProposalsLbl.Text = "Proposals";
            // 
            // SceneMakeBtn
            // 
            this.SceneMakeBtn.Location = new System.Drawing.Point(15, 279);
            this.SceneMakeBtn.Name = "SceneMakeBtn";
            this.SceneMakeBtn.Size = new System.Drawing.Size(147, 27);
            this.SceneMakeBtn.TabIndex = 2;
            this.SceneMakeBtn.Text = "Scene Make";
            this.SceneMakeBtn.UseVisualStyleBackColor = true;
            this.SceneMakeBtn.Click += new System.EventHandler(this.SceneMakeBtn_Click);
            // 
            // ProposalsCheckBox
            // 
            this.ProposalsCheckBox.FormattingEnabled = true;
            this.ProposalsCheckBox.Location = new System.Drawing.Point(15, 46);
            this.ProposalsCheckBox.Name = "ProposalsCheckBox";
            this.ProposalsCheckBox.Size = new System.Drawing.Size(478, 214);
            this.ProposalsCheckBox.TabIndex = 3;
            this.ProposalsCheckBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ProposalsCheckBox_ItemCheck);
            // 
            // ArtefactLbl
            // 
            this.ArtefactLbl.AutoSize = true;
            this.ArtefactLbl.Location = new System.Drawing.Point(911, 19);
            this.ArtefactLbl.Name = "ArtefactLbl";
            this.ArtefactLbl.Size = new System.Drawing.Size(49, 13);
            this.ArtefactLbl.TabIndex = 13;
            this.ArtefactLbl.Text = "Artefacts";
            // 
            // LocationLbl
            // 
            this.LocationLbl.AutoSize = true;
            this.LocationLbl.Location = new System.Drawing.Point(737, 19);
            this.LocationLbl.Name = "LocationLbl";
            this.LocationLbl.Size = new System.Drawing.Size(53, 13);
            this.LocationLbl.TabIndex = 12;
            this.LocationLbl.Text = "Locations";
            // 
            // PesonLbl
            // 
            this.PesonLbl.AutoSize = true;
            this.PesonLbl.Location = new System.Drawing.Point(568, 19);
            this.PesonLbl.Name = "PesonLbl";
            this.PesonLbl.Size = new System.Drawing.Size(45, 13);
            this.PesonLbl.TabIndex = 11;
            this.PesonLbl.Text = "Persons";
            // 
            // UpdArtefactBox
            // 
            this.UpdArtefactBox.Location = new System.Drawing.Point(853, 46);
            this.UpdArtefactBox.Name = "UpdArtefactBox";
            this.UpdArtefactBox.Size = new System.Drawing.Size(151, 214);
            this.UpdArtefactBox.TabIndex = 10;
            this.UpdArtefactBox.Text = "";
            // 
            // UpdLocationBox
            // 
            this.UpdLocationBox.Location = new System.Drawing.Point(684, 46);
            this.UpdLocationBox.Name = "UpdLocationBox";
            this.UpdLocationBox.Size = new System.Drawing.Size(151, 214);
            this.UpdLocationBox.TabIndex = 9;
            this.UpdLocationBox.Text = "";
            // 
            // UpdPersonBox
            // 
            this.UpdPersonBox.Location = new System.Drawing.Point(516, 46);
            this.UpdPersonBox.Name = "UpdPersonBox";
            this.UpdPersonBox.Size = new System.Drawing.Size(151, 214);
            this.UpdPersonBox.TabIndex = 8;
            this.UpdPersonBox.Text = "";
            // 
            // ArtifactInfo
            // 
            this.ArtifactInfo.BackColor = System.Drawing.SystemColors.Window;
            this.ArtifactInfo.Location = new System.Drawing.Point(222, 461);
            this.ArtifactInfo.Name = "ArtifactInfo";
            this.ArtifactInfo.ReadOnly = true;
            this.ArtifactInfo.Size = new System.Drawing.Size(626, 20);
            this.ArtifactInfo.TabIndex = 22;
            // 
            // LocationInfo
            // 
            this.LocationInfo.BackColor = System.Drawing.SystemColors.Window;
            this.LocationInfo.Location = new System.Drawing.Point(222, 419);
            this.LocationInfo.Name = "LocationInfo";
            this.LocationInfo.ReadOnly = true;
            this.LocationInfo.Size = new System.Drawing.Size(626, 20);
            this.LocationInfo.TabIndex = 21;
            // 
            // PersonInfo
            // 
            this.PersonInfo.BackColor = System.Drawing.SystemColors.Window;
            this.PersonInfo.Location = new System.Drawing.Point(222, 380);
            this.PersonInfo.Name = "PersonInfo";
            this.PersonInfo.ReadOnly = true;
            this.PersonInfo.Size = new System.Drawing.Size(626, 20);
            this.PersonInfo.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Person";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Artefact";
            // 
            // SceneNum
            // 
            this.SceneNum.AutoSize = true;
            this.SceneNum.Location = new System.Drawing.Point(513, 341);
            this.SceneNum.Name = "SceneNum";
            this.SceneNum.Size = new System.Drawing.Size(78, 13);
            this.SceneNum.TabIndex = 15;
            this.SceneNum.Text = "Scene Number";
            // 
            // PrevBtn
            // 
            this.PrevBtn.Location = new System.Drawing.Point(24, 413);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(99, 30);
            this.PrevBtn.TabIndex = 24;
            this.PrevBtn.Text = "Prev";
            this.PrevBtn.UseVisualStyleBackColor = true;
            // 
            // NextBtn
            // 
            this.NextBtn.Location = new System.Drawing.Point(874, 413);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(99, 30);
            this.NextBtn.TabIndex = 25;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            // 
            // PresentationFormAnotherone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 712);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.PrevBtn);
            this.Controls.Add(this.ArtifactInfo);
            this.Controls.Add(this.LocationInfo);
            this.Controls.Add(this.PersonInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SceneNum);
            this.Controls.Add(this.ArtefactLbl);
            this.Controls.Add(this.LocationLbl);
            this.Controls.Add(this.PesonLbl);
            this.Controls.Add(this.UpdArtefactBox);
            this.Controls.Add(this.UpdLocationBox);
            this.Controls.Add(this.UpdPersonBox);
            this.Controls.Add(this.ProposalsCheckBox);
            this.Controls.Add(this.SceneMakeBtn);
            this.Controls.Add(this.ProposalsLbl);
            this.Name = "PresentationFormAnotherone";
            this.Text = "PresentationFormAnotherone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ProposalsLbl;
        private System.Windows.Forms.Button SceneMakeBtn;
        private System.Windows.Forms.CheckedListBox ProposalsCheckBox;
        private System.Windows.Forms.Label ArtefactLbl;
        private System.Windows.Forms.Label LocationLbl;
        private System.Windows.Forms.Label PesonLbl;
        public System.Windows.Forms.RichTextBox UpdArtefactBox;
        public System.Windows.Forms.RichTextBox UpdLocationBox;
        public System.Windows.Forms.RichTextBox UpdPersonBox;
        private System.Windows.Forms.TextBox ArtifactInfo;
        private System.Windows.Forms.TextBox LocationInfo;
        private System.Windows.Forms.TextBox PersonInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SceneNum;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Button NextBtn;
    }
}