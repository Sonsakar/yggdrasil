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
        int decisionCount = 3;

        public Yggdrasil()
        {
            InitializeComponent();
        }
        public void loadDecisions()
        {
            int btnWidth = 50;
            int btnHeight = 40;
            decisionBtns = new Button[decisionCount];
            for (int i = 0; i < decisionBtns.Length; i++)
            {
                myTabs.TabPages[2].Controls.Add(decisionBtns[i] = new Button());
                decisionBtns[i].Width = btnWidth;
                decisionBtns[i].Height = btnHeight;

                if (decisionCount % 2 == 0)
                {

                } else {
                    
                    decisionBtns[i].Location = new Point(((storyPage.Width / 2) - btnWidth / 2), ((Height / 2) - btnHeight / 2));
                }
            }
        }

        private void Yggdrasil_Load(object sender, EventArgs e)
        {
            exitBtn.BringToFront();
            muteBtn.BringToFront();
            sceneLbl.Location = new Point((storyPage.Width / 2) - sceneLbl.Width / 2, 100);
            situationLbl.Location = new Point((storyPage.Width / 2) - situationLbl.Width / 2, 120 + sceneLbl.Height);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            loadDecisions();
        }
    }
}
