namespace Ekzamen
{
    partial class Child
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Child));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1_Stroka_ostoiniy = new System.Windows.Forms.Label();
            this.richTextBox1_Child = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RUS_CatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RUS_CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.USA_PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RUS_ComitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RUS_UnComitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Brown;
            this.statusStrip1.Location = new System.Drawing.Point(0, 374);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(550, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1_Stroka_ostoiniy
            // 
            this.label1_Stroka_ostoiniy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1_Stroka_ostoiniy.AutoSize = true;
            this.label1_Stroka_ostoiniy.BackColor = System.Drawing.Color.Brown;
            this.label1_Stroka_ostoiniy.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_Stroka_ostoiniy.ForeColor = System.Drawing.Color.White;
            this.label1_Stroka_ostoiniy.Location = new System.Drawing.Point(357, 377);
            this.label1_Stroka_ostoiniy.Name = "label1_Stroka_ostoiniy";
            this.label1_Stroka_ostoiniy.Size = new System.Drawing.Size(41, 16);
            this.label1_Stroka_ostoiniy.TabIndex = 3;
            this.label1_Stroka_ostoiniy.Text = "label1";
            // 
            // richTextBox1_Child
            // 
            this.richTextBox1_Child.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.richTextBox1_Child.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1_Child.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1_Child.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1_Child.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.richTextBox1_Child.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1_Child.Name = "richTextBox1_Child";
            this.richTextBox1_Child.Size = new System.Drawing.Size(550, 374);
            this.richTextBox1_Child.TabIndex = 5;
            this.richTextBox1_Child.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RUS_CatToolStripMenuItem,
            this.RUS_CopyToolStripMenuItem,
            this.USA_PasteToolStripMenuItem,
            this.toolStripSeparator1,
            this.RUS_ComitToolStripMenuItem,
            this.RUS_UnComitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 120);
            // 
            // RUS_CatToolStripMenuItem
            // 
            this.RUS_CatToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RUS_CatToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.RUS_CatToolStripMenuItem.Name = "RUS_CatToolStripMenuItem";
            this.RUS_CatToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.RUS_CatToolStripMenuItem.Text = "Вырезать";
            // 
            // RUS_CopyToolStripMenuItem
            // 
            this.RUS_CopyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RUS_CopyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.RUS_CopyToolStripMenuItem.Name = "RUS_CopyToolStripMenuItem";
            this.RUS_CopyToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.RUS_CopyToolStripMenuItem.Text = "Копировать";
            // 
            // USA_PasteToolStripMenuItem
            // 
            this.USA_PasteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.USA_PasteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.USA_PasteToolStripMenuItem.Name = "USA_PasteToolStripMenuItem";
            this.USA_PasteToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.USA_PasteToolStripMenuItem.Text = "Вставить";
            // 
            // RUS_ComitToolStripMenuItem
            // 
            this.RUS_ComitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RUS_ComitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.RUS_ComitToolStripMenuItem.Name = "RUS_ComitToolStripMenuItem";
            this.RUS_ComitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.RUS_ComitToolStripMenuItem.Text = "Закомментировать";
            // 
            // RUS_UnComitToolStripMenuItem
            // 
            this.RUS_UnComitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.RUS_UnComitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.RUS_UnComitToolStripMenuItem.Name = "RUS_UnComitToolStripMenuItem";
            this.RUS_UnComitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.RUS_UnComitToolStripMenuItem.Text = "Раскомментаровать";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.DarkGray;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(550, 396);
            this.Controls.Add(this.richTextBox1_Child);
            this.Controls.Add(this.label1_Stroka_ostoiniy);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Child";
            this.Text = "Child";
            this.Load += new System.EventHandler(this.Child_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1_Stroka_ostoiniy;
        private System.Windows.Forms.RichTextBox richTextBox1_Child;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RUS_CatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RUS_CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem USA_PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RUS_ComitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RUS_UnComitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}