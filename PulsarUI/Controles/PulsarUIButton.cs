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
    // Benutzerdefinierte Klasse PulsarUIButton, die von der Button-Klasse erbt
    public class PulsarUIButton : Button
    {
        private int cornerRadius; // Radius für abgerundete Ecken
        private Color borderColor; // Farbe des Rahmens
        private int borderThickness; // Dicke des Rahmens
        private bool isRoundedCorners; // Gibt an, ob der Button abgerundete Ecken hat

        // Eigenschaften für den Radius der abgerundeten Ecken
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

        // Eigenschaften für die Farbe des Rahmens
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

        // Eigenschaften für die Dicke des Rahmens
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

        // Eigenschaften für abgerundete Ecken
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

        // Konstruktor für den PulsarUIButton
        public PulsarUIButton()
        {
            this.Text = "PulsarUI Button"; // Standardtext des Buttons
            this.BackColor = Color.RoyalBlue; // Hintergrundfarbe des Buttons
            this.ForeColor = Color.White; // Vordergrundfarbe des Buttons (Textfarbe)
            this.cornerRadius = 40; // Standardwert für den Radius der abgerundeten Ecken
            this.borderColor = Color.RoyalBlue; // Standardfarbe des Rahmens
            this.borderThickness = 0; // Standarddicke des Rahmens
            this.FlatStyle = FlatStyle.Flat; // Flacher Stil für den Button
            this.Size = new Size(150, 40); // Standardgröße des Buttons
        }

        // Methode, um einen GraphicsPath für abgerundete Ecken zu erhalten
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        // Überschreiben der OnPaint-Methode, um das Aussehen des Buttons anzupassen
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF recSurface = new RectangleF(0, 0, this.Width, this.Height); // Fläche des Buttons
            RectangleF rectBorder = new RectangleF(0, 0, this.Width - 1, this.Height - 1); // Rahmen des Buttons

            if (isRoundedCorners) // Abgerundeter Button
            {
                using (GraphicsPath pathSurface = GetFigurePath(recSurface, cornerRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, cornerRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderThickness))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    // Button-Oberfläche
                    this.Region = new Region(pathSurface);
                    // Zeichne Oberflächenrahmen für HD-Ergebnis
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    // Button-Rahmen
                    // Zeichne Rahmen des Steuerelements
                    if (borderThickness >= 1)
                    {
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else // Normaler Button
            {
                // Button-Oberfläche
                this.Region = new Region(recSurface);
                // Button-Rahmen
                if (borderThickness >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderThickness))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
    }
}
