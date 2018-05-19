using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekzamen
{
    public partial class Create_File : Form
    {
        private Main_Form mainForm;
        private string File_put;
        private bool Flag_leng;
        public Create_File(Main_Form form, bool flag_thems,bool flag_Leng)
        {
            InitializeComponent();
            mainForm = form;
            Flag_leng = flag_Leng;
            if (flag_thems)
            {
                this.panel1_Top.BackColor = Color.FromArgb(45, 45, 48);
                this.panel1.BackColor= Color.FromArgb(45, 45, 48);
                this.panel2.BackColor= Color.FromArgb(45, 45, 48);
                this.panel3.BackColor= Color.FromArgb(45, 45, 48);
                this.panel4.BackColor= Color.FromArgb(30, 30, 30);
                this.button1_cs.ForeColor = SystemColors.ButtonFace;
                this.button1_rtf.ForeColor= SystemColors.ButtonFace;
                this.button1_txt.ForeColor= SystemColors.ButtonFace;
                this.textBox1_Directore.BackColor= Color.FromArgb(30, 30, 30);
                this.textBox1_Directore.ForeColor= SystemColors.ButtonFace;
                this.textBox1_File_Name.BackColor= Color.FromArgb(30, 30, 30);
                this.textBox1_File_Name.ForeColor= SystemColors.ButtonFace;
                this.label1_Dir.ForeColor = SystemColors.ControlDark;
                this.label2_Name.ForeColor= SystemColors.ControlDark;
                this.button1_Serch.BackColor= Color.FromArgb(30, 30, 30);
                this.button1_Serch.ForeColor= SystemColors.ButtonFace;
                this.button1_Add.BackColor = Color.FromArgb(30, 30, 30);
                this.button1_Add.ForeColor= SystemColors.ButtonFace;
                this.button1_Otmena.BackColor= Color.FromArgb(30, 30, 30);
                this.button1_Otmena.ForeColor= SystemColors.ButtonFace;
                this.panel2_footer.BackColor = Color.Brown;
            }
            else
            {
                this.panel1_Top.BackColor = Color.FromArgb(41, 56, 85);
                this.panel1.BackColor = Color.FromArgb(213, 219, 233);
                this.panel2.BackColor = Color.FromArgb(213, 219, 233);
                this.panel3.BackColor = Color.FromArgb(213, 219, 233);
                this.panel4.BackColor = SystemColors.Window;
                this.button1_cs.ForeColor = SystemColors.ControlText;
                this.button1_rtf.ForeColor = SystemColors.ControlText;
                this.button1_txt.ForeColor = SystemColors.ControlText;
                this.textBox1_Directore.BackColor = SystemColors.Window;
                this.textBox1_Directore.ForeColor = SystemColors.ControlText;
                this.textBox1_File_Name.BackColor = SystemColors.Window;
                this.textBox1_File_Name.ForeColor = SystemColors.ControlText;
                this.label1_Dir.ForeColor = Color.FromArgb(41, 56, 85);
                this.label2_Name.ForeColor = Color.FromArgb(41, 56, 85);
                this.button1_Serch.BackColor = SystemColors.Window;
                this.button1_Serch.ForeColor = SystemColors.ControlText;
                this.button1_Add.BackColor = SystemColors.Window;
                this.button1_Add.ForeColor = SystemColors.ControlText;
                this.button1_Otmena.BackColor = SystemColors.Window;
                this.button1_Otmena.ForeColor = SystemColors.ControlText;
                this.panel2_footer.BackColor = Color.FromArgb(41, 56, 85);
            }

            if (flag_Leng)
            {
                this.label1_Top.Text = "Создать фаил";
                this.button1_cs.Text = "Файл.cs";
                this.button1_txt.Text= "Файл.txt";
                this.button1_rtf.Text= "Файл.rtf";
                this.button1_Add.Text = "Создать";
                this.button1_Otmena.Text = "Отмена";
                this.button1_Serch.Text = "Поиск";
                this.label2_Name.Text = "Имя";
                this.label1_Dir.Text = "Место";
            }
            else
            {
                this.label1_Top.Text = "Create file";
                this.button1_cs.Text = "File.cs";
                this.button1_txt.Text = "File.txt";
                this.button1_rtf.Text = "File.rtf";
                this.button1_Add.Text = "Create";
                this.button1_Otmena.Text = "Cancel";
                this.button1_Serch.Text = "Search";
                this.label2_Name.Text = "Name";
                this.label1_Dir.Text = "Folder";
            }
            this.bunifuImageButton1_Close.Click += BunifuImageButton1_Close_Click;
            this.button1_cs.Click += Button1_cs_Click;
            this.button1_rtf.Click += Button1_rtf_Click;
            this.button1_txt.Click += Button1_txt_Click;
            this.button1_Serch.Click += Button1_Serch_Click;
            this.textBox1_File_Name.TextChanged+= new EventHandler(textBox1_File_Name_TextChanged);
            this.button1_Add.Click += Button1_Add_Click;
            this.button1_Otmena.Click += Button1_Otmena_Click;
        }

        private void Button1_Otmena_Click(object sender, EventArgs e)
        {
            this.textBox1_Directore.Text = null;
            this.textBox1_File_Name.Text = null;
        }

        private void Button1_Add_Click(object sender, EventArgs e)
        {
            if (this.textBox1_File_Name.Text == "" || this.textBox1_Directore.Text == "")
            {
                if (Flag_leng)
                {
                    MessageBox.Show("Заполните все поля!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("Fill in all the fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            String put = this.textBox1_Directore.Text.ToString();
            put += "/";
            put += File_put;
            mainForm.Set_Name(put);
            

            this.DialogResult = DialogResult.OK;
           
        }

        private void textBox1_File_Name_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(this.textBox1_File_Name.Text))
            {
                File_put = this.textBox1_File_Name.Text;
            }
            else
            {
                textBox1_File_Name.Text = null;
            }
        }

        private void Button1_Serch_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                this.textBox1_Directore.Text = folderBrowser.SelectedPath;
            }
        }

        private void Button1_txt_Click(object sender, EventArgs e)
        {
            if (Flag_leng)
            {
                this.textBox1_File_Name.Text = "Файл.txt";
            }
            else
            {
                this.textBox1_File_Name.Text = "File.txt";
            }
        }

        private void Button1_rtf_Click(object sender, EventArgs e)
        {
            if (Flag_leng)
            {
                this.textBox1_File_Name.Text = "Файл.rtf";
            }
            else
            {
                this.textBox1_File_Name.Text = "File.rtf";
            }
        }

        private void Button1_cs_Click(object sender, EventArgs e)
        {
            if (Flag_leng)
            {
                this.textBox1_File_Name.Text = "Файл.cs";
            }
            else
            {
                this.textBox1_File_Name.Text = "File.cs";
            }
        }

        private void BunifuImageButton1_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
