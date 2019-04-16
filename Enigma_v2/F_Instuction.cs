using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Enigma
{
    public partial class F_Instuction : Form
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

        private void WhoIam(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "W")
                MessageBox.Show("Програму було розроблено Шафаренком Богданом, 2019", "_GG_");
        }

        public F_Instuction()
        {
            InitializeComponent();
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
    