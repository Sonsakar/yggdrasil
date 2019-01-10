using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Yggdrasil
{
    public partial class Yggdrasil : Form
    {

        Button[] decisionBtns;
        int decisionCount = 10;
        dynamic[] chars;

        public Yggdrasil()
        {
            InitializeComponent();
        }
        public void loadDecisions()
        {
            int btnWidth = 50;
            int btnHeight = 40;
            int btnGap = 10;
            decisionBtns = new Button[decisionCount];
            int startX = Convert.ToInt32((Width/2) - (Convert.ToDouble(decisionBtns.Length)/2 * btnWidth) - ((Convert.ToDouble(decisionBtns.Length-1))/2 * btnGap));
            for (int i = 0; i < decisionBtns.Length; i++)
            {
                myTabs.TabPages[1].Controls.Add(decisionBtns[i] = new Button());
                decisionBtns[i].Width = btnWidth;
                decisionBtns[i].Height = btnHeight;
                decisionBtns[i].Text = Convert.ToString(i);
                decisionBtns[i].Location = new Point(startX, Height * 30 / 100 + situationLbl.Height + sceneLbl.Height);
                startX += btnWidth + btnGap;
            }
        }

        private void Yggdrasil_Load(object sender, EventArgs e)
        {
            int btnEdge = 60;
            int btnGap = 20;

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

            situationLbl.MaximumSize = new Size(Width * 60 / 100, 0);
            situationLbl.Location = new Point((Width / 2) - situationLbl.Width / 2, Height * 20 / 100 + sceneLbl.Height);

            saveBtn.Size = new Size(btnEdge, btnEdge);
            saveBtn.Location = new Point(Width - btnGap * 3 - btnEdge * 3, btnGap);
            #endregion

            
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
                charBtns[i].ForeColor = 247, 241, 227;
                charBtns[i].Click += new EventHandler(charBtn_Click);
            }
            #endregion

        }
        private void charBtn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            desLbl.Text = chars[Convert.ToInt32(button.Tag)].description;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //Maybe build a fance exit dialog, also with ESC press
            Application.Exit();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            loadDecisions();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            myTabs.SelectedIndex++;
        }
    }
}
