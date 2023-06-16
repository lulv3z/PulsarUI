namespace PulsarUI.Forms
{
    partial class PulsarUIBasicForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PulsarUIBasicForm));
            this.app_bar = new System.Windows.Forms.Panel();
            this.pulsarUIFormTextLbl = new PulsarUI.Controles.PulsarUILabel();
            this.app_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // app_bar
            // 
            this.app_bar.BackColor = System.Drawing.Color.RoyalBlue;
            this.app_bar.Controls.Add(this.pulsarUIFormTextLbl);
            resources.ApplyResources(this.app_bar, "app_bar");
            this.app_bar.Name = "app_bar";
            // 
            // pulsarUIFormTextLbl
            // 
            resources.ApplyResources(this.pulsarUIFormTextLbl, "pulsarUIFormTextLbl");
            this.pulsarUIFormTextLbl.BackColor = System.Drawing.Color.Transparent;
            this.pulsarUIFormTextLbl.ForeColor = System.Drawing.Color.White;
            this.pulsarUIFormTextLbl.Name = "pulsarUIFormTextLbl";
            // 
            // PulsarUIBasicForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.app_bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PulsarUIBasicForm";
            this.app_bar.ResumeLayout(false);
            this.app_bar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel app_bar;
        private Controles.PulsarUILabel pulsarUIFormTextLbl;
    }
}