using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using PS3Lib;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PPC_Compiler
{
    public partial class FrmMain : MaterialForm
    {
        private readonly PS3API _ps3 = new PS3API();
        private readonly string _localPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\BISOON RTM\PPC Compiler\";
        private const string PpuLv2As = "ppu-lv2-as.exe";
        private const string PpuLv2Objcopy = "ppu-lv2-objcopy.exe";
        private SelectAPI _api = 0;
        private string CurrentApi => $"API : {_api}";

        private void Cmd(string fileName, string arg)
        {
            Process p = new Process
            {
                StartInfo =
                {
                    Arguments = arg,
                    CreateNoWindow = true,
                    FileName = _localPath + fileName,
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    WorkingDirectory = _localPath
                }
            };
            p.Start();
            while (!p.HasExited)
                Application.DoEvents();
        }
        //Loads file from the resources to specific path..
        private void LoadFile(string fileName)
        {
            string filePath = Assembly.GetExecutingAssembly().GetName().Name.Replace(" ", "_") + "." + "Files" + "." + fileName;
            using (BinaryReader bn = new BinaryReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(filePath)))
            {
                byte[] fileBuffer = bn.ReadBytes((int)bn.BaseStream.Length);
                File.WriteAllBytes(_localPath + fileName, fileBuffer);
            }
        }
        //We only take the valid hex char..
        private static string HexValues(string hex)
        {
            hex = hex.Replace("0x", "");
            var values = Regex.Matches(hex, "[a-fA-F0-9]+");
            return values.Cast<object>().Aggregate("", (current, item) => current + item);
        }
        public static byte[] Hex(string hex)
        {
            if (hex == "")
                return null;
            hex = HexValues(hex);
            hex = (((hex.Length % 2) == 1) ? "0" : "") + hex;
            return (from x in Enumerable.Range(0, hex.Length)
                    where (x % 2) == 0
                    select Convert.ToByte(hex.Substring(x, 2), 0x10)).ToArray();
        }

        private string SaveData
        {
            get
            {
                if (File.Exists(_localPath + "data"))
                {
                    return File.ReadAllText(_localPath + "data");
                }
                return "";
            }
            set => File.WriteAllText(_localPath + "data", value);
        }
        public FrmMain()
        {
            InitializeComponent();
            MinimumSize = new Size(420, 434);
            MaximumSize = new Size(420, 434);
            txtPPCScriptBox.RichTextBox.ContextMenuStrip = menuPpcCod;
            txtPPCScriptBox.Strip.BackColor = Color.White;
            txtPPCScriptBox.Strip.Size = new Size(1, 1);
            txtPPCScriptBox.RichTextBox.Font = new Font("Arial", 9.5f, FontStyle.Bold);
            txtPPCScriptBox.RichTextBox.ForeColor = (Color) new ColorConverter().ConvertFromString("#555555") ;
            txtPPCScriptBox.Strip.Font = new Font("", 7f);
            txtPPCScriptBox.Strip.OffsetColor = Color.White;
            txtPPCScriptBox.Strip.Style = AboControls.UserControls.LineNumberStyle.Boxed;
            Click += delegate
            {
                SaveData = txtPPCScriptBox.RichTextBox.Text;
            };
           
            SaveFileDialog sv = new SaveFileDialog();
            ppcCodeSaveAs.Click += delegate
            {
                sv.Filter = "PPC Code|*.ppc";
                sv.FileName = "PPC Code";
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sv.FileName, txtPPCScriptBox.RichTextBox.Text);
                    MessageBox.Show("Save with Success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            };
            btncsharpCopy.Click += delegate
            {
                var opBox = txtOpcodeBox.Text.Replace(" ","");

                string res = @"byte[] buffer = { " +
                    new Regex("(, )$").Replace(string.Join("", from c in Enumerable.Range(0, opBox.Length)
                                                               where (c % 2) == 0
                                                               select "0x" + opBox.Substring(c, 2) + ", "), "")
                    + " };";
                Clipboard.SetDataObject(res);
                MessageBox.Show("Copied..!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            };
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            if (!Directory.Exists(_localPath))
                Directory.CreateDirectory(_localPath);
            LoadFile(PpuLv2As);
            LoadFile(PpuLv2Objcopy);
            const string script = "script";
            btnApi.Text = CurrentApi;
            bool execute = false;
            chkTop.CheckedChanged += delegate { TopMost = chkTop.Checked; };
            btnCompile.Click += delegate
            {
                CheckForIllegalCrossThreadCalls = false;
                Task.Run(() =>
                {
                    try
                    {
                        btnCompile.Enabled = false;
                        txtOpcodeBox.Clear();
                        int line = 1;
                        progressBar.Value = 0;
                        progressBar.Maximum = txtPPCScriptBox.RichTextBox.Lines.Length;
                        foreach (var ppcLine in txtPPCScriptBox.RichTextBox.Lines)
                        {
                            if (!ppcLine.StartsWith("//") && ppcLine != "\n" && ppcLine != "")
                            {
                                File.WriteAllText(_localPath + script, ppcLine);
                                Cmd(PpuLv2As, script + " -o " + script + ".bin");
                                Cmd(PpuLv2Objcopy, script + ".bin -O binary");
                                byte[] outArray = File.ReadAllBytes(_localPath + "script.bin");
                                if (outArray.Length == 0)
                                {
                                    MessageBox.Show("Error at line : " + line + "\n \"" + ppcLine + '"', "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    progressBar.Value = 0;
                                    break;
                                }
                                txtOpcodeBox.Text += BitConverter.ToString(outArray).Replace("-", " ") + " ";
                            }
                            line++;
                            progressBar.Increment(1);
                        }
                        File.Delete(_localPath + script);
                        File.Delete(_localPath + script + ".bin");
                        btnCompile.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnCompile.Enabled = true;
                    }
                });

            };
            btnWrite.Click += delegate
            {
                if (!execute) return;
                try
                {
                    byte[] input = Hex(txtOpcodeBox.Text);
                    _ps3.SetMemory(Convert.ToUInt32(HexValues(txtOffsetBox.Text), 0x10), input);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            };
            btnConnect.Click += delegate
            {
                if (_ps3.ConnectTarget() && _ps3.AttachProcess())
                    btnConnect.ForeColor = Color.Green;
            };
            btnApi.Click += delegate
            {
                _ps3.ChangeAPI(
                        _api = _api == 0 
                        ? (SelectAPI)1 
                        : 0
                    );
                btnApi.Text = CurrentApi;
            };
            btnExecute.Click += delegate
            {
                if (!btnExecute.Checked)
                {
                    execute = true;
                    txtOffsetBox.Visible = true;
                    offsLbl.Visible = true;
                    btnWrite.Visible = true;
                    btnExecute.CheckState = CheckState.Checked;
                    return;
                }
                execute = false;
                txtOffsetBox.Visible = false;
                offsLbl.Visible = false;
                btnWrite.Visible = false;
                btnExecute.CheckState = CheckState.Unchecked;
            };
            txtPPCScriptBox.RichTextBox.Text = SaveData;
        }
        public sealed override Size MaximumSize
        {
            get => base.MaximumSize;
            set => base.MaximumSize = value;
        }
        public sealed override Size MinimumSize
        {
            get => base.MinimumSize;
            set => base.MinimumSize = value;
        }
         private void Btn(object o, EventArgs e)
        {
            var btn = (ToolStripMenuItem)o;
            if (btn.Text.Contains("Restart"))
            {
                _ps3.ChangeAPI(SelectAPI.ControlConsole);
                _ps3.ConnectTarget();
                _ps3.CCAPI.ShutDown(CCAPI.RebootFlags.SoftReboot);
                _ps3.ChangeAPI(_api);
                return;
            }
            _ps3.CCAPI.ShutDown(CCAPI.RebootFlags.ShutDown);
            _ps3.TMAPI.PowerOff(false);
        }
    }
}