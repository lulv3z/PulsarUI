using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PulsarUI.Forms
{
    public class PulsarUIForm : Form
    {
        private bool allowResize = true;

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;

        public bool AllowResize
        {
            get { return allowResize; }
            set { allowResize = value; this.Invalidate(); }
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public PulsarUIForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Text = "PulsarUI Form";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        protected override void OnResize(EventArgs e)
        {
            if (allowResize)
            {
                this.MaximumSize = Size.Empty;
                this.MinimumSize = Size.Empty;
            }
            else
            {
                this.MinimumSize = this.Size;
                this.MaximumSize = this.Size;
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                if (m.Result.ToInt32() == HT_CAPTION)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCHITTEST, HT_CAPTION, 0);
                }
            }
        }
    }

    public class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PulsarUIForm pulsarUIForm = new PulsarUIForm();
            Application.Run(pulsarUIForm);
        }
    }
}
