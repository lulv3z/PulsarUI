namespace PulsarUI.Forms
{
    partial class PulsarUIModernForm
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
            this.components = new System.ComponentModel.Container();
            this.app_nav = new System.Windows.Forms.Panel();
            this.app_minimize = new System.Windows.Forms.PictureBox();
            this.app_close = new System.Windows.Forms.PictureBox();
            this.app_title = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.startup = new System.Windows.Forms.Timer(this.components);
            this.btnHome = new PulsarUI.Controles.PulsarUIButton();
            this.pulsarUIButton1 = new PulsarUI.Controles.PulsarUIButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pulsarUIButton2 = new PulsarUI.Controles.PulsarUIButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pulsarUIButton3 = new PulsarUI.Controles.PulsarUIButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pulsarUIButton4 = new PulsarUI.Controles.PulsarUIButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pulsarUIButton5 = new PulsarUI.Controles.PulsarUIButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pulsarUIButton6 = new PulsarUI.Controles.PulsarUIButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pulsarUIButton7 = new PulsarUI.Controles.PulsarUIButton();
            this.app_nav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.app_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.app_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // app_nav
            // 
            this.app_nav.BackColor = System.Drawing.Color.White;
            this.app_nav.Controls.Add(this.app_minimize);
            this.app_nav.Controls.Add(this.app_close);
            this.app_nav.Controls.Add(this.app_title);
            this.app_nav.Controls.Add(this.btnHam);
            this.app_nav.Dock = System.Windows.Forms.DockStyle.Top;
            this.app_nav.Location = new System.Drawing.Point(0, 0);
            this.app_nav.Name = "app_nav";
            this.app_nav.Size = new System.Drawing.Size(800, 39);
            this.app_nav.TabIndex = 0;
            this.app_nav.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.app_nav_MouseDoubleClick);
            this.app_nav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.app_nav_MouseDown);
            this.app_nav.MouseMove += new System.Windows.Forms.MouseEventHandler(this.app_nav_MouseMove);
            this.app_nav.MouseUp += new System.Windows.Forms.MouseEventHandler(this.app_nav_MouseUp);
            // 
            // app_minimize
            // 
            this.app_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.app_minimize.BackColor = System.Drawing.Color.Transparent;
            this.app_minimize.Image = global::PulsarUI.Properties.Resources.Subtract;
            this.app_minimize.Location = new System.Drawing.Point(744, 9);
            this.app_minimize.Name = "app_minimize";
            this.app_minimize.Size = new System.Drawing.Size(22, 22);
            this.app_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.app_minimize.TabIndex = 1;
            this.app_minimize.TabStop = false;
            this.app_minimize.Click += new System.EventHandler(this.app_minimize_Click);
            // 
            // app_close
            // 
            this.app_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.app_close.BackColor = System.Drawing.Color.Transparent;
            this.app_close.Image = global::PulsarUI.Properties.Resources.Close;
            this.app_close.Location = new System.Drawing.Point(772, 9);
            this.app_close.Name = "app_close";
            this.app_close.Size = new System.Drawing.Size(22, 22);
            this.app_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.app_close.TabIndex = 1;
            this.app_close.TabStop = false;
            this.app_close.Click += new System.EventHandler(this.app_close_Click);
            // 
            // app_title
            // 
            this.app_title.AutoSize = true;
            this.app_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_title.Location = new System.Drawing.Point(45, 9);
            this.app_title.Name = "app_title";
            this.app_title.Size = new System.Drawing.Size(207, 28);
            this.app_title.TabIndex = 1;
            this.app_title.Text = "PulsarUI-ModernForm";
            // 
            // btnHam
            // 
            this.btnHam.Image = global::PulsarUI.Properties.Resources.Menu;
            this.btnHam.Location = new System.Drawing.Point(9, 5);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(30, 28);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHam.TabIndex = 0;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Controls.Add(this.panel8);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 39);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(195, 411);
            this.sidebar.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Location = new System.Drawing.Point(3, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 45);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pulsarUIButton1);
            this.panel1.Location = new System.Drawing.Point(3, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 45);
            this.panel1.TabIndex = 3;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // startup
            // 
            this.startup.Enabled = true;
            this.startup.Interval = 10;
            this.startup.Tick += new System.EventHandler(this.startup_Tick);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnHome.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnHome.BorderThickness = 0;
            this.btnHome.CornerRadius = 40;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::PulsarUI.Properties.Resources.Home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.IsRoundedCorners = false;
            this.btnHome.Location = new System.Drawing.Point(-3, -5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(207, 57);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Visible = false;
            // 
            // pulsarUIButton1
            // 
            this.pulsarUIButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pulsarUIButton1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pulsarUIButton1.BorderThickness = 0;
            this.pulsarUIButton1.CornerRadius = 40;
            this.pulsarUIButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pulsarUIButton1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulsarUIButton1.ForeColor = System.Drawing.Color.White;
            this.pulsarUIButton1.Image = global::PulsarUI.Properties.Resources.Home;
            this.pulsarUIButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pulsarUIButton1.IsRoundedCorners = false;
            this.pulsarUIButton1.Location = new System.Drawing.Point(-3, -5);
            this.pulsarUIButton1.Name = "pulsarUIButton1";
            this.pulsarUIButton1.Size = new System.Drawing.Size(207, 57);
            this.pulsarUIButton1.TabIndex = 2;
            this.pulsarUIButton1.Text = "Home";
            this.pulsarUIButton1.UseVisualStyleBackColor = false;
            this.pulsarUIButton1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pulsarUIButton2);
            this.panel3.Location = new System.Drawing.Point(3, 207);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 45);
            this.panel3.TabIndex = 4;
            // 
            // pulsarUIButton2
            // 
            this.pulsarUIButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pulsarUIButton2.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pulsarUIButton2.BorderThickness = 0;
            this.pulsarUIButton2.CornerRadius = 40;
            this.pulsarUIButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pulsarUIButton2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulsarUIButton2.ForeColor = System.Drawing.Color.White;
            this.pulsarUIButton2.Image = global::PulsarUI.Properties.Resources.Home;
            this.pulsarUIButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pulsarUIButton2.IsRoundedCorners = false;
            this.pulsarUIButton2.Location = new System.Drawing.Point(-3, -5);
            this.pulsarUIButton2.Name = "pulsarUIButton2";
            this.pulsarUIButton2.Size = new System.Drawing.Size(207, 57);
            this.pulsarUIButton2.TabIndex = 2;
            this.pulsarUIButton2.Text = "Home";
            this.pulsarUIButton2.UseVisualStyleBackColor = false;
            this.pulsarUIButton2.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pulsarUIButton3);
            this.panel4.Location = new System.Drawing.Point(3, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 45);
            this.panel4.TabIndex = 5;
            // 
            // pulsarUIButton3
            // 
            this.pulsarUIButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pulsarUIButton3.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pulsarUIButton3.BorderThickness = 0;
            this.pulsarUIButton3.CornerRadius = 40;
            this.pulsarUIButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pulsarUIButton3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulsarUIButton3.ForeColor = System.Drawing.Color.White;
            this.pulsarUIButton3.Image = global::PulsarUI.Properties.Resources.Home;
            this.pulsarUIButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pulsarUIButton3.IsRoundedCorners = false;
            this.pulsarUIButton3.Location = new System.Drawing.Point(-3, -5);
            this.pulsarUIButton3.Name = "pulsarUIButton3";
            this.pulsarUIButton3.Size = new System.Drawing.Size(207, 57);
            this.pulsarUIButton3.TabIndex = 2;
            this.pulsarUIButton3.Text = "Home";
            this.pulsarUIButton3.UseVisualStyleBackColor = false;
            this.pulsarUIButton3.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pulsarUIButton4);
            this.panel5.Location = new System.Drawing.Point(3, 258);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 45);
            this.panel5.TabIndex = 5;
            // 
            // pulsarUIButton4
            // 
            this.pulsarUIButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pulsarUIButton4.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pulsarUIButton4.BorderThickness = 0;
            this.pulsarUIButton4.CornerRadius = 40;
            this.pulsarUIButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pulsarUIButton4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulsarUIButton4.ForeColor = System.Drawing.Color.White;
            this.pulsarUIButton4.Image = global::PulsarUI.Properties.Resources.Home;
            this.pulsarUIButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pulsarUIButton4.IsRoundedCorners = false;
            this.pulsarUIButton4.Location = new System.Drawing.Point(-3, -5);
            this.pulsarUIButton4.Name = "pulsarUIButton4";
            this.pulsarUIButton4.Size = new System.Drawing.Size(207, 57);
            this.pulsarUIButton4.TabIndex = 2;
            this.pulsarUIButton4.Text = "Home";
            this.pulsarUIButton4.UseVisualStyleBackColor = false;
            this.pulsarUIButton4.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pulsarUIButton5);
            this.panel6.Location = new System.Drawing.Point(3, 309);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 45);
            this.panel6.TabIndex = 6;
            // 
            // pulsarUIButton5
            // 
            this.pulsarUIButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pulsarUIButton5.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pulsarUIButton5.BorderThickness = 0;
            this.pulsarUIButton5.CornerRadius = 40;
            this.pulsarUIButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pulsarUIButton5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulsarUIButton5.ForeColor = System.Drawing.Color.White;
            this.pulsarUIButton5.Image = global::PulsarUI.Properties.Resources.Home;
            this.pulsarUIButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pulsarUIButton5.IsRoundedCorners = false;
            this.pulsarUIButton5.Location = new System.Drawing.Point(-3, -5);
            this.pulsarUIButton5.Name = "pulsarUIButton5";
            this.pulsarUIButton5.Size = new System.Drawing.Size(207, 57);
            this.pulsarUIButton5.TabIndex = 2;
            this.pulsarUIButton5.Text = "Home";
            this.pulsarUIButton5.UseVisualStyleBackColor = false;
            this.pulsarUIButton5.Visible = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pulsarUIButton6);
            this.panel7.Location = new System.Drawing.Point(3, 360);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 45);
            this.panel7.TabIndex = 7;
            // 
            // pulsarUIButton6
            // 
            this.pulsarUIButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pulsarUIButton6.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pulsarUIButton6.BorderThickness = 0;
            this.pulsarUIButton6.CornerRadius = 40;
            this.pulsarUIButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pulsarUIButton6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulsarUIButton6.ForeColor = System.Drawing.Color.White;
            this.pulsarUIButton6.Image = global::PulsarUI.Properties.Resources.Home;
            this.pulsarUIButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pulsarUIButton6.IsRoundedCorners = false;
            this.pulsarUIButton6.Location = new System.Drawing.Point(-3, -5);
            this.pulsarUIButton6.Name = "pulsarUIButton6";
            this.pulsarUIButton6.Size = new System.Drawing.Size(207, 57);
            this.pulsarUIButton6.TabIndex = 2;
            this.pulsarUIButton6.Text = "Home";
            this.pulsarUIButton6.UseVisualStyleBackColor = false;
            this.pulsarUIButton6.Visible = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pulsarUIButton7);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 45);
            this.panel8.TabIndex = 8;
            // 
            // pulsarUIButton7
            // 
            this.pulsarUIButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pulsarUIButton7.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pulsarUIButton7.BorderThickness = 0;
            this.pulsarUIButton7.CornerRadius = 40;
            this.pulsarUIButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pulsarUIButton7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulsarUIButton7.ForeColor = System.Drawing.Color.White;
            this.pulsarUIButton7.Image = global::PulsarUI.Properties.Resources.Home;
            this.pulsarUIButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pulsarUIButton7.IsRoundedCorners = false;
            this.pulsarUIButton7.Location = new System.Drawing.Point(-3, -5);
            this.pulsarUIButton7.Name = "pulsarUIButton7";
            this.pulsarUIButton7.Size = new System.Drawing.Size(207, 57);
            this.pulsarUIButton7.TabIndex = 2;
            this.pulsarUIButton7.Text = "Home";
            this.pulsarUIButton7.UseVisualStyleBackColor = false;
            // 
            // PulsarUIModernForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.app_nav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PulsarUIModernForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PulsarUIModernForm";
            this.app_nav.ResumeLayout(false);
            this.app_nav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.app_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.app_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTransition;
        public System.Windows.Forms.Panel app_nav;
        public System.Windows.Forms.PictureBox btnHam;
        public System.Windows.Forms.Label app_title;
        public System.Windows.Forms.PictureBox app_minimize;
        public System.Windows.Forms.PictureBox app_close;
        public System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public Controles.PulsarUIButton btnHome;
        public Controles.PulsarUIButton pulsarUIButton1;
        private System.Windows.Forms.Timer startup;
        private System.Windows.Forms.Panel panel8;
        public Controles.PulsarUIButton pulsarUIButton7;
        private System.Windows.Forms.Panel panel4;
        public Controles.PulsarUIButton pulsarUIButton3;
        private System.Windows.Forms.Panel panel3;
        public Controles.PulsarUIButton pulsarUIButton2;
        private System.Windows.Forms.Panel panel5;
        public Controles.PulsarUIButton pulsarUIButton4;
        private System.Windows.Forms.Panel panel6;
        public Controles.PulsarUIButton pulsarUIButton5;
        private System.Windows.Forms.Panel panel7;
        public Controles.PulsarUIButton pulsarUIButton6;
    }
}