﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using NAudio.Wave;
using System.Collections.Generic;
using Yggdrasil.Properties;

namespace Yggdrasil
{
    public partial class Yggdrasil : Form
    {
        #region Var Area
        Button[] decisionBtns;
        dynamic[] chars;
        dynamic myChar; //skills: vig, end, str, dex, per, luck, int, mag
        Story curStory;
        Color light = new Color();
        Color decisionColor = new Color();
        Color outline = new Color();
        Color fade = new Color();
        Color dfade = new Color();
        Font main = new Font("Book Antiqua", 15.75f);
        List<int> storyIds = new List<int>();
        bool mute = false;
        int volume = 90;
        int lr, lg, lb, dr, dg, db;    
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        #endregion

        public Yggdrasil()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams //prevents flickering of form
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public void loadStory() //loads story text and generates decision buttons
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
                decisionBtns[i].BackColor = Color.Transparent;              
                decisionBtns[i].FlatStyle = FlatStyle.Flat;
                decisionBtns[i].FlatAppearance.BorderSize = 0;
                decisionBtns[i].FlatAppearance.MouseOverBackColor = Color.Transparent;
                decisionBtns[i].FlatAppearance.MouseDownBackColor = Color.Transparent;
                decisionBtns[i].Font = main;
                decisionBtns[i].Text = curStory.decisions[i].text;
                decisionBtns[i].Click += new EventHandler(decisionBtn_Click);
                offset += decisionBtns[i].Width;
            }
            int startX = Convert.ToInt32((Width / 2) - ( offset / 2 ) - ( (decisionBtns.Length -1) * btnGap / 2));
            for (int i = 0; i < decisionBtns.Length; i++)
            {              
                decisionBtns[i].Location = new Point(startX, Height * 70 / 100);
                startX += decisionBtns[i].Width + btnGap;
            }
        }

        #region Generated Button Click Events
        private void decisionBtn_Click(object sender, EventArgs e) //event when decision button is clicked
        {
            Button button = sender as Button;
            if(!(fadeOutTimer.Enabled || fadeInTimer.Enabled)) fadeOutTimer.Enabled = true;
        }

        private void charBtn_Click(object sender, EventArgs e) //updates specific info on character selection screen
        {
            startBtn.Enabled = true;
            startBtn.Visible = true;
            Button button = sender as Button;
            myChar = chars[Convert.ToInt32(button.Tag)];
            //skills: vig, end, str, dex, per, luck, int, mag
            desLbl.Text = myChar.description;
            skillLbl.Text = "\n\nDieser Charakter hat folgende Attribute:\n\nVitalität:          " +
                myChar.skills[0] + "\nAusdauer:           " + myChar.skills[1] + "\nStärke:             " + myChar.skills[2] +
                "\nGeschicklichkeit:   " + myChar.skills[3] + "\nWahrnehmung:        " + myChar.skills[4] +
                "\nGlück:              " + myChar.skills[5] + "\nIntelligenz:        " + myChar.skills[6] +
                "\nMagie:              " + myChar.skills[7];
        }
        #endregion

        private void Yggdrasil_Load(object sender, EventArgs e) //initializes often used variables and generates GUI elements
        {
            int btnEdge = 60;
            int btnGap = 20;

            lr = 247;
            lg = 241;
            lb = 227;
            light = Color.FromArgb(lr, lg, lb);
            dr = 204;
            dg = 142;
            db = 53;
            decisionColor = Color.FromArgb(dr, dg, db);
            outline = Color.FromArgb(255, 121, 63);

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
            Size rightSpan = new Size(Width * 50 / 100, 0);
            int startY = Height * 15 / 100;
            desLbl.Location = new Point(Width * 40 / 100, startY);
            desLbl.MaximumSize = rightSpan;
            skillLbl.MaximumSize = rightSpan;
            startBtn.Size = new Size(Width * 50 / 100, Height * 5 / 100);
            int charCount = 0;
            Size charBtnSize = new Size(Width * 20 / 100, Height * 5 / 100);
            int charBtnGap = 15;
            
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
                charBtns[i].Location = new Point( Width - Width * 90 / 100, i * (charBtnGap + charBtnSize.Height) + startY);
                charBtns[i].Tag = i;
                charBtns[i].Text = chars[i].name;
                charBtns[i].FlatStyle = FlatStyle.Flat;
                charBtns[i].FlatAppearance.BorderColor = outline;
                charBtns[i].Font = main;
                charBtns[i].ForeColor = light;
                charBtns[i].BackColor = Color.Transparent;
                charBtns[i].FlatAppearance.MouseOverBackColor = Color.Transparent;
                charBtns[i].FlatAppearance.MouseDownBackColor = Color.Transparent;
                charBtns[i].Click += new EventHandler(charBtn_Click);
            }

            skillLbl.Location = new Point(desLbl.Location.X, Height * 30 / 100);
            startBtn.Location = new Point(skillLbl.Location.X, Height * 70 / 100);
            
            #endregion

            #endregion

            #region Audio
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
                outputDevice.Volume = volume / 100f;
            }
            if (audioFile == null)
            {
                audioFile = new AudioFileReader("files/sound/menu.mp3");
                outputDevice.Init(audioFile);
            }
            outputDevice.Play();
            #endregion
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args) //cleans the audio player
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
        }
       
        private void startBtn_Click(object sender, EventArgs e) //starts story with selected character
        {
            myTabs.SelectedIndex++;
            curStory = JsonConvert.DeserializeObject<Story>(File.ReadAllText("files/story/" + myChar.startstory + ".json"));
            loadStory();
        }

        #region Control Buttons
        private void exitBtn_Click(object sender, EventArgs e) //closes application
        {
            //Maybe build a fance exit dialog, also with ESC press
            Application.Exit();
        }

        private void saveBtn_Click(object sender, EventArgs e) //saves game progress
        {
            //save to local file
        }
        #endregion

        #region Text and Button fade out
        private void fadeOutTimer_Tick(object sender, EventArgs e) //fades out color/graphic
        {
            if (lr > 0 || dr > 0) { lr -= 8; dr -= 8; }              
            if (lg > 0 || dg > 0) { lg -= 8; dg -= 8; }
            if (lb > 0 || db > 0) { lb -= 8; db -= 5; }
            if (lr < 0) lr = 0;
            if (lg < 0) lg = 0;
            if (lb < 0) lb = 0;
            if (dr < 0) dr = 0;
            if (dg < 0) dg = 0;
            if (db < 0) db = 0;

            fade = Color.FromArgb(lr, lg, lb);
            dfade = Color.FromArgb(dr, dg, db);
            sceneLbl.ForeColor = fade;
            situationLbl.ForeColor = fade;
            for (int i = 0; i < curStory.decisions.Length; i++)
            {
                decisionBtns[i].ForeColor = dfade;
            }
            if (lr == 0 && lg == 0 && lb == 0 && dr == 0 && dg == 0 && db == 0)
            {
                fadeOutTimer.Enabled = false;
                //change Text (jormun stuff)
                fadeInTimer.Enabled = true;
            }
        }

        private void fadeInTimer_Tick(object sender, EventArgs e) //fades in color/graphic
        {
            if (lr < 247 || dr < 204) { lr += 8; dr += 8; }
            if (lg < 241 || dg < 142) { lg += 8; dg += 8; }
            if (lb < 227 || db < 53) { lb += 8; db += 5; }
            if (lr > 247) lr = 247;
            if (lg > 241) lg = 241;
            if (lb > 227) lb = 227;
            if (dr > 204) dr = 204;
            if (dg > 142) dg = 142;
            if (db > 53) db = 53;
            fade = Color.FromArgb(lr, lg, lb);
            dfade = Color.FromArgb(dr, dg, db);
            sceneLbl.ForeColor = fade;
            situationLbl.ForeColor = fade;

            for (int i = 0; i < curStory.decisions.Length; i++) //curStory already changed at this point
            {
                decisionBtns[i].ForeColor = dfade;
            }
            if (lr == 247 && lg == 241 && lb == 227 && dr == 204 && dg == 142 && db == 53)
            {
                fadeInTimer.Enabled = false;
            }
        }
        #endregion

        #region Mute Control
        private void muteBtn_Click(object sender, EventArgs e) //mutes or plays sound
        {
            mute = !mute;
            muteTimer.Enabled = true;
            if (mute)
                muteBtn.BackgroundImage = Resources.mute;
            else
                muteBtn.BackgroundImage = Resources.speaker;
        }

        private void muteTimer_Tick(object sender, EventArgs e) //fades out sound
        {
            if(mute)
            {
                volume--;
                outputDevice.Volume = volume / 100f;
            }
            else
            {
                volume++;
                outputDevice.Volume = volume / 100f;
            }
            if(volume == 0 || volume == 90)
                muteTimer.Enabled = false;
        }
        #endregion
    }
}