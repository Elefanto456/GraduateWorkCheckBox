namespace GraduateWorkWindowsForms
{
    partial class PersonEditForm
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
            this.PersonListEdit = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PersonListEdit
            // 
            this.PersonListEdit.Location = new System.Drawing.Point(12, 12);
            this.PersonListEdit.Name = "PersonListEdit";
            this.PersonListEdit.Size = new System.Drawing.Size(180, 176);
            this.PersonListEdit.TabIndex = 0;
            this.PersonListEdit.Text = "";
            this.PersonListEdit.TextChanged += new System.EventHandler(this.Person_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 203);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(127, 40);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersonEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(204, 278);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PersonListEdit);
            this.Name = "PersonEditForm";
            this.Text = "PersonEditForm";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.RichTextBox PersonListEdit;
        public System.Windows.Forms.Button SaveButton;
    }
}