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
    public partial class Search : Form
    {
        private bool flag_button = true;
        private bool Flag_Thems;
        private Main_Form mainForm;
        private bool Flag_leng;

        public Search(Main_Form form, bool flag_thems,bool flag_lenght )
        {
            InitializeComponent();
            Flag_leng = flag_lenght;
            if (flag_thems)
            {
                Flag_Thems = true;
                this.panel1_Control.BackColor = Color.FromArgb(45, 45, 48);
                this.panel2_Osnova.BackColor = Color.FromArgb(30, 30, 30);
                this.panel1_Zamena.BackColor= Color.FromArgb(30, 30, 30);
                this.panel1_Footer.BackColor = Color.Brown;
                this.panel1.BackColor= Color.Brown;
                Bitmap bitmap = new Bitmap(String.Format(@"..\..\images\Down.png"));
                this.bunifuImageButton1_Zamen.Image = bitmap;
                Bitmap bitmap1 = new Bitmap(String.Format(@"..\..\images\Close_Serch.png"));
                this.bunifuImageButton1_Clear.Image = bitmap1;
                this.textBox1_Serch.BackColor= Color.FromArgb(45, 45, 48);
                this.textBox1_Serch.ForeColor = SystemColors.Info;
                this.textBox1_Zamenit.BackColor= Color.FromArgb(45, 45, 48);
                this.textBox1_Zamenit.ForeColor= SystemColors.Info;
                this.button1_Serch.BackColor = Color.FromArgb(45, 45, 48);
                this.button1_Serch.ForeColor= SystemColors.Info;
                this.button1_Zamenit.BackColor= Color.FromArgb(45, 45, 48);
                this.button1_Zamenit.ForeColor= SystemColors.Info;
            }
            else
            {
                Flag_Thems = false;
                this.panel1_Control.BackColor = Color.FromArgb(41, 56, 85);
                this.panel2_Osnova.BackColor = Color.FromArgb(213, 219, 233);
                this.panel1_Zamena.BackColor = Color.FromArgb(213, 219, 233);
                this.panel1_Footer.BackColor = Color.FromArgb(41, 56, 85);
                this.panel1.BackColor = Color.FromArgb(41, 56, 85);
                Bitmap bitmap = new Bitmap(String.Format(@"..\..\images\Down_Light.png"));
                this.bunifuImageButton1_Zamen.Image = bitmap;
                Bitmap bitmap1 = new Bitmap(String.Format(@"..\..\images\Close_Serch_Light.png"));
                this.bunifuImageButton1_Clear.Image = bitmap1;
                this.textBox1_Serch.BackColor = SystemColors.Window;
                this.textBox1_Serch.ForeColor = SystemColors.ControlText;
                this.textBox1_Zamenit.BackColor = SystemColors.Window;
                this.textBox1_Zamenit.ForeColor = SystemColors.ControlText;
                this.button1_Serch.BackColor = SystemColors.Window;
                this.button1_Serch.ForeColor = SystemColors.ControlText;
                this.button1_Zamenit.BackColor = SystemColors.Window;
                this.button1_Zamenit.ForeColor = SystemColors.ControlText;
            }

            if (flag_lenght)
            {
                this.label1.Text = "Поиск";
                this.button1_Serch.Text = "Поиск...";
                this.button1_Zamenit.Text = "Заменить";
            }
            else
            {
                this.label1.Text = "Search";
                this.button1_Serch.Text = "Search...";
                this.button1_Zamenit.Text = "Replace";
            }
            mainForm = form;
            this.panel1_Zamena.Visible = false;
            this.bunifuImageButton1_Close.Click += BunifuImageButton1_Close_Click;
            this.bunifuImageButton1_Clear.Click += BunifuImageButton1_Clear_Click;
            this.bunifuImageButton1_Zamen.Click += BunifuImageButton1_Zamen_Click;
            this.textBox1_Serch.TextChanged += new EventHandler(textBox1_Serch_Text);
            this.textBox1_Zamenit.TextChanged+= new EventHandler(textBox1_Zamenit_Text);
            this.button1_Serch.Click += Button1_Serch_Click;
            this.button1_Zamenit.Click += Button1_Zamenit_Click;
        }

        private void Button1_Zamenit_Click(object sender, EventArgs e)
        {
            if (this.textBox1_Serch.Text == "" || this.textBox1_Zamenit.Text == "")
            {
                if (Flag_leng)
                {
                    MessageBox.Show("Заполните все поля!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Fill in all the fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            mainForm.Add_Word(this.textBox1_Zamenit.Text);
        }

        private void Button1_Serch_Click(object sender, EventArgs e)
        {
            mainForm.Serch_Button_Word(this.textBox1_Serch.Text);
        }

        private void textBox1_Zamenit_Text(object sender, EventArgs e)
         {
            if (String.IsNullOrWhiteSpace(this.textBox1_Zamenit.Text))
            {
                textBox1_Zamenit.Text = null;
            }
          
        }
        private void textBox1_Serch_Text(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.textBox1_Serch.Text))
            {
                mainForm.Serch_Word(this.textBox1_Serch.Text);
            }
            else
            {
                textBox1_Serch.Text = null;
            }
        }
        private void BunifuImageButton1_Zamen_Click(object sender, EventArgs e)
        {
            if (Flag_Thems)
            {
                if (flag_button)
                {
                    Bitmap bitmap = new Bitmap(String.Format(@"..\..\images\Up.png"));
                    this.bunifuImageButton1_Zamen.Image = bitmap;
                    this.panel1_Footer.Visible = false;
                    this.bunifuTransition1.ShowSync(this.panel1_Zamena);
                    flag_button = false;
                }
                else
                {
                    Bitmap bitmap = new Bitmap(String.Format(@"..\..\images\Down.png"));
                    this.bunifuImageButton1_Zamen.Image = bitmap;
                    this.bunifuTransition1.HideSync(this.panel1_Zamena);
                    this.panel1_Footer.Visible = true;
                    flag_button = true;
                }
            }
            else
            {
                if (flag_button)
                {
                    Bitmap bitmap = new Bitmap(String.Format(@"..\..\images\Up_Light.png"));
                    this.bunifuImageButton1_Zamen.Image = bitmap;
                    this.panel1_Footer.Visible = false;
                    this.bunifuTransition1.ShowSync(this.panel1_Zamena);
                    flag_button = false;
                }
                else
                {
                    Bitmap bitmap = new Bitmap(String.Format(@"..\..\images\Down_Light.png"));
                    this.bunifuImageButton1_Zamen.Image = bitmap;
                    this.bunifuTransition1.HideSync(this.panel1_Zamena);
                    this.panel1_Footer.Visible = true;
                    flag_button = true;
                }
            }
        }

        private void BunifuImageButton1_Clear_Click(object sender, EventArgs e)
        {
            this.textBox1_Serch.Text = null;
            this.textBox1_Zamenit.Text = null;
        }

        private void BunifuImageButton1_Close_Click(object sender, EventArgs e)
        {
            mainForm.Delete_BackColor();
            this.Close();
        }
    }
}
