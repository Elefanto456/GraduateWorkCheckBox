namespace GraduateWorkWindowsForms
{
    partial class MainForm
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
            this.MainTextBox = new System.Windows.Forms.RichTextBox();
            this.TextAnalysisButton = new System.Windows.Forms.Button();
            this.PersonBox = new System.Windows.Forms.RichTextBox();
            this.LocationBox = new System.Windows.Forms.RichTextBox();
            this.ArtefactBox = new System.Windows.Forms.RichTextBox();
            this.PesonLbl = new System.Windows.Forms.Label();
            this.LocationLbl = new System.Windows.Forms.Label();
            this.ArtefactLbl = new System.Windows.Forms.Label();
            this.ProposalsCheckBox = new System.Windows.Forms.CheckedListBox();
            this.PrototypeMakeBtn = new System.Windows.Forms.Button();
            this.AnalysisStatus = new System.Windows.Forms.Label();
            this.EditItemsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainTextBox
            // 
            this.MainTextBox.Location = new System.Drawing.Point(14, 18);
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.Size = new System.Drawing.Size(518, 178);
            this.MainTextBox.TabIndex = 0;
            this.MainTextBox.Text = "";
            // 
            // TextAnalysisButton
            // 
            this.TextAnalysisButton.Location = new System.Drawing.Point(538, 18);
            this.TextAnalysisButton.Name = "TextAnalysisButton";
            this.TextAnalysisButton.Size = new System.Drawing.Size(137, 41);
            this.TextAnalysisButton.TabIndex = 1;
            this.TextAnalysisButton.Text = "Analyze the text";
            this.TextAnalysisButton.UseVisualStyleBackColor = true;
            this.TextAnalysisButton.Click += new System.EventHandler(this.TextAnalysisButton_Click);
            // 
            // PersonBox
            // 
            this.PersonBox.Location = new System.Drawing.Point(17, 477);
            this.PersonBox.Name = "PersonBox";
            this.PersonBox.Size = new System.Drawing.Size(151, 193);
            this.PersonBox.TabIndex = 2;
            this.PersonBox.Text = "";
            // 
            // LocationBox
            // 
            this.LocationBox.Location = new System.Drawing.Point(195, 477);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(151, 193);
            this.LocationBox.TabIndex = 3;
            this.LocationBox.Text = "";
            // 
            // ArtefactBox
            // 
            this.ArtefactBox.Location = new System.Drawing.Point(361, 477);
            this.ArtefactBox.Name = "ArtefactBox";
            this.ArtefactBox.Size = new System.Drawing.Size(151, 193);
            this.ArtefactBox.TabIndex = 4;
            this.ArtefactBox.Text = "";
            // 
            // PesonLbl
            // 
            this.PesonLbl.AutoSize = true;
            this.PesonLbl.Location = new System.Drawing.Point(69, 450);
            this.PesonLbl.Name = "PesonLbl";
            this.PesonLbl.Size = new System.Drawing.Size(45, 13);
            this.PesonLbl.TabIndex = 5;
            this.PesonLbl.Text = "Persons";
            // 
            // LocationLbl
            // 
            this.LocationLbl.AutoSize = true;
            this.LocationLbl.Location = new System.Drawing.Point(238, 450);
            this.LocationLbl.Name = "LocationLbl";
            this.LocationLbl.Size = new System.Drawing.Size(53, 13);
            this.LocationLbl.TabIndex = 6;
            this.LocationLbl.Text = "Locations";
            // 
            // ArtefactLbl
            // 
            this.ArtefactLbl.AutoSize = true;
            this.ArtefactLbl.Location = new System.Drawing.Point(412, 450);
            this.ArtefactLbl.Name = "ArtefactLbl";
            this.ArtefactLbl.Size = new System.Drawing.Size(49, 13);
            this.ArtefactLbl.TabIndex = 7;
            this.ArtefactLbl.Text = "Artefacts";
            // 
            // ProposalsCheckBox
            // 
            this.ProposalsCheckBox.FormattingEnabled = true;
            this.ProposalsCheckBox.Location = new System.Drawing.Point(16, 219);
            this.ProposalsCheckBox.Name = "ProposalsCheckBox";
            this.ProposalsCheckBox.Size = new System.Drawing.Size(516, 214);
            this.ProposalsCheckBox.TabIndex = 8;
            this.ProposalsCheckBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ProposalsCheckBox_ItemCheck);
            // 
            // PrototypeMakeBtn
            // 
            this.PrototypeMakeBtn.Location = new System.Drawing.Point(538, 477);
            this.PrototypeMakeBtn.Name = "PrototypeMakeBtn";
            this.PrototypeMakeBtn.Size = new System.Drawing.Size(137, 40);
            this.PrototypeMakeBtn.TabIndex = 12;
            this.PrototypeMakeBtn.Text = "Make Prorotype";
            this.PrototypeMakeBtn.UseVisualStyleBackColor = true;
            this.PrototypeMakeBtn.Click += new System.EventHandler(this.PrototypeMakeBtn_Click);
            // 
            // AnalysisStatus
            // 
            this.AnalysisStatus.AutoSize = true;
            this.AnalysisStatus.Location = new System.Drawing.Point(544, 272);
            this.AnalysisStatus.Name = "AnalysisStatus";
            this.AnalysisStatus.Size = new System.Drawing.Size(0, 13);
            this.AnalysisStatus.TabIndex = 13;
            // 
            // EditItemsBtn
            // 
            this.EditItemsBtn.Location = new System.Drawing.Point(538, 219);
            this.EditItemsBtn.Name = "EditItemsBtn";
            this.EditItemsBtn.Size = new System.Drawing.Size(137, 41);
            this.EditItemsBtn.TabIndex = 14;
            this.EditItemsBtn.Text = "Edit Item";
            this.EditItemsBtn.UseVisualStyleBackColor = true;
            this.EditItemsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 699);
            this.Controls.Add(this.EditItemsBtn);
            this.Controls.Add(this.AnalysisStatus);
            this.Controls.Add(this.PrototypeMakeBtn);
            this.Controls.Add(this.ProposalsCheckBox);
            this.Controls.Add(this.ArtefactLbl);
            this.Controls.Add(this.LocationLbl);
            this.Controls.Add(this.PesonLbl);
            this.Controls.Add(this.ArtefactBox);
            this.Controls.Add(this.LocationBox);
            this.Controls.Add(this.PersonBox);
            this.Controls.Add(this.TextAnalysisButton);
            this.Controls.Add(this.MainTextBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MainTextBox;
        private System.Windows.Forms.Button TextAnalysisButton;
        private System.Windows.Forms.Label PesonLbl;
        private System.Windows.Forms.Label LocationLbl;
        private System.Windows.Forms.Label ArtefactLbl;
        private System.Windows.Forms.CheckedListBox ProposalsCheckBox;
        private System.Windows.Forms.Button PrototypeMakeBtn;
        public System.Windows.Forms.RichTextBox PersonBox;
        public System.Windows.Forms.RichTextBox LocationBox;
        public System.Windows.Forms.RichTextBox ArtefactBox;
        private System.Windows.Forms.Label AnalysisStatus;
        private System.Windows.Forms.Button EditItemsBtn;
    }
}