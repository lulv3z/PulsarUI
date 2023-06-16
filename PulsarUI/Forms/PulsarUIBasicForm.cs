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
    public partial class PulsarUIBasicForm : Form
    {

        private bool controleBar = true;
        private Color backColor = Color.RoyalBlue;
        private Color foreColor = Color.White;
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;

        public bool ControleBar
        {
            get { return controleBar; }
            set
            {
                controleBar = value;
                CheckControleBar();
            }
        }

        public Color BackColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                app_bar.BackColor = backColor;
                app_bar.ForeColor = backColor;
            }
        }

        public Color ForeColor
        {
            get { return foreColor; }
            set
            {
                foreColor = value;
                pulsarUIFormTextLbl.ForeColor = foreColor;
            }
        }

        public PulsarUIBasicForm()
        {
            InitializeComponent();

            pulsarUIFormTextLbl.Text = this.Text;

            this.FormBorderStyle = FormBorderStyle.None;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            CheckControleBar();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            pulsarUIFormTextLbl.Text = this.Text;
        }

        private void CheckControleBar()
        {
            if (controleBar)
            {
                app_bar.Visible = true;
                app_bar.Dock = DockStyle.Top;
            }
            else
            {
                app_bar.Visible = false;
                app_bar.Dock = DockStyle.None;
            }
        }
    }
}
