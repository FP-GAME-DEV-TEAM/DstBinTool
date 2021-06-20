
using System.Windows.Forms;

namespace DstBinTool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileOpenDlg = new System.Windows.Forms.OpenFileDialog();
            this.FileSaveDlg = new System.Windows.Forms.SaveFileDialog();
            this.Btn_Open = new System.Windows.Forms.Button();
            this.HelpAbout = new System.Windows.Forms.HelpProvider();
            this.LinkAbout = new System.Windows.Forms.LinkLabel();
            this.Label_BuildName = new System.Windows.Forms.Label();
            this.TBox_BuildName = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.TBox_FilePath = new System.Windows.Forms.TextBox();
            this.Label_Path = new System.Windows.Forms.Label();
            this.Label_SymbolName = new System.Windows.Forms.Label();
            this.LBox_Symbol = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FileOpenDlg
            // 
            this.FileOpenDlg.DefaultExt = "bin";
            this.FileOpenDlg.FileName = "build";
            this.FileOpenDlg.Filter = "二进制|*.bin";
            // 
            // FileSaveDlg
            // 
            this.FileSaveDlg.DefaultExt = "bin";
            this.FileSaveDlg.Filter = "二进制|*.bin";
            // 
            // Btn_Open
            // 
            this.Btn_Open.Location = new System.Drawing.Point(11, 8);
            this.Btn_Open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Open.Name = "Btn_Open";
            this.Btn_Open.Size = new System.Drawing.Size(72, 20);
            this.Btn_Open.TabIndex = 0;
            this.Btn_Open.Text = "Open";
            this.Btn_Open.UseVisualStyleBackColor = true;
            this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            // 
            // LinkAbout
            // 
            this.LinkAbout.AutoSize = true;
            this.LinkAbout.Location = new System.Drawing.Point(327, 12);
            this.LinkAbout.Name = "LinkAbout";
            this.LinkAbout.Size = new System.Drawing.Size(65, 12);
            this.LinkAbout.TabIndex = 1;
            this.LinkAbout.TabStop = true;
            this.LinkAbout.Text = "About Tool";
            // 
            // Label_BuildName
            // 
            this.Label_BuildName.AutoSize = true;
            this.Label_BuildName.Location = new System.Drawing.Point(9, 64);
            this.Label_BuildName.Name = "Label_BuildName";
            this.Label_BuildName.Size = new System.Drawing.Size(71, 12);
            this.Label_BuildName.TabIndex = 3;
            this.Label_BuildName.Text = "Build Name:";
            // 
            // TBox_BuildName
            // 
            this.TBox_BuildName.Location = new System.Drawing.Point(82, 59);
            this.TBox_BuildName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBox_BuildName.Name = "TBox_BuildName";
            this.TBox_BuildName.Size = new System.Drawing.Size(230, 21);
            this.TBox_BuildName.TabIndex = 2;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(317, 60);
            this.Btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(72, 20);
            this.Btn_Save.TabIndex = 6;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // TBox_FilePath
            // 
            this.TBox_FilePath.Location = new System.Drawing.Point(82, 34);
            this.TBox_FilePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBox_FilePath.Name = "TBox_FilePath";
            this.TBox_FilePath.ReadOnly = true;
            this.TBox_FilePath.Size = new System.Drawing.Size(307, 21);
            this.TBox_FilePath.TabIndex = 7;
            // 
            // Label_Path
            // 
            this.Label_Path.AutoSize = true;
            this.Label_Path.Location = new System.Drawing.Point(9, 37);
            this.Label_Path.Name = "Label_Path";
            this.Label_Path.Size = new System.Drawing.Size(65, 12);
            this.Label_Path.TabIndex = 8;
            this.Label_Path.Text = "File Path:";
            // 
            // Label_SymbolName
            // 
            this.Label_SymbolName.AutoSize = true;
            this.Label_SymbolName.Location = new System.Drawing.Point(9, 91);
            this.Label_SymbolName.Name = "Label_SymbolName";
            this.Label_SymbolName.Size = new System.Drawing.Size(77, 12);
            this.Label_SymbolName.TabIndex = 5;
            this.Label_SymbolName.Text = "Symbol Name:";
            // 
            // LBox_Symbol
            // 
            this.LBox_Symbol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LBox_Symbol.FormattingEnabled = true;
            this.LBox_Symbol.ItemHeight = 20;
            this.LBox_Symbol.Location = new System.Drawing.Point(11, 107);
            this.LBox_Symbol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LBox_Symbol.Name = "LBox_Symbol";
            this.LBox_Symbol.Size = new System.Drawing.Size(381, 204);
            this.LBox_Symbol.TabIndex = 7;
            this.LBox_Symbol.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LBox_Symbol_MouseClick);
            this.LBox_Symbol.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.LBox_Symbol_DrawItem);
            this.LBox_Symbol.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LBox_Symbol_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 321);
            this.Controls.Add(this.LBox_Symbol);
            this.Controls.Add(this.Label_Path);
            this.Controls.Add(this.Label_SymbolName);
            this.Controls.Add(this.TBox_FilePath);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Label_BuildName);
            this.Controls.Add(this.TBox_BuildName);
            this.Controls.Add(this.LinkAbout);
            this.Controls.Add(this.Btn_Open);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dst Bin Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_Path;
        private System.Windows.Forms.Label Label_BuildName;
        private System.Windows.Forms.Label Label_SymbolName;

        private System.Windows.Forms.OpenFileDialog FileOpenDlg;
        private System.Windows.Forms.SaveFileDialog FileSaveDlg;
        private System.Windows.Forms.HelpProvider HelpAbout;

        private System.Windows.Forms.TextBox TBox_FilePath;
        private System.Windows.Forms.TextBox TBox_BuildName;

        private System.Windows.Forms.Button Btn_Open;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.ListBox LBox_Symbol;

        private System.Windows.Forms.LinkLabel LinkAbout;
    }
}

