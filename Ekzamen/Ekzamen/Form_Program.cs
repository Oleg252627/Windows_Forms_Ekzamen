using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekzamen
{
    public partial class Form_Program : Form
    {
        public Form_Program(bool flag_Thems, bool flag_Leng)
        {
            InitializeComponent();
            if (flag_Thems)
            {
                this.label1.BackColor = Color.FromArgb(30,30,30);
                this.label1.ForeColor = SystemColors.Window;
                this.panel1_Top.BackColor= Color.FromArgb(30,30,30);
                this.panel1_Osnova.BackColor = Color.FromArgb(45, 45, 48);
                this.pictureBox1.BackColor= Color.FromArgb(30,30,30);
                Bitmap bitmap = new Bitmap(String.Format(@"..\..\images\111.png"));
                this.pictureBox1.Image = bitmap;
                label2_Notpade.BackColor= Color.FromArgb(30, 30, 30);
                this.label2_Notpade.ForeColor = Color.Brown;
                this.label2_Versiy.BackColor = Color.FromArgb(30, 30, 30);
                this.label2_Versiy.ForeColor = Color.Brown;
                this.label2_Text.BackColor = Color.FromArgb(30, 30, 30);
                this.label2_Text.ForeColor = SystemColors.ControlDark;
                this.label2_USA.BackColor = Color.FromArgb(30, 30, 30);
                this.label2_USA.ForeColor= SystemColors.ControlDark;
                this.panel1_footer.BackColor = Color.Brown;
                this.panel1_Text.BackColor= Color.FromArgb(30, 30, 30);
            }
            else
            {
                this.label1.BackColor = Color.FromArgb(41, 56, 85);
                this.label1.ForeColor = SystemColors.Window;
                this.panel1_Top.BackColor = Color.FromArgb(41, 56, 85);
                this.panel1_Osnova.BackColor = Color.FromArgb(213, 219, 233);
                this.pictureBox1.BackColor = SystemColors.Window;
                Bitmap bitmap = new Bitmap(String.Format(@"..\..\images\222.png"));
                this.pictureBox1.Image = bitmap;
                label2_Notpade.BackColor = SystemColors.Window;
                this.label2_Notpade.ForeColor = Color.FromArgb(41, 56, 85);
                this.label2_Versiy.BackColor = SystemColors.Window;
                this.label2_Versiy.ForeColor = Color.FromArgb(41, 56, 85);
                this.label2_Text.BackColor = SystemColors.Window;
                this.label2_Text.ForeColor = SystemColors.ControlText;
                this.label2_USA.BackColor = SystemColors.Window;
                this.label2_USA.ForeColor = SystemColors.ControlText;
                this.panel1_footer.BackColor= Color.FromArgb(41, 56, 85);
                this.panel1_Text.BackColor = SystemColors.Window;
            }

            if (flag_Leng)
            {
                this.label1.Text = "О программе";
                this.label2_Text.Visible = true;
                this.label2_USA.Visible = false;
            }
            else
            {
                this.label1.Text = "About";
                this.label2_Text.Visible = false;
                this.label2_USA.Visible = true;
            }
            this.bunifuImageButton1.Click += BunifuImageButton1_Click;
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
