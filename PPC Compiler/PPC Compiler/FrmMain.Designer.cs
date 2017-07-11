namespace PPC_Compiler
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnCompile = new MaterialSkin.Controls.MaterialFlatButton();
            this.menuPpcCod = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ppcCodeSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.txtOpcodeBox = new System.Windows.Forms.RichTextBox();
            this.menuOpCode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btncsharpCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.btnApi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExecute = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShut = new System.Windows.Forms.ToolStripMenuItem();
            this.txtOffsetBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.offsLbl = new MaterialSkin.Controls.MaterialLabel();
            this.btnWrite = new MaterialSkin.Controls.MaterialFlatButton();
            this.chkTop = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtPPCScriptBox = new AboControls.UserControls.NumberedRTB();
            this.menuPpcCod.SuspendLayout();
            this.menuOpCode.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCompile
            // 
            this.btnCompile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCompile.AutoSize = true;
            this.btnCompile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompile.Depth = 0;
            this.btnCompile.Location = new System.Drawing.Point(167, 394);
            this.btnCompile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCompile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompile.Name = "btnCompile";
            this.btnCompile.Primary = false;
            this.btnCompile.Size = new System.Drawing.Size(70, 36);
            this.btnCompile.TabIndex = 0;
            this.btnCompile.Text = "Compile";
            this.btnCompile.UseVisualStyleBackColor = true;
            // 
            // menuPpcCod
            // 
            this.menuPpcCod.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ppcCodeSaveAs});
            this.menuPpcCod.Name = "menuPpcCod";
            this.menuPpcCod.Size = new System.Drawing.Size(115, 26);
            // 
            // ppcCodeSaveAs
            // 
            this.ppcCodeSaveAs.Name = "ppcCodeSaveAs";
            this.ppcCodeSaveAs.Size = new System.Drawing.Size(114, 22);
            this.ppcCodeSaveAs.Text = "Save As";
            // 
            // txtOpcodeBox
            // 
            this.txtOpcodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOpcodeBox.BackColor = System.Drawing.Color.White;
            this.txtOpcodeBox.ContextMenuStrip = this.menuOpCode;
            this.txtOpcodeBox.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpcodeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.txtOpcodeBox.Location = new System.Drawing.Point(259, 122);
            this.txtOpcodeBox.Name = "txtOpcodeBox";
            this.txtOpcodeBox.Size = new System.Drawing.Size(151, 239);
            this.txtOpcodeBox.TabIndex = 2;
            this.txtOpcodeBox.Text = "";
            // 
            // menuOpCode
            // 
            this.menuOpCode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuOpCode.Name = "menuPpcCod";
            this.menuOpCode.Size = new System.Drawing.Size(119, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btncsharpCopy});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem1.Text = "Copy As";
            // 
            // btncsharpCopy
            // 
            this.btncsharpCopy.Name = "btncsharpCopy";
            this.btncsharpCopy.Size = new System.Drawing.Size(89, 22);
            this.btncsharpCopy.Text = "C#";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(10, 100);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "PPC Code";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(255, 100);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(62, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "OpCode";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(93)))), ((int)(((byte)(106)))));
            this.progressBar.Location = new System.Drawing.Point(12, 367);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(398, 15);
            this.progressBar.TabIndex = 5;
            // 
            // menuStrip
            // 
            this.menuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(5, 406);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(68, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "optsMenu";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConnect,
            this.btnApi,
            this.btnExecute,
            this.btnRestart,
            this.btnShut});
            this.connectToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.connectToolStripMenuItem.Text = "Options";
            // 
            // btnConnect
            // 
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(162, 22);
            this.btnConnect.Text = "Connect / Attach";
            // 
            // btnApi
            // 
            this.btnApi.Name = "btnApi";
            this.btnApi.Size = new System.Drawing.Size(162, 22);
            this.btnApi.Text = "API";
            // 
            // btnExecute
            // 
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(162, 22);
            this.btnExecute.Text = "Execute To PS3";
            // 
            // btnRestart
            // 
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(162, 22);
            this.btnRestart.Text = "RestartPS3";
            this.btnRestart.Click += new System.EventHandler(this.Btn);
            // 
            // btnShut
            // 
            this.btnShut.Name = "btnShut";
            this.btnShut.Size = new System.Drawing.Size(162, 22);
            this.btnShut.Text = "Shutdown";
            this.btnShut.Click += new System.EventHandler(this.Btn);
            // 
            // txtOffsetBox
            // 
            this.txtOffsetBox.Depth = 0;
            this.txtOffsetBox.Hint = "";
            this.txtOffsetBox.Location = new System.Drawing.Point(64, 70);
            this.txtOffsetBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtOffsetBox.Name = "txtOffsetBox";
            this.txtOffsetBox.PasswordChar = '\0';
            this.txtOffsetBox.SelectedText = "";
            this.txtOffsetBox.SelectionLength = 0;
            this.txtOffsetBox.SelectionStart = 0;
            this.txtOffsetBox.Size = new System.Drawing.Size(171, 23);
            this.txtOffsetBox.TabIndex = 7;
            this.txtOffsetBox.UseSystemPasswordChar = false;
            this.txtOffsetBox.Visible = false;
            // 
            // offsLbl
            // 
            this.offsLbl.AutoSize = true;
            this.offsLbl.Depth = 0;
            this.offsLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.offsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.offsLbl.Location = new System.Drawing.Point(8, 74);
            this.offsLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.offsLbl.Name = "offsLbl";
            this.offsLbl.Size = new System.Drawing.Size(50, 19);
            this.offsLbl.TabIndex = 8;
            this.offsLbl.Text = "Offset";
            this.offsLbl.Visible = false;
            // 
            // btnWrite
            // 
            this.btnWrite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWrite.AutoSize = true;
            this.btnWrite.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWrite.Depth = 0;
            this.btnWrite.Location = new System.Drawing.Point(280, 394);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWrite.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Primary = false;
            this.btnWrite.Size = new System.Drawing.Size(131, 36);
            this.btnWrite.TabIndex = 9;
            this.btnWrite.Text = "Write in Memory";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Visible = false;
            // 
            // chkTop
            // 
            this.chkTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTop.AutoSize = true;
            this.chkTop.Depth = 0;
            this.chkTop.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkTop.Location = new System.Drawing.Point(357, 70);
            this.chkTop.Margin = new System.Windows.Forms.Padding(0);
            this.chkTop.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkTop.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkTop.Name = "chkTop";
            this.chkTop.Ripple = true;
            this.chkTop.Size = new System.Drawing.Size(54, 30);
            this.chkTop.TabIndex = 10;
            this.chkTop.Text = "Top";
            this.chkTop.UseVisualStyleBackColor = true;
            // 
            // txtPPCScriptBox
            // 
            this.txtPPCScriptBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPPCScriptBox.BackColor = System.Drawing.SystemColors.Window;
            this.txtPPCScriptBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtPPCScriptBox.ContextMenuStrip = this.menuPpcCod;
            this.txtPPCScriptBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPPCScriptBox.Location = new System.Drawing.Point(12, 122);
            this.txtPPCScriptBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPPCScriptBox.Name = "txtPPCScriptBox";
            this.txtPPCScriptBox.Size = new System.Drawing.Size(241, 239);
            this.txtPPCScriptBox.TabIndex = 11;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 434);
            this.Controls.Add(this.txtPPCScriptBox);
            this.Controls.Add(this.chkTop);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.offsLbl);
            this.Controls.Add(this.txtOffsetBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtOpcodeBox);
            this.Controls.Add(this.btnCompile);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Opacity = 0.95D;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PPC Compiler";
            this.menuPpcCod.ResumeLayout(false);
            this.menuOpCode.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnCompile;
        private System.Windows.Forms.RichTextBox txtOpcodeBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnConnect;
        private System.Windows.Forms.ToolStripMenuItem btnApi;
        private System.Windows.Forms.ToolStripMenuItem btnExecute;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtOffsetBox;
        private MaterialSkin.Controls.MaterialLabel offsLbl;
        private MaterialSkin.Controls.MaterialFlatButton btnWrite;
        private System.Windows.Forms.ToolStripMenuItem btnRestart;
        private System.Windows.Forms.ToolStripMenuItem btnShut;
        private MaterialSkin.Controls.MaterialCheckBox chkTop;
        private System.Windows.Forms.ContextMenuStrip menuPpcCod;
        private System.Windows.Forms.ToolStripMenuItem ppcCodeSaveAs;
        private System.Windows.Forms.ContextMenuStrip menuOpCode;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btncsharpCopy;
        private AboControls.UserControls.NumberedRTB txtPPCScriptBox;
    }
}

