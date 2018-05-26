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
            this.button1 = new System.Windows.Forms.Button();
            this.ProposalsCheckBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // ProposalsLbl
            // 
            this.ProposalsLbl.AutoSize = true;
            this.ProposalsLbl.Location = new System.Drawing.Point(25, 21);
            this.ProposalsLbl.Name = "ProposalsLbl";
            this.ProposalsLbl.Size = new System.Drawing.Size(53, 13);
            this.ProposalsLbl.TabIndex = 1;
            this.ProposalsLbl.Text = "Proposals";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProposalsCheckBox
            // 
            this.ProposalsCheckBox.FormattingEnabled = true;
            this.ProposalsCheckBox.Location = new System.Drawing.Point(28, 48);
            this.ProposalsCheckBox.Name = "ProposalsCheckBox";
            this.ProposalsCheckBox.Size = new System.Drawing.Size(500, 229);
            this.ProposalsCheckBox.TabIndex = 3;
            this.ProposalsCheckBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ProposalsCheckBox_ItemCheck);
            // 
            // PresentationFormAnotherone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.ProposalsCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProposalsLbl);
            this.Name = "PresentationFormAnotherone";
            this.Text = "PresentationFormAnotherone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ProposalsLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox ProposalsCheckBox;
    }
}