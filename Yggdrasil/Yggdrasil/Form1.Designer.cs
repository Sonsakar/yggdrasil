namespace Yggdrasil
{
    partial class Yggdrasil
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
            this.myTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.storyPage = new System.Windows.Forms.TabPage();
            this.saveBtn = new System.Windows.Forms.Button();
            this.sceneLbl = new System.Windows.Forms.Label();
            this.situationLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.muteBtn = new System.Windows.Forms.Button();
            this.myTabs.SuspendLayout();
            this.storyPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // myTabs
            // 
            this.myTabs.Controls.Add(this.tabPage1);
            this.myTabs.Controls.Add(this.tabPage2);
            this.myTabs.Controls.Add(this.storyPage);
            this.myTabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.myTabs.Location = new System.Drawing.Point(0, 140);
            this.myTabs.Name = "myTabs";
            this.myTabs.SelectedIndex = 0;
            this.myTabs.Size = new System.Drawing.Size(1023, 467);
            this.myTabs.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1015, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1015, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // storyPage
            // 
            this.storyPage.Controls.Add(this.saveBtn);
            this.storyPage.Controls.Add(this.sceneLbl);
            this.storyPage.Controls.Add(this.situationLbl);
            this.storyPage.Location = new System.Drawing.Point(4, 22);
            this.storyPage.Name = "storyPage";
            this.storyPage.Size = new System.Drawing.Size(1015, 441);
            this.storyPage.TabIndex = 2;
            this.storyPage.Text = "storyPage";
            this.storyPage.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(770, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "button2";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // sceneLbl
            // 
            this.sceneLbl.AutoSize = true;
            this.sceneLbl.Location = new System.Drawing.Point(460, 150);
            this.sceneLbl.Name = "sceneLbl";
            this.sceneLbl.Size = new System.Drawing.Size(35, 13);
            this.sceneLbl.TabIndex = 2;
            this.sceneLbl.Text = "label1";
            // 
            // situationLbl
            // 
            this.situationLbl.AutoSize = true;
            this.situationLbl.Location = new System.Drawing.Point(460, 192);
            this.situationLbl.Name = "situationLbl";
            this.situationLbl.Size = new System.Drawing.Size(35, 13);
            this.situationLbl.TabIndex = 3;
            this.situationLbl.Text = "label2";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(936, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // muteBtn
            // 
            this.muteBtn.Location = new System.Drawing.Point(855, 12);
            this.muteBtn.Name = "muteBtn";
            this.muteBtn.Size = new System.Drawing.Size(75, 23);
            this.muteBtn.TabIndex = 4;
            this.muteBtn.Text = "MUTE";
            this.muteBtn.UseVisualStyleBackColor = true;
            // 
            // Yggdrasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 607);
            this.Controls.Add(this.myTabs);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.muteBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Yggdrasil";
            this.Text = "Yggdrasil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Yggdrasil_Load);
            this.myTabs.ResumeLayout(false);
            this.storyPage.ResumeLayout(false);
            this.storyPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl myTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage storyPage;
        private System.Windows.Forms.Label sceneLbl;
        private System.Windows.Forms.Label situationLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button muteBtn;
    }
}

