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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yggdrasil));
            this.myTabs = new System.Windows.Forms.TabControl();
            this.selectTab = new System.Windows.Forms.TabPage();
            this.startBtn = new System.Windows.Forms.Button();
            this.desLbl = new System.Windows.Forms.Label();
            this.storyPage = new System.Windows.Forms.TabPage();
            this.saveBtn = new System.Windows.Forms.Button();
            this.sceneLbl = new System.Windows.Forms.Label();
            this.situationLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.muteBtn = new System.Windows.Forms.Button();
            this.fadeInTimer = new System.Windows.Forms.Timer(this.components);
            this.fadeOutTimer = new System.Windows.Forms.Timer(this.components);
            this.myTabs.SuspendLayout();
            this.selectTab.SuspendLayout();
            this.storyPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // myTabs
            // 
            this.myTabs.Controls.Add(this.selectTab);
            this.myTabs.Controls.Add(this.storyPage);
            this.myTabs.Location = new System.Drawing.Point(12, 93);
            this.myTabs.Name = "myTabs";
            this.myTabs.SelectedIndex = 0;
            this.myTabs.Size = new System.Drawing.Size(977, 514);
            this.myTabs.TabIndex = 2;
            // 
            // selectTab
            // 
            this.selectTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.selectTab.Controls.Add(this.startBtn);
            this.selectTab.Controls.Add(this.desLbl);
            this.selectTab.Location = new System.Drawing.Point(4, 22);
            this.selectTab.Name = "selectTab";
            this.selectTab.Padding = new System.Windows.Forms.Padding(3);
            this.selectTab.Size = new System.Drawing.Size(969, 488);
            this.selectTab.TabIndex = 0;
            this.selectTab.Text = "selectTab";
            // 
            // startBtn
            // 
            this.startBtn.Enabled = false;
            this.startBtn.Location = new System.Drawing.Point(728, 377);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // desLbl
            // 
            this.desLbl.AutoSize = true;
            this.desLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.desLbl.Location = new System.Drawing.Point(648, 156);
            this.desLbl.Name = "desLbl";
            this.desLbl.Size = new System.Drawing.Size(35, 13);
            this.desLbl.TabIndex = 1;
            this.desLbl.Text = "label1";
            // 
            // storyPage
            // 
            this.storyPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.storyPage.Controls.Add(this.saveBtn);
            this.storyPage.Controls.Add(this.sceneLbl);
            this.storyPage.Controls.Add(this.situationLbl);
            this.storyPage.Location = new System.Drawing.Point(4, 22);
            this.storyPage.Name = "storyPage";
            this.storyPage.Size = new System.Drawing.Size(969, 488);
            this.storyPage.TabIndex = 2;
            this.storyPage.Text = "storyPage";
            // 
            // saveBtn
            // 
            this.saveBtn.BackgroundImage = global::Yggdrasil.Properties.Resources.save;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveBtn.Location = new System.Drawing.Point(758, 5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 75);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // sceneLbl
            // 
            this.sceneLbl.AutoSize = true;
            this.sceneLbl.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sceneLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.sceneLbl.Location = new System.Drawing.Point(159, 67);
            this.sceneLbl.MaximumSize = new System.Drawing.Size(700, 0);
            this.sceneLbl.Name = "sceneLbl";
            this.sceneLbl.Size = new System.Drawing.Size(674, 130);
            this.sceneLbl.TabIndex = 2;
            this.sceneLbl.Text = resources.GetString("sceneLbl.Text");
            this.sceneLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // situationLbl
            // 
            this.situationLbl.AutoSize = true;
            this.situationLbl.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situationLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.situationLbl.Location = new System.Drawing.Point(159, 232);
            this.situationLbl.MaximumSize = new System.Drawing.Size(700, 0);
            this.situationLbl.Name = "situationLbl";
            this.situationLbl.Size = new System.Drawing.Size(665, 78);
            this.situationLbl.TabIndex = 3;
            this.situationLbl.Text = "Lorem ipsum dolor sit amet, nihil eirmod ex mea, cu qui adhuc iudico. Porro assum" +
    " evertitur eum et, in mei debitis conceptam intellegam, percipitur dissentiunt t" +
    "e ius. ";
            this.situationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.BackgroundImage = global::Yggdrasil.Properties.Resources.exit;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(936, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 75);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // muteBtn
            // 
            this.muteBtn.BackgroundImage = global::Yggdrasil.Properties.Resources.speaker;
            this.muteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.muteBtn.FlatAppearance.BorderSize = 0;
            this.muteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muteBtn.Location = new System.Drawing.Point(845, 12);
            this.muteBtn.Name = "muteBtn";
            this.muteBtn.Size = new System.Drawing.Size(75, 75);
            this.muteBtn.TabIndex = 4;
            this.muteBtn.UseVisualStyleBackColor = true;
            // 
            // fadeInTimer
            // 
            this.fadeInTimer.Tick += new System.EventHandler(this.fadeInTimer_Tick);
            // 
            // fadeOutTimer
            // 
            this.fadeOutTimer.Interval = 10;
            this.fadeOutTimer.Tick += new System.EventHandler(this.fadeOutTimer_Tick);
            // 
            // Yggdrasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1023, 607);
            this.Controls.Add(this.myTabs);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.muteBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Yggdrasil";
            this.Text = "Yggdrasil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Yggdrasil_Load);
            this.myTabs.ResumeLayout(false);
            this.selectTab.ResumeLayout(false);
            this.selectTab.PerformLayout();
            this.storyPage.ResumeLayout(false);
            this.storyPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl myTabs;
        private System.Windows.Forms.TabPage selectTab;
        private System.Windows.Forms.TabPage storyPage;
        private System.Windows.Forms.Label situationLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button muteBtn;
        private System.Windows.Forms.Label sceneLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label desLbl;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Timer fadeInTimer;
        private System.Windows.Forms.Timer fadeOutTimer;
    }
}

