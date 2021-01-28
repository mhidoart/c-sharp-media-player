using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
            panelSideMenu.BackColor = Color.FromArgb(11, 7, 17);
            panelPlayBack.BackColor = Color.FromArgb(23 , 21, 32);
            panelChildForms.BackColor = Color.FromArgb(32, 30, 45);
        }
        private void hideSubmenu()
        {
            if(panelMediaSubMenu.Visible == true)
            {
                panelMediaSubMenu.Visible = false;
            }
            if (panelPlaylistSubMenu.Visible == true)
            {
                panelPlaylistSubMenu.Visible = false;
            }
            if (panelToolsSubMenu.Visible == true)
            {
                panelToolsSubMenu.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == true)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = true;
            }
        }
        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }
        #region MediaSubMenu


        private void button2_Click(object sender, EventArgs e)
        {
            //code ...
            openChildForm(new Form2());
            hideSubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //code ...

            hideSubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //code ...

            hideSubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //code ...

            hideSubmenu();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPlaylistSubMenu);
        }
        #endregion

        #region PlaylistSubMenu
        private void button9_Click(object sender, EventArgs e)
        {
            //code ...

            hideSubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //code ...

            hideSubmenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //code ...

            hideSubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //code ...

            hideSubmenu();
        }

        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            //code ...
            openChildForm(new Form3());
            hideSubmenu();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }
        #endregion

        #region Tools
        private void button15_Click(object sender, EventArgs e)
        {
            //code ...

            hideSubmenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //code ...

            hideSubmenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //code ...

            hideSubmenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //code ...

            hideSubmenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //code ...

            hideSubmenu();
        }
        #endregion
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForms.Controls.Add(childForm);
            panelChildForms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void panelPlayBack_Paint(object sender, PaintEventArgs e)
        {

        }
    }
   
}
