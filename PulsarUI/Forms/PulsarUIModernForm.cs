using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulsarUI.Forms
{
    public partial class PulsarUIModernForm : Form
    {
        #region PulsarUI-WindowVar
        bool sidebarExpand = false;
        private bool isDragging = false;
        private int xOffset;
        private int yOffset;

        enum CurrentWindowState
        {
            Maximized,
            Normal
        }

        CurrentWindowState currentWindowState = CurrentWindowState.Normal;

        #endregion PulsarUI-WindowVar

        public PulsarUIModernForm()
        {
            InitializeComponent();
        }

        #region PulsarUI-Window
        private void app_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void app_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 45)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 195)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void app_nav_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            xOffset = e.X;
            yOffset = e.Y;
        }

        private void app_nav_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Die neue Position des Formulars berechnen, indem xOffset und yOffset verwendet werden
                int newX = this.Left + e.X - xOffset;
                int newY = this.Top + e.Y - yOffset;

                // Das Formular an die neue Position verschieben
                this.Location = new Point(newX, newY);
            }
        }

        private void app_nav_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void app_nav_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (currentWindowState == CurrentWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                currentWindowState = CurrentWindowState.Normal;
            }
            else if (currentWindowState == CurrentWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                currentWindowState = CurrentWindowState.Maximized;
            }
        }

        #endregion PulsarUI-Window

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startup_Tick(object sender, EventArgs e)
        {
            sidebar.Width = 45;
            startup.Stop();
        }
    }
}
