namespace GraduateWorkWindowsForms
{
    partial class EditForm
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
            this.SaveEditBtn = new System.Windows.Forms.Button();
            this.ArtefactLbl = new System.Windows.Forms.Label();
            this.LocationLbl = new System.Windows.Forms.Label();
            this.PesonLbl = new System.Windows.Forms.Label();
            this.ArtefactEditBox = new System.Windows.Forms.RichTextBox();
            this.LocationEditBox = new System.Windows.Forms.RichTextBox();
            this.PersonEditBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SaveEditBtn
            // 
            this.SaveEditBtn.Location = new System.Drawing.Point(520, 42);
            this.SaveEditBtn.Name = "SaveEditBtn";
            this.SaveEditBtn.Size = new System.Drawing.Size(137, 40);
            this.SaveEditBtn.TabIndex = 19;
            this.SaveEditBtn.Text = "Save";
            this.SaveEditBtn.UseVisualStyleBackColor = true;
            this.SaveEditBtn.Click += new System.EventHandler(this.SaveEditBtn_Click);
            // 
            // ArtefactLbl
            // 
            this.ArtefactLbl.AutoSize = true;
            this.ArtefactLbl.Location = new System.Drawing.Point(407, 15);
            this.ArtefactLbl.Name = "ArtefactLbl";
            this.ArtefactLbl.Size = new System.Drawing.Size(49, 13);
            this.ArtefactLbl.TabIndex = 18;
            this.ArtefactLbl.Text = "Artefacts";
            // 
            // LocationLbl
            // 
            this.LocationLbl.AutoSize = true;
            this.LocationLbl.Location = new System.Drawing.Point(233, 15);
            this.LocationLbl.Name = "LocationLbl";
            this.LocationLbl.Size = new System.Drawing.Size(53, 13);
            this.LocationLbl.TabIndex = 17;
            this.LocationLbl.Text = "Locations";
            // 
            // PesonLbl
            // 
            this.PesonLbl.AutoSize = true;
            this.PesonLbl.Location = new System.Drawing.Point(64, 15);
            this.PesonLbl.Name = "PesonLbl";
            this.PesonLbl.Size = new System.Drawing.Size(45, 13);
            this.PesonLbl.TabIndex = 16;
            this.PesonLbl.Text = "Persons";
            // 
            // ArtefactEditBox
            // 
            this.ArtefactEditBox.Location = new System.Drawing.Point(356, 42);
            this.ArtefactEditBox.Name = "ArtefactEditBox";
            this.ArtefactEditBox.Size = new System.Drawing.Size(151, 193);
            this.ArtefactEditBox.TabIndex = 15;
            this.ArtefactEditBox.Text = "";
            // 
            // LocationEditBox
            // 
            this.LocationEditBox.Location = new System.Drawing.Point(190, 42);
            this.LocationEditBox.Name = "LocationEditBox";
            this.LocationEditBox.Size = new System.Drawing.Size(151, 193);
            this.LocationEditBox.TabIndex = 14;
            this.LocationEditBox.Text = "";
            // 
            // PersonEditBox
            // 
            this.PersonEditBox.Location = new System.Drawing.Point(12, 42);
            this.PersonEditBox.Name = "PersonEditBox";
            this.PersonEditBox.Size = new System.Drawing.Size(151, 193);
            this.PersonEditBox.TabIndex = 13;
            this.PersonEditBox.Text = "";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 251);
            this.Controls.Add(this.SaveEditBtn);
            this.Controls.Add(this.ArtefactLbl);
            this.Controls.Add(this.LocationLbl);
            this.Controls.Add(this.PesonLbl);
            this.Controls.Add(this.ArtefactEditBox);
            this.Controls.Add(this.LocationEditBox);
            this.Controls.Add(this.PersonEditBox);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveEditBtn;
        private System.Windows.Forms.Label ArtefactLbl;
        private System.Windows.Forms.Label LocationLbl;
        private System.Windows.Forms.Label PesonLbl;
        public System.Windows.Forms.RichTextBox ArtefactEditBox;
        public System.Windows.Forms.RichTextBox LocationEditBox;
        public System.Windows.Forms.RichTextBox PersonEditBox;
    }
}