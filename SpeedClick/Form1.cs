using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SpeedClick
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vkey);

        private const string DefaultKey = "b";
        private const int DefaultInterval = 100;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SetCursorPos(int x, int y);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetCursorPos(out Point lpPoint);
        [DllImport("user32.dll", EntryPoint = "mouse_event")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x20;
        public const int MOUSEEVENTF_MIDDLEUP = 0x40;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        public const int MOUSEEVENTF_RIGHTUP = 0x10;

        public int X;
        public int Y;

        private bool pActive = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            _ = GetCursorPos(out var tempPos);
            X = tempPos.X;
            Y = tempPos.Y;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    Y -= 10;
                    e.Handled = true;
                    break;
                case Keys.Down:
                    Y += 10;
                    e.Handled = true;
                    break;
                case Keys.Left:
                    X -= 10;
                    e.Handled = true;
                    break;
                case Keys.Right:
                    X += 10;
                    e.Handled = true;
                    break;
                case Keys.Enter:
                    LeftClick();
                    e.Handled = true;
                    break;
            }
            _ = SetCursorPos(X, Y);
        }

        public static void LeftClick()
        {
            LeftDown();
            LeftUp();
        }

        public static void LeftDown()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        }

        public static void LeftUp()
        {
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        public static void RightClick()
        {
            RightDown();
            RightUp();
        }

        public static void RightDown()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
        }

        public static void RightUp()
        {
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
        }

        private void TmrL_Tick(object sender, System.EventArgs e)
        {
            LeftClick();
        }

        private void TmrR_Tick(object sender, System.EventArgs e)
        {
            RightClick();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // TODO
            TmrKeys.Start();
        }

        private void BtnReset_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie wirklich beides auf die Standardeinstellungen zurücksetzen?", "Wirklich zurücksetzen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // TODO
            }
        }

        private void BtnApply_Click(object sender, System.EventArgs e)
        {
            // TODO: Save settings
        }

        private void TxtKey_TextChanged(object sender, System.EventArgs e)
        {
            //My.Settings.Key = txt_key.Text
            TxtKey.Text = TxtKey.Text.ToUpper();
        }

        private void TxtInterval_TextChanged(object sender, System.EventArgs e)
        {
            //My.Settings.Intervall = CInt(txt_intervall.Text)
            TmrL.Interval = int.Parse(TxtInterval.Text);
            TmrR.Interval = int.Parse(TxtInterval.Text);
        }

        private void BtnDeActive_Click(object sender, System.EventArgs e)
        {
            if (BtnDeActive.Text == "Aktivieren")
            {
                BtnDeActive.Text = "Deaktivieren";
                if (CbLeftRight.Checked)
                {
                    TmrR.Start();
                }
                else
                {
                    TmrL.Start();
                }
            }
            else
            {
                BtnDeActive.Text = "Aktivieren";
                TmrR.Stop();
                TmrL.Stop();
            }
        }

        private void TmrKeys_Tick(object sender, System.EventArgs e)
        {
            string? key = null;
            for (var i = 2; i <= 90; i++)
            {
                var result = GetAsyncKeyState(i);
                if (result == -32767)
                {
                    key = $"{(char)i}";
                    if (i == 13) key = "\r\n";
                    break;
                }
            }
            if (key is not null)
            {
                TxtLog.Text = key;
            }
            if (pActive)
            {
                if (TxtLog.Text.Equals(TxtKey.Text, System.StringComparison.CurrentCultureIgnoreCase))
                {
                    BtnDeActive.PerformClick();
                    TxtLog.Text = string.Empty;
                }
            }
        }

        private void BtnPActive_Click(object sender, System.EventArgs e)
        {
            if (pActive)
            {
                BtnPActive.Text = "Prüfung aktivieren";
                pActive = false;
            }
            else
            {
                BtnPActive.Text = "Prüfung deaktivieren";
                pActive = true;
            }
        }
    }
}
