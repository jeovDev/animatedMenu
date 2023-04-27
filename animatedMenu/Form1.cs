using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animatedMenu
{
    public partial class Form1 : Form
    {
        List<Label> menu;
        public Form1()
        {
            InitializeComponent();
            menu = new List<Label>() { menuDashboard, menuHome, menuAbout,menuSettings,menuLogout};
            menuEventHandler(menu);
           
        }

        private void menuEventHandler(List<Label> Menu) {
            foreach (var menu in Menu) {
                menu.Hide();
                menu.MouseHover += Menu_MouseHover;
                menu.MouseLeave += Menu_MouseLeave;
            }
        }
        private int targetY = 25;
        private int animationStep =1;
        private int currentButtonIndex = 0;
        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.FromArgb(19, 48, 78);
        }

        private void Menu_MouseHover(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.FromArgb(36, 68, 106);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuTimer_Tick(object sender, EventArgs e)
        {
            Label button = menu[currentButtonIndex];

            if (button.Top < targetY)
            {
                button.Top += animationStep;
                button.Show();
            }
            else if (button.Top > targetY)
            {
                button.Top -= animationStep;
            }
            else
            {
                currentButtonIndex++;

                if (currentButtonIndex >= menu.Count)
                {
                  
                    menuTimer.Stop();
                }
                else
                {
                  
                    menuTimer.Start();
                }
            }
        }
    }
}
