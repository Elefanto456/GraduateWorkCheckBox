namespace GraduateWorkWindowsForms
{
    partial class Form1
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
            this.FullText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.PersonList = new System.Windows.Forms.RichTextBox();
            this.LocationList = new System.Windows.Forms.RichTextBox();
            this.OrganisationList = new System.Windows.Forms.RichTextBox();
            this.OtherList = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ConsumerGoodList = new System.Windows.Forms.RichTextBox();
            this.PersonListUpd = new System.Windows.Forms.RichTextBox();
            this.LocationListUpd = new System.Windows.Forms.RichTextBox();
            this.ArtefactList = new System.Windows.Forms.RichTextBox();
            this.TimeVal = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ShowPrototype = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FullText
            // 
            this.FullText.Location = new System.Drawing.Point(16, 19);
            this.FullText.Name = "FullText";
            this.FullText.Size = new System.Drawing.Size(636, 175);
            this.FullText.TabIndex = 0;
            this.FullText.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Analysis Text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.analizeText_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "Person Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.personEdit_click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(139, 412);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 32);
            this.button7.TabIndex = 8;
            this.button7.Text = "Location Edit";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.locationEdit_click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(270, 412);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 32);
            this.button8.TabIndex = 8;
            this.button8.Text = "Artefact Edit";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.artifactEdit_click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(398, 412);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 32);
            this.button9.TabIndex = 8;
            this.button9.Text = "TIme";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.timeEdit_click);
            // 
            // PersonList
            // 
            this.PersonList.Location = new System.Drawing.Point(13, 233);
            this.PersonList.Name = "PersonList";
            this.PersonList.Size = new System.Drawing.Size(121, 163);
            this.PersonList.TabIndex = 20;
            this.PersonList.Text = "";
            // 
            // LocationList
            // 
            this.LocationList.Location = new System.Drawing.Point(140, 233);
            this.LocationList.Name = "LocationList";
            this.LocationList.Size = new System.Drawing.Size(121, 163);
            this.LocationList.TabIndex = 21;
            this.LocationList.Text = "";
            // 
            // OrganisationList
            // 
            this.OrganisationList.Location = new System.Drawing.Point(267, 233);
            this.OrganisationList.Name = "OrganisationList";
            this.OrganisationList.Size = new System.Drawing.Size(121, 163);
            this.OrganisationList.TabIndex = 22;
            this.OrganisationList.Text = "";
            // 
            // OtherList
            // 
            this.OtherList.Location = new System.Drawing.Point(394, 233);
            this.OtherList.Name = "OtherList";
            this.OtherList.Size = new System.Drawing.Size(121, 163);
            this.OtherList.TabIndex = 23;
            this.OtherList.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Organisation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Other";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Consumer Good";
            // 
            // ConsumerGoodList
            // 
            this.ConsumerGoodList.Location = new System.Drawing.Point(521, 233);
            this.ConsumerGoodList.Name = "ConsumerGoodList";
            this.ConsumerGoodList.Size = new System.Drawing.Size(121, 163);
            this.ConsumerGoodList.TabIndex = 24;
            this.ConsumerGoodList.Text = "";
            // 
            // PersonListUpd
            // 
            this.PersonListUpd.Location = new System.Drawing.Point(12, 469);
            this.PersonListUpd.Name = "PersonListUpd";
            this.PersonListUpd.Size = new System.Drawing.Size(121, 163);
            this.PersonListUpd.TabIndex = 30;
            this.PersonListUpd.Text = "";
            this.PersonListUpd.TextChanged += new System.EventHandler(this.PersonListUpd_TextChanged);
            // 
            // LocationListUpd
            // 
            this.LocationListUpd.Location = new System.Drawing.Point(140, 469);
            this.LocationListUpd.Name = "LocationListUpd";
            this.LocationListUpd.Size = new System.Drawing.Size(121, 163);
            this.LocationListUpd.TabIndex = 31;
            this.LocationListUpd.Text = "";
            // 
            // ArtefactList
            // 
            this.ArtefactList.Location = new System.Drawing.Point(267, 469);
            this.ArtefactList.Name = "ArtefactList";
            this.ArtefactList.Size = new System.Drawing.Size(121, 163);
            this.ArtefactList.TabIndex = 32;
            this.ArtefactList.Text = "";
            // 
            // TimeVal
            // 
            this.TimeVal.Location = new System.Drawing.Point(397, 469);
            this.TimeVal.Name = "TimeVal";
            this.TimeVal.Size = new System.Drawing.Size(121, 163);
            this.TimeVal.TabIndex = 33;
            this.TimeVal.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Artefact";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Location";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Person";
            // 
            // ShowPrototype
            // 
            this.ShowPrototype.Location = new System.Drawing.Point(12, 645);
            this.ShowPrototype.Name = "ShowPrototype";
            this.ShowPrototype.Size = new System.Drawing.Size(175, 37);
            this.ShowPrototype.TabIndex = 38;
            this.ShowPrototype.Text = "Show Scenario Prototype";
            this.ShowPrototype.UseVisualStyleBackColor = true;
            this.ShowPrototype.Click += new System.EventHandler(this.showPrototype);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 696);
            this.Controls.Add(this.ShowPrototype);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TimeVal);
            this.Controls.Add(this.ArtefactList);
            this.Controls.Add(this.LocationListUpd);
            this.Controls.Add(this.PersonListUpd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsumerGoodList);
            this.Controls.Add(this.OtherList);
            this.Controls.Add(this.OrganisationList);
            this.Controls.Add(this.LocationList);
            this.Controls.Add(this.PersonList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FullText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox FullText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.RichTextBox PersonList;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.RichTextBox PersonListUpd;
        public System.Windows.Forms.RichTextBox LocationListUpd;
        public System.Windows.Forms.RichTextBox ArtefactList;
        public System.Windows.Forms.RichTextBox TimeVal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ShowPrototype;
        public System.Windows.Forms.RichTextBox LocationList;
        public System.Windows.Forms.RichTextBox OrganisationList;
        public System.Windows.Forms.RichTextBox OtherList;
        public System.Windows.Forms.RichTextBox ConsumerGoodList;
    }
}

