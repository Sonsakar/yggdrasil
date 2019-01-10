using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yggdrasil
{
    public partial class Yggdrasil : Form
    {

        Button[] decisionBtns;
        int decisionCount = 10;

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
                myTabs.TabPages[2].Controls.Add(decisionBtns[i] = new Button());
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

            //Tabs

            myTabs.Size = new Size(Width + 8, Height + 26);
            myTabs.Location = new Point(-4, -22);

            sceneLbl.MaximumSize = new Size(Width * 60 / 100, 0);
            sceneLbl.Location = new Point((Width / 2) - sceneLbl.Width / 2, Height * 15 / 100);

            situationLbl.MaximumSize = new Size(Width * 60 / 100, 0);
            situationLbl.Location = new Point((Width / 2) - situationLbl.Width / 2, Height * 20 / 100 + sceneLbl.Height);


            saveBtn.Size = new Size(btnEdge, btnEdge);
            saveBtn.Location = new Point(Width - btnGap * 3 - btnEdge * 3, btnGap);

            
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

        private void button1_Click(object sender, EventArgs e)
        {
            myTabs.SelectedIndex++;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            myTabs.SelectedIndex--;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            myTabs.SelectedIndex++;
        }
    }
}
