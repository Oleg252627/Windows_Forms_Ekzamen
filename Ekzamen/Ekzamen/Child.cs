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
    public partial class Child : Form
    {
        
        public string putFile { get; set; }
        private bool Flag_leng;
        private bool Flag_tems;
        public bool Sintax { get; set; }
        
        public Child(bool flag_thems,bool flag_lengv)
        {
            InitializeComponent();
            Flag_leng = flag_lengv;
            Flag_tems = flag_thems;
            if (flag_thems)
            {
                this.richTextBox1_Child.BackColor = Color.FromArgb(30, 30, 30);
                this.richTextBox1_Child.ForeColor = SystemColors.ControlDark;
                this.statusStrip1.BackColor = Color.Brown;
                this.label1_Stroka_ostoiniy.BackColor= Color.Brown;
                foreach (var VARIABLE in this.contextMenuStrip1.Items)
                {
                    if (VARIABLE is ToolStripMenuItem)
                    {
                        (VARIABLE as ToolStripMenuItem).BackColor= Color.FromArgb(45,45,48);
                        (VARIABLE as ToolStripMenuItem).ForeColor = SystemColors.ControlDark;
                    }
                    else if (VARIABLE is ToolStripSeparator)
                    {
                        (VARIABLE as ToolStripSeparator).BackColor= Color.FromArgb(45, 45, 48);
                        (VARIABLE as ToolStripSeparator).ForeColor = SystemColors.ControlDark;
                    }
                }
            }
            else
            {
                this.richTextBox1_Child.BackColor = SystemColors.Window;
                this.richTextBox1_Child.ForeColor = SystemColors.ControlText;
                this.statusStrip1.BackColor = Color.FromArgb(41, 56, 85);
                this.label1_Stroka_ostoiniy.BackColor = Color.FromArgb(41, 56, 85);
                foreach (var VARIABLE in this.contextMenuStrip1.Items)
                {
                    if (VARIABLE is ToolStripMenuItem)
                    {
                        (VARIABLE as ToolStripMenuItem).BackColor = Color.FromArgb(213, 219, 233);
                        (VARIABLE as ToolStripMenuItem).ForeColor = SystemColors.ControlText;
                    }
                    else if(VARIABLE is ToolStripSeparator)
                    {
                        (VARIABLE as ToolStripSeparator).BackColor = Color.FromArgb(213, 219, 233);
                        (VARIABLE as ToolStripSeparator).ForeColor = SystemColors.ControlDark;
                    }
                }
            }

            if (flag_lengv)
            {
                label1_Stroka_ostoiniy.Text = "Строка: 1| Столбец: 1";
                this.USA_PasteToolStripMenuItem.Text = "Вставить";
                this.RUS_CatToolStripMenuItem.Text = "Вырезать";
                this.RUS_CopyToolStripMenuItem.Text = "Копировать";
                this.RUS_ComitToolStripMenuItem.Text = "Закомментировать";
                this.RUS_UnComitToolStripMenuItem.Text = "Раскомментировать";
            }
            else
            {
                label1_Stroka_ostoiniy.Text = "Line: 1 | Column: 1";
                this.USA_PasteToolStripMenuItem.Text = "Puste";
                this.RUS_CatToolStripMenuItem.Text = "Cut";
                this.RUS_CopyToolStripMenuItem.Text = "Copy";
                this.RUS_ComitToolStripMenuItem.Text = "Comment";
                this.RUS_UnComitToolStripMenuItem.Text = "Uncomment";
            }
        }
        private void Child_Load(object sender, EventArgs e)
        {
            this.richTextBox1_Child.MouseClick += RichTextBox1_Child_MouseClick;
            this.richTextBox1_Child.KeyDown += RichTextBox1_Child_KeyDown;
            this.richTextBox1_Child.KeyPress += RichTextBox1_Child_KeyPress;
            this.richTextBox1_Child.SelectionChanged += RichTextBox1_Child_SelectionChanged;
            this.RUS_CatToolStripMenuItem.Click += RUS_CatToolStripMenuItem_Click;
            this.RUS_CopyToolStripMenuItem.Click += RUS_CopyToolStripMenuItem_Click;
            this.USA_PasteToolStripMenuItem.Click += USA_PasteToolStripMenuItem_Click;
            this.RUS_ComitToolStripMenuItem.Click += RUS_ComitToolStripMenuItem_Click;
            this.RUS_UnComitToolStripMenuItem.Click += RUS_UnComitToolStripMenuItem_Click;
        }

        private void RUS_UnComitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1_Child.SelectionLength != 0)
            {
                String bufer = Clipboard.GetText();
                int selStart = this.richTextBox1_Child.SelectionStart;
                int selLen = this.richTextBox1_Child.SelectionLength;
                String selectStr, ComentSelectStr; ;
                selectStr = this.richTextBox1_Child.Text.Substring(selStart, selLen);
                this.richTextBox1_Child.Cut();
                ComentSelectStr = selectStr.Trim("/*".ToCharArray());
                Clipboard.Clear();
                Clipboard.SetText(ComentSelectStr);
                this.richTextBox1_Child.Paste();
                Clipboard.Clear();
                this.richTextBox1_Child.Select(selStart, ComentSelectStr.Length);
                if (Flag_leng)
                {
                    this.richTextBox1_Child.SelectionColor = SystemColors.ControlDark;
                }
                else
                {
                    this.richTextBox1_Child.SelectionColor = SystemColors.ControlText;
                }
                Clipboard.SetText(bufer);
            }
        }

        private void RUS_ComitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1_Child.SelectionLength != 0)
            {
                String bufer = Clipboard.GetText();
                int selStart = this.richTextBox1_Child.SelectionStart;
                int selLen = this.richTextBox1_Child.SelectionLength;
                String selectStr, ComentSelectStr; ;
                selectStr = this.richTextBox1_Child.Text.Substring(selStart, selLen);
                this.richTextBox1_Child.Cut();
                ComentSelectStr = "/*" + selectStr + "*/";
                Clipboard.Clear();
                Clipboard.SetText(ComentSelectStr);
                this.richTextBox1_Child.Paste();
                Clipboard.Clear();
                this.richTextBox1_Child.Select(selStart, ComentSelectStr.Length);
                this.richTextBox1_Child.SelectionColor = Color.DarkGreen;
                Clipboard.SetText(bufer);
            }
        }

        private void USA_PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1_Child.Paste();
        }

        private void RUS_CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1_Child.Copy();
        }

        private void RUS_CatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1_Child.Cut();
        }

        private void RichTextBox1_Child_SelectionChanged(object sender, EventArgs e)
        {
            
        }
        public void SintexRichTexBox()
        {
            string[] tags =
            {
                "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class", "const",
                "continue", "decimal", "default",
                "delegate", "do", "double", "else", "enum", "event", "explicit", "extern", "false", "finally", "fixed",
                "float", "for", "foreach", "goto", "if", "implicit", "in", "int",
                "interface", "internal", "is", "lock", "long", "namespace", "new", "null", "object", "operator", "out",
                "override", "params", "private", "protected", "public", "readonly", "ref", "return",
                "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch", "this",
                "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort",
                "using", "virtual", "void", "volatile", "while","partial"
                
            };
            foreach (string VARIABLE in tags)
            {
                Show_RichTextBox(VARIABLE, Color.RoyalBlue);
            }
        }
        private void Show_RichTextBox(String tags, Color color)
        {
            int str= richTextBox1_Child.SelectionStart;
            int line = richTextBox1_Child.GetLineFromCharIndex(richTextBox1_Child.SelectionStart);
            int col = richTextBox1_Child.SelectionLength;
            richTextBox1_Child.SelectionStart = 0;
            richTextBox1_Child.SelectionLength = 0;
            
            int index = richTextBox1_Child.Find(tags,
                richTextBox1_Child.SelectionStart + richTextBox1_Child.SelectionLength,
                str+ richTextBox1_Child.SelectionLength, RichTextBoxFinds.WholeWord);
            while (index != -1)
            {
                richTextBox1_Child.SelectionColor = color;
                index = richTextBox1_Child.Find(tags,
                    richTextBox1_Child.SelectionStart + richTextBox1_Child.SelectionLength,
                    str + richTextBox1_Child.SelectionLength, RichTextBoxFinds.WholeWord);
            }
            richTextBox1_Child.SelectionStart = str;
            richTextBox1_Child.SelectionLength = col;
            if (Flag_tems)
            {
                richTextBox1_Child.SelectionColor = SystemColors.ControlDark;
            }
            else
            {
                richTextBox1_Child.SelectionColor = SystemColors.ControlText;
            }
        }

        private void RichTextBox1_Child_KeyPress(object sender, KeyPressEventArgs e)
        {
            Stroca_Sostoyniy();
            if (putFile.EndsWith("cs"))
            {
                if (Sintax)
                {
                    SintexRichTexBox();
                }
            }
            else 
            {
                if (Sintax)
                {
                    SintexRichTexBox();
                }
            }
        }

        private void RichTextBox1_Child_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left ||
                e.KeyCode == Keys.Right||e.KeyCode==Keys.Space||e.KeyCode==Keys.BrowserBack)
            {
                Stroca_Sostoyniy();
            }
        }

        private void RichTextBox1_Child_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Stroca_Sostoyniy();
            }
        }

        private void Stroca_Sostoyniy()
        {
            int line = richTextBox1_Child.GetLineFromCharIndex(richTextBox1_Child.SelectionStart);
            int column = richTextBox1_Child.SelectionStart - richTextBox1_Child.GetFirstCharIndexFromLine(line);
            if (Flag_leng)
            {
                label1_Stroka_ostoiniy.Text = $"Строка: {( line+1).ToString()} | Столбец: {(column+1).ToString()}";
            }
            else
            {
                label1_Stroka_ostoiniy.Text = $"Line: {(line+1).ToString()} | Column: {(column+1).ToString()}";
            }
            Update();
        }
    }
}
