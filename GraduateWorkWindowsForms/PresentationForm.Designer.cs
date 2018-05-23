namespace GraduateWorkWindowsForms
{
    partial class PresentationForm
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
            this.SceneNum = new System.Windows.Forms.Label();
            this.firstScene = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PersonInfo = new System.Windows.Forms.TextBox();
            this.LocationInfo = new System.Windows.Forms.TextBox();
            this.ArtifactInfo = new System.Windows.Forms.TextBox();
            this.TimeInfo = new System.Windows.Forms.TextBox();
            this.secondScene = new System.Windows.Forms.Button();
            this.ThirdScene = new System.Windows.Forms.Button();
            this.fourthScene = new System.Windows.Forms.Button();
            this.fifthScene = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SceneNum
            // 
            this.SceneNum.AutoSize = true;
            this.SceneNum.Location = new System.Drawing.Point(367, 34);
            this.SceneNum.Name = "SceneNum";
            this.SceneNum.Size = new System.Drawing.Size(75, 13);
            this.SceneNum.TabIndex = 0;
            this.SceneNum.Text = "SceneChange";
            // 
            // firstScene
            // 
            this.firstScene.Location = new System.Drawing.Point(60, 298);
            this.firstScene.Name = "firstScene";
            this.firstScene.Size = new System.Drawing.Size(106, 38);
            this.firstScene.TabIndex = 9;
            this.firstScene.Text = "1";
            this.firstScene.UseVisualStyleBackColor = true;
            this.firstScene.Click += new System.EventHandler(this.firstScene_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Artefact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Person";
            // 
            // PersonInfo
            // 
            this.PersonInfo.Location = new System.Drawing.Point(123, 87);
            this.PersonInfo.Name = "PersonInfo";
            this.PersonInfo.ReadOnly = true;
            this.PersonInfo.Size = new System.Drawing.Size(626, 20);
            this.PersonInfo.TabIndex = 11;
            // 
            // LocationInfo
            // 
            this.LocationInfo.Location = new System.Drawing.Point(123, 126);
            this.LocationInfo.Name = "LocationInfo";
            this.LocationInfo.ReadOnly = true;
            this.LocationInfo.Size = new System.Drawing.Size(626, 20);
            this.LocationInfo.TabIndex = 12;
            // 
            // ArtifactInfo
            // 
            this.ArtifactInfo.Location = new System.Drawing.Point(123, 168);
            this.ArtifactInfo.Name = "ArtifactInfo";
            this.ArtifactInfo.ReadOnly = true;
            this.ArtifactInfo.Size = new System.Drawing.Size(626, 20);
            this.ArtifactInfo.TabIndex = 13;
            // 
            // TimeInfo
            // 
            this.TimeInfo.Location = new System.Drawing.Point(123, 215);
            this.TimeInfo.Name = "TimeInfo";
            this.TimeInfo.ReadOnly = true;
            this.TimeInfo.Size = new System.Drawing.Size(626, 20);
            this.TimeInfo.TabIndex = 14;
            // 
            // secondScene
            // 
            this.secondScene.Location = new System.Drawing.Point(194, 298);
            this.secondScene.Name = "secondScene";
            this.secondScene.Size = new System.Drawing.Size(106, 38);
            this.secondScene.TabIndex = 15;
            this.secondScene.Text = "2";
            this.secondScene.UseVisualStyleBackColor = true;
            this.secondScene.Click += new System.EventHandler(this.secondScene_Click);
            // 
            // ThirdScene
            // 
            this.ThirdScene.Location = new System.Drawing.Point(336, 298);
            this.ThirdScene.Name = "ThirdScene";
            this.ThirdScene.Size = new System.Drawing.Size(106, 38);
            this.ThirdScene.TabIndex = 16;
            this.ThirdScene.Text = "3";
            this.ThirdScene.UseVisualStyleBackColor = true;
            this.ThirdScene.Click += new System.EventHandler(this.ThirdScene_Click);
            // 
            // fourthScene
            // 
            this.fourthScene.Location = new System.Drawing.Point(481, 298);
            this.fourthScene.Name = "fourthScene";
            this.fourthScene.Size = new System.Drawing.Size(106, 38);
            this.fourthScene.TabIndex = 17;
            this.fourthScene.Text = "4";
            this.fourthScene.UseVisualStyleBackColor = true;
            this.fourthScene.Click += new System.EventHandler(this.fourthScene_Click);
            // 
            // fifthScene
            // 
            this.fifthScene.Location = new System.Drawing.Point(618, 298);
            this.fifthScene.Name = "fifthScene";
            this.fifthScene.Size = new System.Drawing.Size(106, 38);
            this.fifthScene.TabIndex = 18;
            this.fifthScene.Text = "5";
            this.fifthScene.UseVisualStyleBackColor = true;
            this.fifthScene.Click += new System.EventHandler(this.fifthScene_Click);
            // 
            // PresentationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(776, 404);
            this.Controls.Add(this.fifthScene);
            this.Controls.Add(this.fourthScene);
            this.Controls.Add(this.ThirdScene);
            this.Controls.Add(this.secondScene);
            this.Controls.Add(this.TimeInfo);
            this.Controls.Add(this.ArtifactInfo);
            this.Controls.Add(this.LocationInfo);
            this.Controls.Add(this.PersonInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstScene);
            this.Controls.Add(this.SceneNum);
            this.Name = "PresentationForm";
            this.Text = "PresentationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button firstScene;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PersonInfo;
        private System.Windows.Forms.TextBox LocationInfo;
        private System.Windows.Forms.TextBox ArtifactInfo;
        private System.Windows.Forms.TextBox TimeInfo;
        private System.Windows.Forms.Button secondScene;
        private System.Windows.Forms.Button ThirdScene;
        private System.Windows.Forms.Button fourthScene;
        private System.Windows.Forms.Button fifthScene;
        private System.Windows.Forms.Label SceneNum;
    }
}