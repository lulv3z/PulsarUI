using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PulsarUI.Properties;

namespace PulsarUI.Controles
{
    public class PulsarUIControleButton : Button
    {
        private int cornerRadius = 15; // Radius der abgerundeten Ecken
        private Color borderColor; // Farbe des Rahmens
        private int borderThickness = 10; // Dicke des Rahmens
        private bool isRoundedCorners; // Gibt an, ob die Ecken abgerundet sind
        public enum ControleType // Enum für den Typ des Steuerelements
        {
            Close, // Schließen
            Maximize, // Maximieren
            Minimize // Minimieren
        }

        public enum Style // Enum für den Stil des Steuerelements
        {
            Win10Color // Win10-Farbstil
        }

        Style style;
        public Style ControleButtonStyle
        {
            get
            {
                return style;
            }
            set
            {
                style = value;
                UpdateControleButton();
            }
        }

        ControleType controleType;
        public ControleType ControleButtonType
        {
            get
            {
                return controleType;
            }
            set
            {
                controleType = value;
                UpdateControleButton();
            }
        }

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

        public PulsarUIControleButton()
        {
            this.Text = " "; // Leeren Text festlegen
            this.BackColor = Color.Transparent; // Transparenten Hintergrund festlegen
            this.ForeColor = Color.Transparent; // Transparente Schriftfarbe festlegen
            style = Style.Win10Color; // Standardmäßig den Win10-Farbstil verwenden
            controleType = ControleType.Close; // Standardmäßig den Schließen-Typ verwenden
            this.cornerRadius = 15; // Standardwert für den Radius der abgerundeten Ecken
            this.borderColor = Color.Transparent; // Standardwert für die Rahmenfarbe
            this.borderThickness = 10; // Standardwert für die Rahmenstärke
            this.FlatStyle = FlatStyle.Flat; // Flaches Darstellungsformat verwenden
            this.Size = new Size(40, 40); // Standardgröße des Steuerelements festlegen
            this.BackgroundImageLayout = ImageLayout.Zoom; // Hintergrundbildlayout festlegen
            UpdateControleButton(); // Methode zum Aktualisieren des Steuerelements aufrufen
        }

        private void UpdateControleButton()
        {
            if (style == Style.Win10Color) // Wenn der Stil auf Win10-Farbe festgelegt ist
            {
                if (controleType == ControleType.Close) // Wenn der Typ auf Schließen festgelegt ist
                {
                    this.Text = " "; // Leeren Text festlegen
                    this.BackgroundImage = Resources.close_win10_color; // Hintergrundbild auf das Schließen-Symbol in Win10-Farbe setzen
                }
                if (controleType == ControleType.Minimize) // Wenn der Typ auf Minimieren festgelegt ist
                {
                    this.Text += " "; // Leeren Text festlegen
                    this.BackgroundImage = Resources.minimize_win10_color; // Hintergrundbild auf das Minimieren-Symbol in Win10-Farbe setzen
                }
                if (controleType == ControleType.Maximize) // Wenn der Typ auf Maximieren festgelegt ist
                {
                    this.Text = " "; // Leeren Text festlegen
                    this.BackgroundImage = Resources.maximize_win10_color; // Hintergrundbild auf das Maximieren-Symbol in Win10-Farbe setzen
                }
            }
        }

        protected override void OnClick(EventArgs e)
        {
            //base.OnClick(e);
            if (controleType == ControleType.Close) // Wenn der Typ auf Schließen festgelegt ist
            {
                Form form = (Form)this.Parent; // Elternformular erhalten
                form.Close(); // Formular schließen
            }
            if (controleType == ControleType.Minimize) // Wenn der Typ auf Minimieren festgelegt ist
            {
                Form form = (Form)this.Parent; // Elternformular erhalten
                form.WindowState = FormWindowState.Minimized; // Formular minimieren
            }
            if (controleType == ControleType.Maximize) // Wenn der Typ auf Maximieren festgelegt ist
            {
                Form form = (Form)this.Parent; // Elternformular erhalten
                form.WindowState = FormWindowState.Maximized; // Formular maximieren
            }
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath(); // Neuen GraphicsPath erstellen
            path.StartFigure(); // Start des Pfads
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Bogen zur linken oberen Ecke hinzufügen
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90); // Bogen zur rechten oberen Ecke hinzufügen
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90); // Bogen zur rechten unteren Ecke hinzufügen
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90); // Bogen zur linken unteren Ecke hinzufügen
            path.CloseFigure(); // Schließen des Pfads

            return path; // GraphicsPath zurückgeben
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // Anti-Aliasing aktivieren

            RectangleF recSurface = new RectangleF(0, 0, this.Width, this.Height); // Rechteck für die Oberfläche des Steuerelements
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1); // Rechteck für den Rahmen des Steuerelements

            if (isRoundedCorners) // Wenn die Ecken abgerundet sind
            {
                using (GraphicsPath pathSurface = GetFigurePath(recSurface, cornerRadius)) // GraphicsPath für die Oberfläche erstellen
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, cornerRadius - 1F)) // GraphicsPath für den Rahmen erstellen
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2)) // Stift für die Oberfläche erstellen
                using (Pen penBorder = new Pen(borderColor, borderThickness)) // Stift für den Rahmen erstellen
                {
                    penBorder.Alignment = PenAlignment.Inset; // Rahmenstiftausrichtung festlegen
                    // Button-Oberfläche
                    this.Region = new Region(pathSurface); // Region für die Oberfläche festlegen
                    // Oberflächenrahmen zeichnen für HD-Ergebnis
                    pevent.Graphics.DrawPath(penSurface, pathSurface); // Oberflächenpfad zeichnen
                    // Button-Rahmen
                    // Steuerelementrahmen zeichnen
                    if (borderThickness >= 1)
                    {
                        pevent.Graphics.DrawPath(penBorder, pathBorder); // Rahmenpfad zeichnen
                    }
                }
            }
            else // normales Steuerelement
            {
                // Button-Oberfläche
                this.Region = new Region(recSurface); // Region für die Oberfläche festlegen
                // Button-Rahmen
                if (borderThickness >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderThickness)) // Stift für den Rahmen erstellen
                    {
                        penBorder.Alignment = PenAlignment.Inset; // Rahmenstiftausrichtung festlegen
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1); // Rahmen zeichnen
                    }
                }
            }
        }
    }
}
