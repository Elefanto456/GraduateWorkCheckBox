namespace GraduateWorkWindowsForms
{
    partial class ArtifactEditForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.OrganisationList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 203);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(127, 40);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OrganisationList
            // 
            this.OrganisationList.Location = new System.Drawing.Point(12, 12);
            this.OrganisationList.Name = "OrganisationList";
            this.OrganisationList.Size = new System.Drawing.Size(180, 176);
            this.OrganisationList.TabIndex = 2;
            this.OrganisationList.Text = "";
            // 
            // ArtifactEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(210, 268);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OrganisationList);
            this.Name = "ArtifactEditForm";
            this.Text = "OrganisationEditForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.RichTextBox OrganisationList;
    }
}