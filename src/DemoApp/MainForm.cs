using System;
using System.Windows.Forms;
using DemoApp.Helpers;

namespace DemoApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnShowTask_Click(object sender, EventArgs e)
        {
        }

        private void btnHideTask_Click(object sender, EventArgs e)
        {
        }

        private void btnSwitchFullScreen_Click(object sender, EventArgs e)
        {
            ClsWin32.SwitchFullScreen(this);
        }
    }
}
