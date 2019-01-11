using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Yggdrasil
{
    public partial class Yggdrasil : Form
    {

        Button[] decisionBtns;
        dynamic[] chars;
        dynamic myChar;
        Story curStory;
        Color light = new Color();
        Color decisionColor = new Color();
        Color fade = new Color();
        Font main = new Font("Book Antiqua", 15.75f);
        List<int> storyIds = new List<int>();
        int timerNum = 0;

        public Yggdrasil()
        {
            InitializeComponent();
        }
        public void loadStory()
        {
            storyIds.Add(curStory.ID);
            sceneLbl.Text = curStory.scenery;
            sceneLbl.Location = new Point((Width / 2) - sceneLbl.Width / 2, Height * 15 / 100);
            situationLbl.Text = curStory.situation;
            situationLbl.Location = new Point((Width / 2) - situationLbl.Width / 2, Height * 20 / 100 + sceneLbl.Height);

            int decisionCount = curStory.decisions.Length;

            int btnWidth = Width * 10 / 100;
            int btnHeight = Height * 5 / 100;
            Size btnMin = new Size(btnWidth, btnHeight);
            Size btnMax = new Size(btnWidth * 2, btnHeight);
            int btnGap = 12;
            decisionBtns = new Button[decisionCount];
            int offset = 0;
            for (int i = 0; i < decisionBtns.Length; i++)
            {
                myTabs.TabPages[1].Controls.Add(decisionBtns[i] = new Button());
                decisionBtns[i].MinimumSize = btnMin;
                decisionBtns[i].MaximumSize = btnMax;
                decisionBtns[i].AutoSize = true;
                decisionBtns[i].ForeColor = decisionColor;
                decisionBtns[i].FlatStyle = FlatStyle.Flat;
                decisionBtns[i].FlatAppearance.BorderSize = 0;
                decisionBtns[i].Font = main;
                decisionBtns[i].Text = curStory.decisions[i].text;
                decisionBtns[i].Click += new EventHandler(decisionBtn_Click);
                offset += decisionBtns[i].Width;
            }
            int startX = Convert.ToInt32((Width / 2) - ( offset / 2 ) - ( (decisionBtns.Length -1) * btnGap / 2));
            Console.WriteLine(offset);
            for (int i = 0; i < decisionBtns.Length; i++)
            {              
                decisionBtns[i].Location = new Point(startX, Height * 30 / 100 + situationLbl.Height + sceneLbl.Height);
                startX += decisionBtns[i].Width + btnGap;
            }
        }
        private void decisionBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            //fadeOutTimer.Enabled = true;
            //fancy jormun stuff
        }
        private void Yggdrasil_Load(object sender, EventArgs e)
        {
            int btnEdge = 60;
            int btnGap = 20;

            light = Color.FromArgb(247, 241, 227);
            decisionColor = Color.FromArgb(204, 142, 53);

            exitBtn.Size = new Size(btnEdge, btnEdge);
            exitBtn.BringToFront();
            exitBtn.Location = new Point(Width - btnGap - btnEdge, btnGap);

            muteBtn.Size = new Size(btnEdge, btnEdge);
            muteBtn.BringToFront();
            muteBtn.Location = new Point(Width - btnGap * 2 - btnEdge * 2, btnGap);

            #region Tabs

            myTabs.Size = new Size(Width + 8, Height + 26);
            myTabs.Location = new Point(-4, -22);

            #region StoryTab
            sceneLbl.MaximumSize = new Size(Width * 60 / 100, 0);
            sceneLbl.Location = new Point((Width / 2) - sceneLbl.Width / 2, Height * 15 / 100);
            sceneLbl.Parent = myTabs.TabPages[1];

            situationLbl.MaximumSize = new Size(Width * 60 / 100, 0);
            situationLbl.Location = new Point((Width / 2) - situationLbl.Width / 2, Height * 20 / 100 + sceneLbl.Height);

            saveBtn.Size = new Size(btnEdge, btnEdge);
            saveBtn.Location = new Point(Width - btnGap * 3 - btnEdge * 3, btnGap);
            #endregion

            #region CharacterTab
            //Character Buttons
            int charCount = 0;
            Size charBtnSize = new Size(200, 50);
            int charBtnGap = 20;
            for (int i = 0; i < 100; i++)
            {
                if(File.Exists("files/char/" + i + ".json"))
                    charCount++;
            }
            Button[] charBtns = new Button[charCount];
            chars = new dynamic[charCount];
            for (int i = 0; i < charCount; i++)
            {
                chars[i] = JsonConvert.DeserializeObject(File.ReadAllText("files/char/" + i + ".json"));
                myTabs.TabPages[0].Controls.Add(charBtns[i] = new Button());
                charBtns[i].Size = charBtnSize;              
                charBtns[i].Location = new Point( Width - Width * 90 / 100, i * (charBtnGap + charBtnSize.Height) + 150);
                charBtns[i].Tag = i;
                charBtns[i].Text = chars[i].name;
                charBtns[i].ForeColor = light;
                charBtns[i].Click += new EventHandler(charBtn_Click);
            }
            #endregion
           
            #endregion

        }
        private void charBtn_Click(object sender, EventArgs e)
        {
            startBtn.Enabled = true;
            Button button = sender as Button;
            myChar = chars[Convert.ToInt32(button.Tag)];

            desLbl.Text = myChar.description;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //Maybe build a fance exit dialog, also with ESC press
            Application.Exit();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            myTabs.SelectedIndex++;
            curStory = JsonConvert.DeserializeObject<Story>(File.ReadAllText("files/story/" + myChar.startstory + ".json"));
            loadStory();
        }

        private void fadeOutTimer_Tick(object sender, EventArgs e)
        {
            fade = Color.FromArgb(255 - timerNum, 247, 241, 227);
            sceneLbl.ForeColor = fade;
            situationLbl.ForeColor = fade;
            timerNum++;
            if (timerNum == 256)
            {
                timerNum = 0;
                fadeOutTimer.Enabled = false;
            }
        }

        private void fadeInTimer_Tick(object sender, EventArgs e)
        {
            fade = Color.FromArgb(timerNum, 247, 241, 227);
            sceneLbl.ForeColor = fade;
            situationLbl.ForeColor = fade;
            timerNum++;
            if (timerNum == 256)
            {
                timerNum = 0;
                fadeInTimer.Enabled = false;
            }
        }
    }
}