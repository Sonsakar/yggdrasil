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
            this.selectTab = new System.Windows.Forms.TabPage();
            this.charTab = new System.Windows.Forms.TabPage();
            this.storyPage = new System.Windows.Forms.TabPage();
            this.saveBtn = new System.Windows.Forms.Button();
            this.sceneLbl = new System.Windows.Forms.Label();
            this.situationLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.muteBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.myTabs.SuspendLayout();
            this.charTab.SuspendLayout();
            this.storyPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // myTabs
            // 
            this.myTabs.Controls.Add(this.selectTab);
            this.myTabs.Controls.Add(this.charTab);
            this.myTabs.Controls.Add(this.storyPage);
            this.myTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTabs.Location = new System.Drawing.Point(0, 0);
            this.myTabs.Name = "myTabs";
            this.myTabs.SelectedIndex = 0;
            this.myTabs.Size = new System.Drawing.Size(1023, 607);
            this.myTabs.TabIndex = 2;
            // 
            // selectTab
            // 
            this.selectTab.Location = new System.Drawing.Point(4, 22);
            this.selectTab.Name = "selectTab";
            this.selectTab.Padding = new System.Windows.Forms.Padding(3);
            this.selectTab.Size = new System.Drawing.Size(1015, 581);
            this.selectTab.TabIndex = 0;
            this.selectTab.Text = "selectTab";
            this.selectTab.UseVisualStyleBackColor = true;
            // 
            // charTab
            // 
            this.charTab.Controls.Add(this.button1);
            this.charTab.Location = new System.Drawing.Point(4, 22);
            this.charTab.Name = "charTab";
            this.charTab.Padding = new System.Windows.Forms.Padding(3);
            this.charTab.Size = new System.Drawing.Size(1015, 581);
            this.charTab.TabIndex = 1;
            this.charTab.Text = "charTab";
            this.charTab.UseVisualStyleBackColor = true;
            // 
            // storyPage
            // 
            this.storyPage.Controls.Add(this.saveBtn);
            this.storyPage.Controls.Add(this.sceneLbl);
            this.storyPage.Controls.Add(this.situationLbl);
            this.storyPage.Location = new System.Drawing.Point(4, 22);
            this.storyPage.Name = "storyPage";
            this.storyPage.Size = new System.Drawing.Size(1015, 581);
            this.storyPage.TabIndex = 2;
            this.storyPage.Text = "storyPage";
            this.storyPage.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(754, 3);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.charTab.ResumeLayout(false);
            this.storyPage.ResumeLayout(false);
            this.storyPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl myTabs;
        private System.Windows.Forms.TabPage selectTab;
        private System.Windows.Forms.TabPage charTab;
        private System.Windows.Forms.TabPage storyPage;
        private System.Windows.Forms.Label sceneLbl;
        private System.Windows.Forms.Label situationLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button muteBtn;
        private System.Windows.Forms.Button button1;
    }
}

