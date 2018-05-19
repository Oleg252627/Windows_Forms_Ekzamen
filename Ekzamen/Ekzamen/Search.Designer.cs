namespace Ekzamen
{
    partial class Search
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.panel1_Control = new System.Windows.Forms.Panel();
            this.panel1_Footer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2_Osnova = new System.Windows.Forms.Panel();
            this.bunifuImageButton1_Zamen = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1_Clear = new Bunifu.Framework.UI.BunifuImageButton();
            this.textBox1_Serch = new System.Windows.Forms.TextBox();
            this.panel1_Zamena = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1_Serch = new System.Windows.Forms.Button();
            this.button1_Zamenit = new System.Windows.Forms.Button();
            this.textBox1_Zamenit = new System.Windows.Forms.TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1_Close)).BeginInit();
            this.panel2_Osnova.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1_Zamen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1_Clear)).BeginInit();
            this.panel1_Zamena.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1_Control
            // 
            this.panel1_Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1_Control.Controls.Add(this.label1);
            this.panel1_Control.Controls.Add(this.bunifuImageButton1_Close);
            this.bunifuTransition1.SetDecoration(this.panel1_Control, BunifuAnimatorNS.DecorationType.None);
            this.panel1_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1_Control.Location = new System.Drawing.Point(0, 0);
            this.panel1_Control.Name = "panel1_Control";
            this.panel1_Control.Size = new System.Drawing.Size(337, 27);
            this.panel1_Control.TabIndex = 0;
            // 
            // panel1_Footer
            // 
            this.panel1_Footer.BackColor = System.Drawing.Color.Brown;
            this.bunifuTransition1.SetDecoration(this.panel1_Footer, BunifuAnimatorNS.DecorationType.None);
            this.panel1_Footer.Location = new System.Drawing.Point(0, 43);
            this.panel1_Footer.Name = "panel1_Footer";
            this.panel1_Footer.Size = new System.Drawing.Size(337, 10);
            this.panel1_Footer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск";
            // 
            // bunifuImageButton1_Close
            // 
            this.bunifuImageButton1_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1_Close.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1_Close, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1_Close.Image = global::Ekzamen.Properties.Resources.Close;
            this.bunifuImageButton1_Close.ImageActive = null;
            this.bunifuImageButton1_Close.Location = new System.Drawing.Point(312, 6);
            this.bunifuImageButton1_Close.Name = "bunifuImageButton1_Close";
            this.bunifuImageButton1_Close.Size = new System.Drawing.Size(16, 16);
            this.bunifuImageButton1_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1_Close.TabIndex = 2;
            this.bunifuImageButton1_Close.TabStop = false;
            this.bunifuImageButton1_Close.Zoom = 10;
            // 
            // panel2_Osnova
            // 
            this.panel2_Osnova.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2_Osnova.Controls.Add(this.button1_Serch);
            this.panel2_Osnova.Controls.Add(this.bunifuImageButton1_Zamen);
            this.panel2_Osnova.Controls.Add(this.panel1_Footer);
            this.panel2_Osnova.Controls.Add(this.bunifuImageButton1_Clear);
            this.panel2_Osnova.Controls.Add(this.textBox1_Serch);
            this.bunifuTransition1.SetDecoration(this.panel2_Osnova, BunifuAnimatorNS.DecorationType.None);
            this.panel2_Osnova.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2_Osnova.Location = new System.Drawing.Point(0, 27);
            this.panel2_Osnova.Name = "panel2_Osnova";
            this.panel2_Osnova.Size = new System.Drawing.Size(337, 53);
            this.panel2_Osnova.TabIndex = 2;
            // 
            // bunifuImageButton1_Zamen
            // 
            this.bunifuImageButton1_Zamen.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1_Zamen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1_Zamen, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1_Zamen.Image = global::Ekzamen.Properties.Resources.Down;
            this.bunifuImageButton1_Zamen.ImageActive = null;
            this.bunifuImageButton1_Zamen.Location = new System.Drawing.Point(12, 11);
            this.bunifuImageButton1_Zamen.Name = "bunifuImageButton1_Zamen";
            this.bunifuImageButton1_Zamen.Size = new System.Drawing.Size(18, 18);
            this.bunifuImageButton1_Zamen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1_Zamen.TabIndex = 7;
            this.bunifuImageButton1_Zamen.TabStop = false;
            this.bunifuImageButton1_Zamen.Zoom = 10;
            // 
            // bunifuImageButton1_Clear
            // 
            this.bunifuImageButton1_Clear.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1_Clear, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1_Clear.Image = global::Ekzamen.Properties.Resources.Close_Serch;
            this.bunifuImageButton1_Clear.ImageActive = null;
            this.bunifuImageButton1_Clear.Location = new System.Drawing.Point(197, 11);
            this.bunifuImageButton1_Clear.Name = "bunifuImageButton1_Clear";
            this.bunifuImageButton1_Clear.Size = new System.Drawing.Size(18, 18);
            this.bunifuImageButton1_Clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1_Clear.TabIndex = 6;
            this.bunifuImageButton1_Clear.TabStop = false;
            this.bunifuImageButton1_Clear.Zoom = 10;
            // 
            // textBox1_Serch
            // 
            this.textBox1_Serch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.textBox1_Serch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.textBox1_Serch, BunifuAnimatorNS.DecorationType.None);
            this.textBox1_Serch.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1_Serch.Location = new System.Drawing.Point(36, 10);
            this.textBox1_Serch.Name = "textBox1_Serch";
            this.textBox1_Serch.Size = new System.Drawing.Size(155, 20);
            this.textBox1_Serch.TabIndex = 5;
            // 
            // panel1_Zamena
            // 
            this.panel1_Zamena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1_Zamena.Controls.Add(this.textBox1_Zamenit);
            this.panel1_Zamena.Controls.Add(this.button1_Zamenit);
            this.panel1_Zamena.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this.panel1_Zamena, BunifuAnimatorNS.DecorationType.None);
            this.panel1_Zamena.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1_Zamena.Location = new System.Drawing.Point(0, 80);
            this.panel1_Zamena.Name = "panel1_Zamena";
            this.panel1_Zamena.Size = new System.Drawing.Size(337, 47);
            this.panel1_Zamena.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 10);
            this.panel1.TabIndex = 2;
            // 
            // button1_Serch
            // 
            this.bunifuTransition1.SetDecoration(this.button1_Serch, BunifuAnimatorNS.DecorationType.None);
            this.button1_Serch.FlatAppearance.BorderSize = 0;
            this.button1_Serch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Serch.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_Serch.ForeColor = System.Drawing.SystemColors.Info;
            this.button1_Serch.Location = new System.Drawing.Point(221, 9);
            this.button1_Serch.Name = "button1_Serch";
            this.button1_Serch.Size = new System.Drawing.Size(75, 23);
            this.button1_Serch.TabIndex = 8;
            this.button1_Serch.Text = "Поиск...";
            this.button1_Serch.UseVisualStyleBackColor = true;
            // 
            // button1_Zamenit
            // 
            this.bunifuTransition1.SetDecoration(this.button1_Zamenit, BunifuAnimatorNS.DecorationType.None);
            this.button1_Zamenit.FlatAppearance.BorderSize = 0;
            this.button1_Zamenit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Zamenit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1_Zamenit.ForeColor = System.Drawing.SystemColors.Info;
            this.button1_Zamenit.Location = new System.Drawing.Point(221, 7);
            this.button1_Zamenit.Name = "button1_Zamenit";
            this.button1_Zamenit.Size = new System.Drawing.Size(75, 23);
            this.button1_Zamenit.TabIndex = 3;
            this.button1_Zamenit.Text = "Заменить";
            this.button1_Zamenit.UseVisualStyleBackColor = true;
            // 
            // textBox1_Zamenit
            // 
            this.textBox1_Zamenit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.textBox1_Zamenit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.textBox1_Zamenit, BunifuAnimatorNS.DecorationType.None);
            this.textBox1_Zamenit.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1_Zamenit.Location = new System.Drawing.Point(36, 8);
            this.textBox1_Zamenit.Name = "textBox1_Zamenit";
            this.textBox1_Zamenit.Size = new System.Drawing.Size(155, 20);
            this.textBox1_Zamenit.TabIndex = 4;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1_Control;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(337, 149);
            this.Controls.Add(this.panel1_Zamena);
            this.Controls.Add(this.panel2_Osnova);
            this.Controls.Add(this.panel1_Control);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.TransparencyKey = System.Drawing.SystemColors.AppWorkspace;
            this.panel1_Control.ResumeLayout(false);
            this.panel1_Control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1_Close)).EndInit();
            this.panel2_Osnova.ResumeLayout(false);
            this.panel2_Osnova.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1_Zamen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1_Clear)).EndInit();
            this.panel1_Zamena.ResumeLayout(false);
            this.panel1_Zamena.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_Control;
        private System.Windows.Forms.Panel panel1_Footer;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2_Osnova;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1_Zamen;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1_Clear;
        private System.Windows.Forms.TextBox textBox1_Serch;
        private System.Windows.Forms.Button button1_Serch;
        private System.Windows.Forms.Panel panel1_Zamena;
        private System.Windows.Forms.TextBox textBox1_Zamenit;
        private System.Windows.Forms.Button button1_Zamenit;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}