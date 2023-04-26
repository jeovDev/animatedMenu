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
        public Form1()
        {
            InitializeComponent();
            List<Label> menu = new List<Label>() { menuDashboard, menuHome, menuAbout,menuSettings,menuLogout};
            menuEventHandler(menu);
        }

        private void menuEventHandler(List<Label> Menu) {
            foreach (var menu in Menu) {
                
                menu.MouseHover += Menu_MouseHover;
                menu.MouseLeave += Menu_MouseLeave;
            }
        }

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
    }
}
