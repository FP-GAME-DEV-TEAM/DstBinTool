using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DstBinTool
{
    public partial class MainForm : Form
    {

        public BuildFile workFile = null;

        public TextBox txtEdit = new TextBox();

        private void txtEdit_Leave(object sender, EventArgs e)
        {

            LBox_Symbol.Items[LBox_Symbol.SelectedIndex] = txtEdit.Text;
            txtEdit.Visible = false;
        }

        /// <summary>
        /// 选择项类，用于ComboBox或者ListBox添加项
        /// </summary>
        public class ListItem
        {
            private string name = string.Empty;
            public ListItem(string str)
            {
                name = str;
            }
            public override string ToString()
            {
                return this.name;
            }
            public string Name
            {
                get
                {
                    return this.name;
                }
                set
                {
                    this.name = value;
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            txtEdit.Leave += new EventHandler(txtEdit_Leave);
        }

        public void Fetch()
        {
            TBox_BuildName.Text = workFile.BuildName;
            LBox_Symbol.Items.Clear();
            for (int i = 0; i < workFile.TotalDicts; i++)
            {
                ListItem li = new ListItem(workFile.Dicts[i].Symbol);
                LBox_Symbol.Items.Add(li);
            }
        }

        public void Fill()
        {
            workFile.BuildName = TBox_BuildName.Text;

            int count = Convert.ToInt32(workFile.TotalSymbols);
            for (int i = 0; i < count; i++)
            {
                uint old = workFile.Symbols[i].Hash;
                // update Symbals
                for (int j = 0; j < count; j++)
                {
                    if (workFile.Dicts[j].Hash == old)
                    {
                        string name = LBox_Symbol.Items[j].ToString();
                        workFile.Symbols[i].Hash = BuildFile.Hash(name);
                    }
                }
            }

            count = Convert.ToInt32(workFile.TotalDicts);
            // update Dicts
            for (int i = 0; i < count; i++)
            {
                string name = LBox_Symbol.Items[i].ToString();
                workFile.Dicts[i].Symbol = name;
                workFile.Dicts[i].StrLen = name.Length;
                workFile.Dicts[i].Hash = BuildFile.Hash(name);
            }
        }

        private void Btn_Open_Click(object sender, EventArgs e)
        {
            FileOpenDlg.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            if (FileOpenDlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = FileOpenDlg.FileName;
                FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                if (stream == null)
                {
                    MessageBox.Show("文件无效");
                    return;
                }
                workFile = new BuildFile();
                if (workFile.Load(stream) != 0)
                {
                    MessageBox.Show("数据无效");
                    return;
                }
                stream.Close();
                TBox_FilePath.Text = System.IO.Path.GetFullPath(fileName);
                Fetch();
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (workFile == null)
            {
                MessageBox.Show("没有数据");
                return;
            }
            Fill();
            FileSaveDlg.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            FileSaveDlg.FileName = "build.bin";
            if (FileSaveDlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = FileSaveDlg.FileName;
                FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                if (stream == null)
                {
                    MessageBox.Show("文件无效");
                    return;
                }
                if (workFile.Save(stream) != 0)
                {
                    MessageBox.Show("储存失败");
                    return;
                }
                stream.Close();
            }
        }

        private void LBox_Symbol_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int itemSelected = LBox_Symbol.SelectedIndex;
            string itemText = LBox_Symbol.Items[itemSelected].ToString();

            Rectangle rect = LBox_Symbol.GetItemRectangle(itemSelected);
            txtEdit.Parent = LBox_Symbol;
            txtEdit.Bounds = rect;
            txtEdit.Multiline = false;
            txtEdit.Visible = true;
            txtEdit.Text = itemText;
            txtEdit.Focus();
            txtEdit.SelectAll();
        }

        private void LBox_Symbol_MouseClick(object sender, MouseEventArgs e)
        {
            txtEdit.Visible = false;
        }

        private void LBox_Symbol_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(LBox_Symbol.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }
    }
}
