using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulsarUI.Controles
{
    public class PulsarUIButton : Button
    {
        private int cornerRadius = 15;
        private Color borderColor;
        private int borderThickness = 10;
        private bool isRoundedCorners;

        public int CornerRadius
        {
            get
            {
                return cornerRadius;
            }

            set
            {
                cornerRadius = value;
                this.Invalidate();
            }
        }
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        public int BorderThickness
        {
            get
            {
                return borderThickness;
            }
            set
            {
                borderThickness = value;
                this.Invalidate();
            }
        }
        public bool IsRoundedCorners
        {
            get
            {
                return isRoundedCorners;
            }
            set
            {
                isRoundedCorners = value;
                this.Invalidate();
            }
        }

        public PulsarUIButton()
        {
            this.Text = "PulsarUI Button";
            this.BackColor = Color.RoyalBlue;
            this.ForeColor = Color.White;
            this.cornerRadius = 15;
            this.borderColor = Color.RoyalBlue;
            this.borderThickness = 10;
            this.FlatStyle = FlatStyle.Flat;
            this.Size = new Size(150, 40);
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width-radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width-radius, rect.Height-radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height-radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF recSurface = new RectangleF(0,0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1,1, this.Width-0.8F, this.Height-1);

            if (isRoundedCorners) // Round Button
            {
                using (GraphicsPath pathSurface=GetFigurePath(recSurface, cornerRadius))
                using (GraphicsPath pathBorder=GetFigurePath(rectBorder, cornerRadius-1F))
                using (Pen penSurface=new Pen(this.Parent.BackColor,2))
                using (Pen penBorder = new Pen(borderColor, borderThickness))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    // Button Surface
                    this.Region = new Region(pathSurface);
                    // Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    // Button Border
                    // Draw control border
                    if (borderThickness >= 1)
                    {
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else // normal button
            {
                // Button Surface
                this.Region = new Region(recSurface);
                // Button Border
                if (borderThickness >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderThickness))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0,0, this.Width-1, this.Height-1);
                    }
                }
            }
        }
    }
}