using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Enigma
{
    public partial class F_Cript : Form
    {
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();

        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;
        const uint DOSIZE = 0xF008;
        private void CapturModul_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }

        public Settings Settings;
        public F_Cript()
        {
            InitializeComponent();
        }

        private void Visual_Close_Form()
        {
            Timer T = new Timer();
            T.Tick += new EventHandler((sender2, e2) =>
            {
                if ((Opacity -= 0.025) < 0)
                {
                    T.Stop();
                    Application.Exit();
                }
            });
            T.Interval = 1;
            T.Start();
        }

        private void Visual_Load_Form()
        {
            Opacity = 0;
            Timer T = new Timer();
            T.Tick += new EventHandler((sender1, e1) =>
            {
                if ((Opacity += 0.025) == 1)
                    T.Stop();
            });
            T.Interval = 1;
            T.Start();

        }
        private void B_Exit_Click(object sender, EventArgs e)
        {
            Visual_Close_Form();
        }
        private void F_Cript_Load(object sender, EventArgs e)
        {
            Visual_Load_Form();
        }

        private void B_Settings_Click(object sender, EventArgs e)
        {
            F_SettingsManager M = new F_SettingsManager();
            M.Show();
            Hide();
        }

        private void B_Cript_Click(object sender, EventArgs e)
        {
            if (Settings == null)
            {
                MessageBox.Show("Будь ласка встановіть налаштування!");
            }
            else
            {
                string tx = T_Input.Text;
                Cript C = new Cript(tx, Settings);

                T_Cript.Text = C.Output;
                System.Windows.Forms.Clipboard.SetDataObject(T_Cript.Text);
            }
        }

        private void B_Instruction_Click(object sender, EventArgs e)
        {
            var F = new F_Help_for_Cript();
            F.Show();
            Hide();
        }

    }
}
