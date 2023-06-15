using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulsarUI.Controles
{
    public class PulsarUILabel : Label
    {
        // Konstruktor der PulsarUILabel-Klasse
        public PulsarUILabel()
        {
            // Setze den Text des Labels auf "PulsarUI Label"
            this.Text = "PulsarUI Label";

            // Setze die Hintergrundfarbe des Labels auf transparent
            this.BackColor = Color.Transparent;

            // Setze die Vordergrundfarbe des Labels auf Schwarz
            this.ForeColor = Color.Black;
        }
    }
}
