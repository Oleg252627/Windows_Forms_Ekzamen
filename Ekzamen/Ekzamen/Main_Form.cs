using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekzamen
{
    public partial class Main_Form : Form
    {
        private bool flag_Maxisimized = true;
        private bool flag_Langv = true;
        private bool flag_Thems = true;
        private String File_Name;
        private static int count = 0;
        public Main_Form()
        {
            InitializeComponent();
            this.menuStrip1_USA.Visible = false;
            this.toolStrip1_USA.Visible = false;
            this.pictureBox2_sav.Visible = false;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            this.bunifuImageButton1_Minimized.Click += BunifuImageButton1_Minimized_Click;
            this.bunifuImageButton1_Maxisimized.Click += BunifuImageButton1_Maxisimized_Click;
            this.bunifuImageButton1_Close.Click += BunifuImageButton1_Close_Click;
            this.bunifuImageButton1_Lengvich.Click += BunifuImageButton1_Serch_Click;

            this.Create_ToolStripMenuItem.Click += Create_ToolStripMenuItem_Click;
            this.USA_newFileToolStripMenuItem.Click+= Create_ToolStripMenuItem_Click;
            this.RUS_Create_toolStripButton1.Click+= Create_ToolStripMenuItem_Click;
            this.USA_Create_toolStripButton24.Click+= Create_ToolStripMenuItem_Click;

            this.Open_ToolStripMenuItem.Click += Open_ToolStripMenuItem_Click;
            this.USA_openToolStripMenuItem.Click+= Open_ToolStripMenuItem_Click;
            this.RUS_Open_toolStripButton2.Click+= Open_ToolStripMenuItem_Click;
            this.USA_Open_toolStripButton25.Click+= Open_ToolStripMenuItem_Click;

            this.Save_ToolStripMenuItem.Click += Save_ToolStripMenuItem_Click;
            this.USA_saveToolStripMenuItem.Click+= Save_ToolStripMenuItem_Click;
            this.RUS_Save_toolStripButton3.Click+= Save_ToolStripMenuItem_Click;
            this.USA_Save_toolStripButton26.Click+= Save_ToolStripMenuItem_Click;

            this.Save_as_ToolStripMenuItem.Click += Save_as_ToolStripMenuItem_Click;
            this.USA_saveAsToolStripMenuItem.Click+= Save_as_ToolStripMenuItem_Click;
            this.RUS_Save_as_toolStripButton4.Click+= Save_as_ToolStripMenuItem_Click;
            this.USA_Save_all_toolStripButton27.Click+= Save_as_ToolStripMenuItem_Click;

            this.Censel_ToolStripMenuItem.Click += Censel_ToolStripMenuItem_Click;
            this.USA_undoToolStripMenuItem.Click+= Censel_ToolStripMenuItem_Click;
            this.USA_Undo_toolStripButton28.Click+= Censel_ToolStripMenuItem_Click;
            this.RUS_Undo_toolStripButton5.Click+= Censel_ToolStripMenuItem_Click;

            this.RUS_Redo_toolStripButton6.Click += RUS_Redo_toolStripButton6_Click;
            this.USA_Redo_toolStripButton29.Click += RUS_Redo_toolStripButton6_Click;

            this.Cut_ToolStripMenuItem.Click += Cut_ToolStripMenuItem_Click;
            this.USA_cutToolStripMenuItem.Click+= Cut_ToolStripMenuItem_Click;
            this.RUS_Cut_toolStripButton8.Click+= Cut_ToolStripMenuItem_Click;
            this.USA_Cut_toolStripButton31.Click+= Cut_ToolStripMenuItem_Click;

            this.Copy_ToolStripMenuItem.Click += Copy_ToolStripMenuItem_Click;
            this.USA_copyToolStripMenuItem.Click+= Copy_ToolStripMenuItem_Click;
            this.RUS_Copy_toolStripButton9.Click+= Copy_ToolStripMenuItem_Click;
            this.USA_Copy_toolStripButton32.Click+= Copy_ToolStripMenuItem_Click;

            this.Paste_ToolStripMenuItem.Click += Paste_ToolStripMenuItem_Click;
            this.USA_pasteToolStripMenuItem.Click+= Paste_ToolStripMenuItem_Click;
            this.RUS_Paset_toolStripButton10.Click+= Paste_ToolStripMenuItem_Click;
            this.USA_Paste_toolStripButton33.Click+= Paste_ToolStripMenuItem_Click;

            this.Delete_ToolStripMenuItem.Click += Delete_ToolStripMenuItem_Click;
            this.USA_removeToolStripMenuItem.Click+= Delete_ToolStripMenuItem_Click;
            this.RUS_Del_toolStripButton11.Click+= Delete_ToolStripMenuItem_Click;
            this.USA_Del_toolStripButton34.Click+= Delete_ToolStripMenuItem_Click;

            this.For_color_ToolStripMenuItem.Click += For_color_ToolStripMenuItem_Click;
            this.USA_foreColorToolStripMenuItem.Click+= For_color_ToolStripMenuItem_Click;
            this.RUS_ForColor_toolStripButton12.Click+= For_color_ToolStripMenuItem_Click;
            this.USA_ForeColor_toolStripButton35.Click+= For_color_ToolStripMenuItem_Click;

            this.Back_color_ToolStripMenuItem.Click += Back_color_ToolStripMenuItem_Click;
            this.USA_backColorToolStripMenuItem.Click+= Back_color_ToolStripMenuItem_Click;
            this.RUS_BackColor_toolStripButton13.Click+= Back_color_ToolStripMenuItem_Click;
            this.USA_BackColor_toolStripButton36.Click+= Back_color_ToolStripMenuItem_Click;

            this.Cascade_ToolStripMenuItem.Click += Cascade_ToolStripMenuItem_Click;
            this.USA_cascadeToolStripMenuItem.Click+= Cascade_ToolStripMenuItem_Click;
            this.RUS_Cascade_toolStripButton14.Click+= Cascade_ToolStripMenuItem_Click;
            this.USA_Cascade_toolStripButton37.Click+= Cascade_ToolStripMenuItem_Click;

            this.Horizontal_ToolStripMenuItem.Click += Horizontal_ToolStripMenuItem_Click;
            this.USA_horizontalToolStripMenuItem.Click+= Horizontal_ToolStripMenuItem_Click;
            this.RUS_Horizontal_toolStripButton15.Click += Horizontal_ToolStripMenuItem_Click;
            this.USA_Horizontal_toolStripButton38.Click += Horizontal_ToolStripMenuItem_Click;

            this.Vertical_ToolStripMenuItem.Click += Vertical_ToolStripMenuItem_Click;
            this.USA_verticalToolStripMenuItem.Click += Vertical_ToolStripMenuItem_Click;
            this.RUS_Verticale_toolStripButton16.Click += Vertical_ToolStripMenuItem_Click;
            this.USA_Vertical_toolStripButton39.Click += Vertical_ToolStripMenuItem_Click;

            this.Minimize_all_ToolStripMenuItem.Click += Minimize_all_ToolStripMenuItem_Click;
            this.USA_minimizeAllToolStripMenuItem.Click += Minimize_all_ToolStripMenuItem_Click;
            this.RUS_Minimize_all_toolStripButton17.Click += Minimize_all_ToolStripMenuItem_Click;
            this.USA_Minimize_All_toolStripButton40.Click += Minimize_all_ToolStripMenuItem_Click;

            this.Maxisimized_all_ToolStripMenuItem.Click += Maxisimized_ToolStripMenuItem_Click;
            this.USA_maximizeAllToolStripMenuItem.Click += Maxisimized_ToolStripMenuItem_Click;
            this.RUS_Maxisimize_all_toolStripButton18.Click += Maxisimized_ToolStripMenuItem_Click;
            this.USA_Maximize_All_toolStripButton41.Click += Maxisimized_ToolStripMenuItem_Click;

            this.Minimized_ToolStripMenuItem.Click += Minimized_ToolStripMenuItem_Click;
            this.USA_minimizeToolStripMenuItem.Click += Minimized_ToolStripMenuItem_Click;
            this.RUS_Minimized_toolStripButton20.Click += Minimized_ToolStripMenuItem_Click;
            this.USA_Minimize_toolStripButton43.Click += Minimized_ToolStripMenuItem_Click;

            this.Maxisimized_ToolStripMenuItem.Click += Maxisimized_ToolStripMenuItem_Click1;
            this.USA_maximizeToolStripMenuItem.Click += Maxisimized_ToolStripMenuItem_Click1;
            this.RUS_Maxisimized_toolStripButton21.Click += Maxisimized_ToolStripMenuItem_Click1;
            this.USA_Maximize_toolStripButton44.Click += Maxisimized_ToolStripMenuItem_Click1;

            this.Close_all_ToolStripMenuItem.Click += Close_all_ToolStripMenuItem_Click;
            this.USA_closeAllToolStripMenuItem.Click += Close_all_ToolStripMenuItem_Click;
            this.RUS_Del_all_toolStripButton19.Click += Close_all_ToolStripMenuItem_Click;
            this.USA_Close_All_toolStripButton42.Click += Close_all_ToolStripMenuItem_Click;

            this.RUS_Coment_toolStripButton22.Click += RUS_Coment_toolStripButton22_Click;
            this.USA_Comment_toolStripButton45.Click+= RUS_Coment_toolStripButton22_Click;

            this.RUS_Not_Coment_toolStripButton23.Click += RUS_Not_Coment_toolStripButton23_Click;
            this.USA_Uncomment_toolStripButton46.Click+= RUS_Not_Coment_toolStripButton23_Click;

            this.RUS_Search_toolStripButton1.Click += RUS_Search_toolStripButton1_Click;
            this.USA_Search_toolStripButton1.Click+= RUS_Search_toolStripButton1_Click;
            this.Serch_ToolStripMenuItem.Click+= RUS_Search_toolStripButton1_Click;
            this.USA_serchToolStripMenuItem.Click+= RUS_Search_toolStripButton1_Click;

            this.White_ToolStripMenuItem.Click += White_ToolStripMenuItem_Click;
            this.USA_lightToolStripMenuItem.Click+= White_ToolStripMenuItem_Click;
            this.Dark_ToolStripMenuItem.Click+= White_ToolStripMenuItem_Click;
            this.USA_darkToolStripMenuItem.Click+= White_ToolStripMenuItem_Click;

            this.Selected_AllToolStripMenuItem.Click += Selected_AllToolStripMenuItem_Click;
            this.USA_selectAllToolStripMenuItem.Click+= Selected_AllToolStripMenuItem_Click;

            this.Time_ToolStripMenuItem.Click += Time_ToolStripMenuItem_Click;
            this.dateTimeToolStripMenuItem.Click+= Time_ToolStripMenuItem_Click;

            this.C_ToolStripMenuItem.Click += C_ToolStripMenuItem_Click;
            this.USA_cToolStripMenuItem1.Click+= C_ToolStripMenuItem_Click;

            this.tXTToolStripMenuItem.Click += TXTToolStripMenuItem_Click;
            this.tXTToolStripMenuItem1.Click+= TXTToolStripMenuItem_Click;

            this.Produkt_ToolStripMenuItem.Click += Produkt_ToolStripMenuItem_Click;
            this.USA_aboutTheProductToolStripMenuItem.Click+= Produkt_ToolStripMenuItem_Click;

            this.timer1.Tick += Timer1_Tick;
        }
        private void Timer_Stop()
        {
            this.pictureBox2_sav.Visible = false;
            this.timer1.Stop();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Timer_Stop();
        }

        private void Produkt_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Program formProgram=new Form_Program(flag_Thems,flag_Langv);
            this.bunifuTransition1_product.Show(formProgram);
        }

        public void Not_sintex()
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
            if (flag_Thems)
            {
                foreach (string VARIABLE in tags)
                {
                    Show_RichTextBox(VARIABLE, SystemColors.ControlDark);
                }
            }
            else
            {
                foreach (string VARIABLE in tags)
                {
                    Show_RichTextBox(VARIABLE, SystemColors.ControlText);
                }
            }
        }
        private void TXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                Child child = (Child)this.ActiveControl;
                child.Sintax = false;
                Not_sintex();
            }
        }

        public void Sintex()
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
                Show_RichTextBox(VARIABLE,Color.RoyalBlue);
            }
        }

        private void Show_RichTextBox(String tags, Color color)
        {
            foreach (var VARIABLE in ActiveMdiChild.Controls)
            {
                if (VARIABLE is RichTextBox)
                {
                    (VARIABLE as RichTextBox).SelectionStart = 0;
                    (VARIABLE as RichTextBox).SelectionLength = 0;
                    int i = (VARIABLE as RichTextBox).SelectionStart;
                    int index = (VARIABLE as RichTextBox).Find(tags,
                        (VARIABLE as RichTextBox).SelectionStart + (VARIABLE as RichTextBox).SelectionLength,
                        (VARIABLE as RichTextBox).Text.Length - 1, RichTextBoxFinds.WholeWord);
                    while (index!=-1)
                    {
                        (VARIABLE as RichTextBox).SelectionColor = color;
                         index = (VARIABLE as RichTextBox).Find(tags,
                            (VARIABLE as RichTextBox).SelectionStart + (VARIABLE as RichTextBox).SelectionLength,
                            (VARIABLE as RichTextBox).Text.Length - 1, RichTextBoxFinds.WholeWord);
                    }

                    (VARIABLE as RichTextBox).SelectionStart = i;
                    (VARIABLE as RichTextBox).SelectionLength = 0;
                }
            }
        }
        private void C_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            if (this.MdiChildren.Length>0)
            {
                Child child = (Child) this.ActiveControl;
                child.Sintax = true;
                Sintex();
            }
            
        }

        private void Time_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var VARIABLE in ActiveMdiChild.Controls)
            {
                if (VARIABLE is RichTextBox)
                {
                    if ((VARIABLE as RichTextBox).SelectionLength == 0)
                    {
                        String bufer = Clipboard.GetText();
                        Clipboard.Clear();
                        Clipboard.SetText(DateTime.Now.ToShortDateString()+" "+ DateTime.Now.ToShortTimeString());
                        (VARIABLE as RichTextBox).Paste();
                        Clipboard.Clear();
                        Clipboard.SetText(bufer);
                    }
                }
            }
        }

        private void Selected_AllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var VARIABLE in ActiveMdiChild.Controls)
            {
                if (VARIABLE is RichTextBox)
                {
                    (VARIABLE as RichTextBox).SelectAll();
                }
            }
        }

        private void White_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Dark_ToolStripMenuItem.Checked || USA_darkToolStripMenuItem.Checked)
            {
                flag_Thems = false;
                this.White_ToolStripMenuItem.Checked = true;
                this.USA_lightToolStripMenuItem.Checked = true;
                this.Dark_ToolStripMenuItem.Checked = false;
                this.USA_darkToolStripMenuItem.Checked = false;
                this.panel1_Control.BackColor= Color.FromArgb(41, 56, 85);
                this.menuStrip1_Rus.BackColor = Color.FromArgb(213, 219, 233);
                this.menuStrip1_USA.BackColor= Color.FromArgb(213, 219, 233);
                foreach (var VARIABLE in menuStrip1_Rus.Items)
                {
                    (VARIABLE as ToolStripMenuItem).ForeColor=Color.Black;
                    foreach (ToolStripMenuItem item in (VARIABLE as ToolStripMenuItem).DropDownItems)
                    {
                        item.BackColor= Color.FromArgb(213, 219, 233);
                        item.ForeColor = Color.Black;
                    }
                }
                foreach (var VARIABLE in menuStrip1_USA.Items)
                {
                    (VARIABLE as ToolStripMenuItem).ForeColor = Color.Black;
                    foreach (ToolStripMenuItem item in (VARIABLE as ToolStripMenuItem).DropDownItems)
                    {
                        item.BackColor = Color.FromArgb(213, 219, 233);
                        item.ForeColor = Color.Black;
                    }
                }
                this.toolStrip1_Rus.BackColor= Color.FromArgb(213, 219, 233);
                this.toolStrip1_USA.BackColor= Color.FromArgb(213, 219, 233);
                this.panel1_Footer.BackColor= Color.FromArgb(41, 56, 85);
            }
            else
            {
                flag_Thems = true;
                this.White_ToolStripMenuItem.Checked = false;
                this.USA_lightToolStripMenuItem.Checked = false;
                this.Dark_ToolStripMenuItem.Checked = true;
                this.USA_darkToolStripMenuItem.Checked = true;
                this.panel1_Control.BackColor = Color.FromArgb(45, 45, 48);
                this.menuStrip1_Rus.BackColor = Color.FromArgb(45, 45, 48);
                this.menuStrip1_USA.BackColor = Color.FromArgb(45, 45, 48);
                foreach (var VARIABLE in menuStrip1_Rus.Items)
                {
                    (VARIABLE as ToolStripMenuItem).ForeColor = Color.FromArgb(192, 0, 0);
                    foreach (ToolStripMenuItem item in (VARIABLE as ToolStripMenuItem).DropDownItems)
                    {
                        item.BackColor = Color.FromArgb(45, 45, 48);
                        item.ForeColor = SystemColors.ControlDark;
                    }
                }
                foreach (var VARIABLE in menuStrip1_USA.Items)
                {
                    (VARIABLE as ToolStripMenuItem).ForeColor = Color.FromArgb(192, 0, 0);
                    foreach (ToolStripMenuItem item in (VARIABLE as ToolStripMenuItem).DropDownItems)
                    {
                        item.BackColor = Color.FromArgb(45, 45, 48);
                        item.ForeColor = SystemColors.ControlDark;
                    }
                }
                this.toolStrip1_Rus.BackColor = Color.FromArgb(45, 45, 48);
                this.toolStrip1_USA.BackColor = Color.FromArgb(45, 45, 48);
                this.panel1_Footer.BackColor = Color.Brown;
            }
        }

        private void Messag_Box()
        {
            if (flag_Langv)
            {
                MessageBox.Show("Создайте или откройте фаил!", "Оповещение", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Create or open file!", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void RUS_Search_toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                Search search=new Search(this,flag_Thems,flag_Langv);
                search.Show();
            }
            else
            {
                Messag_Box();
            }
        }

        public void Serch_Button_Word(string word)
        {
            foreach (var VARIABLE in ActiveMdiChild.Controls)
            {
                if (VARIABLE is RichTextBox)
                {
                    if ((VARIABLE as RichTextBox).Text.Contains(word))
                    {
                        int col=(VARIABLE as RichTextBox).Find(word, (VARIABLE as RichTextBox).SelectionStart + (VARIABLE as RichTextBox).SelectionLength, (VARIABLE as RichTextBox).Text.Length - 1, RichTextBoxFinds.MatchCase);
                        if (col == -1)
                        {
                            if (flag_Langv)
                            {
                                MessageBox.Show("Совпадений нет!", "Оповещение", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("No matches!", "Information", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                return;
                            }
                        }
                        (VARIABLE as RichTextBox).Focus();
                    }
                }
            }
                
        }

        public void Add_Word(string word)
        {
            foreach (var VARIABLE in ActiveMdiChild.Controls)
            {
                if (VARIABLE is RichTextBox)
                {
                    if ((VARIABLE as RichTextBox).SelectionLength != 0)
                    {
                        String bufer = Clipboard.GetText();
                        (VARIABLE as RichTextBox).Cut();
                        Clipboard.Clear();
                        Clipboard.SetText(word);
                        (VARIABLE as RichTextBox).Paste();
                        Clipboard.Clear();
                        Clipboard.SetText(bufer);
                    }
                    else
                    {
                        if (flag_Langv)
                        {
                            MessageBox.Show("Выберите слово для замены!", "Оповешение", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Choose a word to replace!", "Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        public void Serch_Word(string word)
        {
            foreach (var VARIABLE in ActiveMdiChild.Controls)
            {
                if (VARIABLE is RichTextBox)
                {
                    if ((VARIABLE as RichTextBox).Text.Contains(word))
                    {
                        int index = (VARIABLE as RichTextBox).Text.IndexOf(word);

                        int start = 0;
                        int end = (VARIABLE as RichTextBox).Text.LastIndexOf(word);

                        (VARIABLE as RichTextBox).SelectAll();
                        if (flag_Thems)
                        {
                            (VARIABLE as RichTextBox).SelectionBackColor = Color.FromArgb(30, 30, 30);
                        }
                        else
                        {
                            (VARIABLE as RichTextBox).SelectionBackColor = SystemColors.Window;
                        }
                        while (start < end)
                        {
                            (VARIABLE as RichTextBox).Find(word, start, (VARIABLE as RichTextBox).TextLength, RichTextBoxFinds.MatchCase);

                            (VARIABLE as RichTextBox).SelectionBackColor = Color.SaddleBrown;

                            start = (VARIABLE as RichTextBox).Text.IndexOf(word, start) + 1;
                        }

                        (VARIABLE as RichTextBox).SelectionStart = 0;
                        (VARIABLE as RichTextBox).SelectionLength = 0;
                    }
                }
            }
        }

        public void Delete_BackColor()
        {
            foreach (var item in this.MdiChildren)
            {
                if (item is Child)
                {
                    foreach (var VARIABLE in (item as Child).Controls)
                    {
                        if (VARIABLE is RichTextBox)
                        {
                            (VARIABLE as RichTextBox).SelectAll();
                            if (flag_Thems)
                            {
                                (VARIABLE as RichTextBox).SelectionBackColor = Color.FromArgb(30, 30, 30);
                            }
                            else
                            {
                                (VARIABLE as RichTextBox).SelectionBackColor = SystemColors.Window;
                            }
                            (VARIABLE as RichTextBox).Select(0, 0);
                        }
                    }
                }
            }
        }

        private void RUS_Not_Coment_toolStripButton23_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                foreach (var VARIABLE in ActiveMdiChild.Controls)
                {
                    if (VARIABLE is RichTextBox)
                    {
                        if ((VARIABLE as RichTextBox).SelectionLength != 0)
                        {
                            String bufer = Clipboard.GetText();
                            int selStart = (VARIABLE as RichTextBox).SelectionStart;
                            int selLen = (VARIABLE as RichTextBox).SelectionLength;
                            String selectStr, ComentSelectStr; ;
                            selectStr = (VARIABLE as RichTextBox).Text.Substring(selStart, selLen);
                            (VARIABLE as RichTextBox).Cut();
                            ComentSelectStr = selectStr.Trim("/*".ToCharArray());
                            Clipboard.Clear();
                            Clipboard.SetText(ComentSelectStr);
                            (VARIABLE as RichTextBox).Paste();
                            Clipboard.Clear();
                            (VARIABLE as RichTextBox).Select(selStart, ComentSelectStr.Length);
                            if (flag_Thems)
                            {
                                (VARIABLE as RichTextBox).SelectionColor = SystemColors.ControlDark;
                            }
                            else
                            {
                                (VARIABLE as RichTextBox).SelectionColor = SystemColors.ControlText;
                            }
                            Clipboard.SetText(bufer);
                        }
                    }
                }
            }
            else
            {
                Messag_Box();
            }
        }

        private void RUS_Coment_toolStripButton22_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                foreach (var VARIABLE in ActiveMdiChild.Controls)
                {
                    if (VARIABLE is RichTextBox)
                    {
                        if ((VARIABLE as RichTextBox).SelectionLength != 0)
                        {
                            String bufer = Clipboard.GetText();
                            int selStart = (VARIABLE as RichTextBox).SelectionStart;
                            int selLen = (VARIABLE as RichTextBox).SelectionLength;
                            String  selectStr, ComentSelectStr;;
                            selectStr = (VARIABLE as RichTextBox).Text.Substring(selStart, selLen);
                            (VARIABLE as RichTextBox).Cut();
                            ComentSelectStr = "/*" + selectStr + "*/";
                            Clipboard.Clear();
                            Clipboard.SetText(ComentSelectStr);
                            (VARIABLE as RichTextBox).Paste();
                            Clipboard.Clear();
                            (VARIABLE as RichTextBox).Select(selStart, ComentSelectStr.Length);
                            (VARIABLE as RichTextBox).SelectionColor = Color.DarkGreen;
                            Clipboard.SetText(bufer);
                        }
                    }
                }
            }
            else
            {
                Messag_Box();
            }
           
        }

        private void Close_all_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                foreach (var item in this.MdiChildren)
                {
                    (item as Child).Close();
                }
            }
            else
            {
                Messag_Box();
            }
        }

        private void Maxisimized_ToolStripMenuItem_Click1(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                ActiveMdiChild.WindowState = FormWindowState.Maximized;
            }
            else
            {
                Messag_Box();
            }
        }

        private void Minimized_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                ActiveMdiChild.WindowState = FormWindowState.Minimized;
            }
            else
            {
                Messag_Box();
            }
        }

        private void Maxisimized_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                foreach (var item in this.MdiChildren)
                {
                    (item as Child).WindowState = FormWindowState.Maximized;
                }
            }
            else
            {
                Messag_Box();
            }
        }

        private void Minimize_all_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                foreach (var item in this.MdiChildren)
                {
                    (item as Child).WindowState = FormWindowState.Minimized;
                }
            }
            else
            {
                Messag_Box();
            }
        }

        private void Vertical_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                LayoutMdi(MdiLayout.TileVertical);
            }
            else
            {
                Messag_Box();
            }
        }

        private void Horizontal_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                LayoutMdi(MdiLayout.TileHorizontal);
            }
            else
            {
                Messag_Box();
            }
        }

        private void Cascade_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.LayoutMdi(MdiLayout.Cascade);
            }
            else
            {
                Messag_Box();
            }
        }

        private void Back_color_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                Child child = this.ActiveMdiChild as Child;
                foreach (var VARIABLE in child.Controls)
                {
                    if (VARIABLE is RichTextBox)
                    {
                        ColorDialog colorDialog=new ColorDialog();
                        colorDialog.Color = (VARIABLE as RichTextBox).BackColor;
                        if (colorDialog.ShowDialog() == DialogResult.OK)
                        {
                            (VARIABLE as RichTextBox).BackColor = colorDialog.Color;
                        }
                    }
                }
            }
            else
            {
                Messag_Box();
            }
        }

        private void For_color_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                Child child=this.ActiveMdiChild as Child;
                foreach (var VARIABLE in child.Controls)
                {
                    if (VARIABLE is RichTextBox)
                    {
                        FontDialog font=new FontDialog();
                        font.Font = (VARIABLE as RichTextBox).SelectionFont;
                        font.Color= (VARIABLE as RichTextBox).SelectionColor;
                        font.ShowColor = true;
                        if (font.ShowDialog() == DialogResult.OK)
                        {
                            (VARIABLE as RichTextBox).SelectionFont = font.Font;
                            (VARIABLE as RichTextBox).SelectionColor = font.Color;
                        }
                    }
                }
            }
            else
            {
                Messag_Box();
            }
        }

        private void Delete_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                foreach (var VARIABLE in this.ActiveMdiChild.Controls)
                {
                    if (VARIABLE is RichTextBox)
                    {
                        (VARIABLE as RichTextBox).SelectedText = "";
                    }
                }
            }
            else
            {
                Messag_Box();
            }
        }

        private void Paste_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                foreach (var VARIABLE in this.ActiveMdiChild.Controls)
                {
                    if (VARIABLE is RichTextBox)
                    {
                        (VARIABLE as RichTextBox).Paste();
                    }
                }
            }
            else
            {
                Messag_Box();
            }
        }

        private void Copy_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                foreach (var VARIABLE in this.ActiveMdiChild.Controls)
                {
                    if (VARIABLE is RichTextBox)
                    {
                        (VARIABLE as RichTextBox).Copy();
                    }
                }
            }
            else
            {
                Messag_Box();
            }
        }

        private void Cut_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                foreach (var VARIABLE in this.ActiveMdiChild.Controls)
                {
                    if (VARIABLE is RichTextBox)
                    {
                        (VARIABLE as RichTextBox).Cut();
                    }
                }
            }
            else
            {
                Messag_Box();
            }
        }

        private void RUS_Redo_toolStripButton6_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                foreach (var VARIABLE in this.ActiveMdiChild.Controls)
                {
                    if (VARIABLE is RichTextBox)
                    {
                        (VARIABLE as RichTextBox).Redo();
                    }
                }
            }
            else
            {
                Messag_Box();
            }
        }

        private void Censel_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                foreach (var VARIABLE in this.ActiveMdiChild.Controls)
                {
                    if (VARIABLE is RichTextBox)
                    {
                        (VARIABLE as RichTextBox).Undo();
                    }
                }
            }
            else
            {
                Messag_Box();
            }
        }

        private void Save_as_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                SaveFileDialog saveFile=new SaveFileDialog();
                saveFile.Filter = "TXT file (*.txt)|*.txt|RTF file(*.rtf)|*.rtf|CS(*.cs)|*.cs|All file(*.*)|*.*";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    Child child = ActiveMdiChild as Child;
                    if (saveFile.FileName.EndsWith("rtf"))
                    {
                        foreach (var VARIABLE in child.Controls)
                        {
                            if (VARIABLE is RichTextBox)
                            {
                                (VARIABLE as RichTextBox).SaveFile(saveFile.FileName, RichTextBoxStreamType.RichText);
                            }
                        }
                    }
                    else
                    {
                        foreach (var VARIABLE in child.Controls)
                        {
                            if (VARIABLE is RichTextBox)
                            {
                                (VARIABLE as RichTextBox).SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
                            }
                        }
                    }
                    this.pictureBox2_sav.Visible = true;
                    this.timer1.Start();
                }
                else
                {
                    Messag_Box();
                }
            }
        }

        private void Save_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                Child child= ActiveMdiChild as Child;
                if (child.putFile.EndsWith("rtf"))
                {
                    foreach (var VARIABLE in child.Controls)
                    {
                        if (VARIABLE is RichTextBox)
                        {
                            (VARIABLE as RichTextBox).SaveFile(child.putFile, RichTextBoxStreamType.RichText);
                        }
                    }
                }
                else
                {
                    foreach (var VARIABLE in child.Controls)
                    {
                        if (VARIABLE is RichTextBox)
                        {
                            (VARIABLE as RichTextBox).SaveFile(child.putFile, RichTextBoxStreamType.PlainText);
                        }
                    }
                }
                this.pictureBox2_sav.Visible = true;
                this.timer1.Start();
            }
            else
            {
                Messag_Box();
            }
        }

        private void Open_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "TXT file (*.txt)|*.txt|RTF file(*.rtf)|*.rtf|CS(*.cs)|*.cs|All file(*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Child child = new Child(flag_Thems,flag_Langv);
                child.MdiParent = this;
                child.Text= Path.GetFileName(openFile.FileName);
                child.putFile = openFile.FileName.ToString();

                if (openFile.FileName.EndsWith("rtf"))
                {
                    foreach (var VARIABLE in child.Controls)
                    {
                        if (VARIABLE is RichTextBox)
                        {
                            (VARIABLE as RichTextBox).LoadFile(openFile.FileName, RichTextBoxStreamType.RichText);
                            child.Sintax = false;
                            child.Show();
                        }
                    }
                }
                else if(openFile.FileName.EndsWith("cs"))
                {
                    foreach (var VARIABLE in child.Controls)
                    {
                        if (VARIABLE is RichTextBox)
                        {
                            using (StreamReader reader = new StreamReader(openFile.FileName, Encoding.Default))
                            {
                                (VARIABLE as RichTextBox).Text = reader.ReadToEnd();
                            }

                            child.Sintax = true;
                            child.Show();
                            Sintex();
                        }
                    }
                    
                }
                else
                {
                    foreach (var VARIABLE in child.Controls)
                    {
                        if (VARIABLE is RichTextBox)
                        {
                            using (StreamReader reader = new StreamReader(openFile.FileName, Encoding.Default))
                            {
                                (VARIABLE as RichTextBox).Text = reader.ReadToEnd();
                            }

                            child.Sintax = false;
                            child.Show();
                        }
                    }
                }
                
            }
        }

        private void Create_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_File createFile=new Create_File(this,flag_Thems,flag_Langv);
            if (createFile.ShowDialog() == DialogResult.OK)
            {
                Child child = new Child(flag_Thems,flag_Langv);
                try
                {
                    if (!File.Exists(File_Name))
                    {
                       
                        child.MdiParent = this;
                        child.putFile = File_Name;
                        child.Text = Path.GetFileName(File_Name);
                        if (File_Name.EndsWith("rtf"))
                        {
                            foreach (var VARIABLE in child.Controls)
                            {
                                if (VARIABLE is RichTextBox)
                                {
                                    (VARIABLE as RichTextBox).SaveFile(File_Name,RichTextBoxStreamType.RichText);
                                }
                            }

                            child.Sintax = false;
                        }
                        else if(File_Name.EndsWith("cs"))
                        {
                            FileStream file = File.Create(File_Name);
                            file.Close();
                            child.Sintax = true;
                        }
                        else
                        {
                            FileStream file = File.Create(File_Name);
                            file.Close();
                            child.Sintax = false;
                        }
                        child.Show();
                    }
                    else
                    {
                        if (flag_Langv)
                        {
                            MessageBox.Show("Файл такой существует!", "Оповищение", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("This file exists!", "Information", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
                catch (Exception exception)
                {
                    if (flag_Langv)
                    {
                        MessageBox.Show("Не коректное имя файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Not a valid file name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                
                
            }
        }

        private void BunifuImageButton1_Serch_Click(object sender, EventArgs e)
        {
            if (flag_Langv)
            {
                Bitmap bitmap = new Bitmap(String.Format(@"..\..\images\Rus.png"));
                this.bunifuImageButton1_Lengvich.Image = bitmap;
                this.label2.Text = "RUS";
                this.menuStrip1_USA.Visible = true;
                this.toolStrip1_USA.Visible = true;
                this.menuStrip1_Rus.Visible = false;
                this.toolStrip1_Rus.Visible = false;
                flag_Langv = false;
            }
            else
            {
                Bitmap bitmap = new Bitmap(String.Format(@"..\..\images\USA.png"));
                this.bunifuImageButton1_Lengvich.Image = bitmap;
                this.label2.Text = "USA";
                this.menuStrip1_USA.Visible = false;
                this.toolStrip1_USA.Visible = false;
                this.menuStrip1_Rus.Visible = true;
                this.toolStrip1_Rus.Visible = true;
                flag_Langv = true;
            }
        }

        private void BunifuImageButton1_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuImageButton1_Maxisimized_Click(object sender, EventArgs e)
        {
            if (!flag_Maxisimized)
            {
                Bitmap bitmap=new Bitmap(String.Format(@"..\..\images\Normal.png"));
                this.bunifuImageButton1_Maxisimized.Image = bitmap;
                this.WindowState = FormWindowState.Normal;
                this.panel1_Control.Dock = DockStyle.Top;
                this.panel1_Footer.Dock = DockStyle.Bottom;
                flag_Maxisimized = true;
            }
            else
            {
                Bitmap bitmap = new Bitmap(String.Format(@"..\..\images\Maximized.png"));
                this.bunifuImageButton1_Maxisimized.Image = bitmap;
                this.WindowState = FormWindowState.Maximized;
                this.panel1_Control.Dock = DockStyle.Top;
                this.panel1_Footer.Dock = DockStyle.Bottom;
                flag_Maxisimized = false;
            }

        }

        private void BunifuImageButton1_Minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void Set_Name(string Name)
        {
            File_Name = Name;
        }
       
    }
}
