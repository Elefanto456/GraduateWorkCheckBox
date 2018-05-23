namespace GraduateWorkWindowsForms
{
    partial class ConsumerGoodEditList
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
            this.ConsumerGoodListEdit = new System.Windows.Forms.RichTextBox();
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
            // ConsumerGoodListEdit
            // 
            this.ConsumerGoodListEdit.Location = new System.Drawing.Point(12, 12);
            this.ConsumerGoodListEdit.Name = "ConsumerGoodListEdit";
            this.ConsumerGoodListEdit.Size = new System.Drawing.Size(180, 176);
            this.ConsumerGoodListEdit.TabIndex = 2;
            this.ConsumerGoodListEdit.Text = "";
            // 
            // ConsumerGoodEditList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(207, 266);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ConsumerGoodListEdit);
            this.Name = "ConsumerGoodEditList";
            this.Text = "ConsumerGoodEditList";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button SaveButton;
        public System.Windows.Forms.RichTextBox ConsumerGoodListEdit;
    }
}