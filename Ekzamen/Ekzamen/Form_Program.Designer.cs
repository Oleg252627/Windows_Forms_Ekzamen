namespace Ekzamen
{
    partial class Form_Program
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
            this.panel1_Top = new System.Windows.Forms.Panel();
            this.panel1_footer = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1_Osnova = new System.Windows.Forms.Panel();
            this.panel1_Text = new System.Windows.Forms.Panel();
            this.label2_USA = new System.Windows.Forms.Label();
            this.label2_Text = new System.Windows.Forms.Label();
            this.label2_Versiy = new System.Windows.Forms.Label();
            this.label2_Notpade = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1_Osnova.SuspendLayout();
            this.panel1_Text.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_Top
            // 
            this.panel1_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1_Top.Controls.Add(this.label1);
            this.panel1_Top.Controls.Add(this.bunifuImageButton1);
            this.panel1_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1_Top.Location = new System.Drawing.Point(0, 0);
            this.panel1_Top.Name = "panel1_Top";
            this.panel1_Top.Size = new System.Drawing.Size(637, 39);
            this.panel1_Top.TabIndex = 0;
            // 
            // panel1_footer
            // 
            this.panel1_footer.BackColor = System.Drawing.Color.Brown;
            this.panel1_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1_footer.Location = new System.Drawing.Point(0, 400);
            this.panel1_footer.Name = "panel1_footer";
            this.panel1_footer.Size = new System.Drawing.Size(637, 10);
            this.panel1_footer.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::Ekzamen.Properties.Resources.Close;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(607, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(18, 18);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "О программе";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1_Top;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1_Osnova
            // 
            this.panel1_Osnova.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1_Osnova.Controls.Add(this.panel1_Text);
            this.panel1_Osnova.Controls.Add(this.pictureBox1);
            this.panel1_Osnova.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_Osnova.Location = new System.Drawing.Point(0, 39);
            this.panel1_Osnova.Name = "panel1_Osnova";
            this.panel1_Osnova.Size = new System.Drawing.Size(637, 361);
            this.panel1_Osnova.TabIndex = 3;
            // 
            // panel1_Text
            // 
            this.panel1_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1_Text.Controls.Add(this.label2_USA);
            this.panel1_Text.Controls.Add(this.label2_Text);
            this.panel1_Text.Controls.Add(this.label2_Versiy);
            this.panel1_Text.Controls.Add(this.label2_Notpade);
            this.panel1_Text.Location = new System.Drawing.Point(338, 150);
            this.panel1_Text.Name = "panel1_Text";
            this.panel1_Text.Size = new System.Drawing.Size(272, 194);
            this.panel1_Text.TabIndex = 1;
            // 
            // label2_USA
            // 
            this.label2_USA.AutoSize = true;
            this.label2_USA.BackColor = System.Drawing.Color.Transparent;
            this.label2_USA.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2_USA.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2_USA.Location = new System.Drawing.Point(22, 114);
            this.label2_USA.Name = "label2_USA";
            this.label2_USA.Size = new System.Drawing.Size(151, 51);
            this.label2_USA.TabIndex = 6;
            this.label2_USA.Text = "Examination program\r\nSubject: Windows Forms\r\nAuthor: Pletinenko Oleg";
            // 
            // label2_Text
            // 
            this.label2_Text.AutoSize = true;
            this.label2_Text.BackColor = System.Drawing.Color.Transparent;
            this.label2_Text.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2_Text.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2_Text.Location = new System.Drawing.Point(14, 114);
            this.label2_Text.Name = "label2_Text";
            this.label2_Text.Size = new System.Drawing.Size(198, 51);
            this.label2_Text.TabIndex = 5;
            this.label2_Text.Text = "Экзаменационная программа\r\n по предмету: Windows Forms\r\n Автор: Плетиненко Олег";
            // 
            // label2_Versiy
            // 
            this.label2_Versiy.AutoSize = true;
            this.label2_Versiy.BackColor = System.Drawing.Color.Transparent;
            this.label2_Versiy.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2_Versiy.ForeColor = System.Drawing.Color.Brown;
            this.label2_Versiy.Location = new System.Drawing.Point(92, 46);
            this.label2_Versiy.Name = "label2_Versiy";
            this.label2_Versiy.Size = new System.Drawing.Size(113, 17);
            this.label2_Versiy.TabIndex = 4;
            this.label2_Versiy.Text = "version: Oleg 14.1";
            // 
            // label2_Notpade
            // 
            this.label2_Notpade.AutoSize = true;
            this.label2_Notpade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2_Notpade.ForeColor = System.Drawing.Color.Brown;
            this.label2_Notpade.Location = new System.Drawing.Point(21, 26);
            this.label2_Notpade.Name = "label2_Notpade";
            this.label2_Notpade.Size = new System.Drawing.Size(103, 20);
            this.label2_Notpade.TabIndex = 3;
            this.label2_Notpade.Text = "Notepade++";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox1.Image = global::Ekzamen.Properties.Resources._111;
            this.pictureBox1.Location = new System.Drawing.Point(12, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 410);
            this.Controls.Add(this.panel1_Osnova);
            this.Controls.Add(this.panel1_footer);
            this.Controls.Add(this.panel1_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Program";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Program";
            this.panel1_Top.ResumeLayout(false);
            this.panel1_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1_Osnova.ResumeLayout(false);
            this.panel1_Text.ResumeLayout(false);
            this.panel1_Text.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_Top;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1_footer;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1_Osnova;
        private System.Windows.Forms.Panel panel1_Text;
        private System.Windows.Forms.Label label2_USA;
        private System.Windows.Forms.Label label2_Text;
        private System.Windows.Forms.Label label2_Versiy;
        private System.Windows.Forms.Label label2_Notpade;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}