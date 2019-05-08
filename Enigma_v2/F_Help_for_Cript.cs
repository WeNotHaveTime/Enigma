using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;
using System.Diagnostics;

namespace Enigma
{
    public partial class F_Help_for_Cript : Form
    {
        public F_Help_for_Cript()
        {
            InitializeComponent();
        }

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

        private void B_Exit_Click(object sender, EventArgs e)
        {
            var F = Application.OpenForms.OfType<F_Cript>().Single();
            F.Show();
            Close();
        }



        private void B_WHO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Програму було розроблено Шафаренком Богданом, 2019", "GodGive");
        }

       
        private void F_Help_for_Cript_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            Timer T = new Timer();
            T.Tick += new EventHandler((senderx, ex) =>
            {
                if ((Opacity += 0.025) == 1)
                    T.Stop();
            });
            T.Interval = 1;
            T.Start();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://uk.wikipedia.org/wiki/%D0%95%D0%BD%D1%96%D0%B3%D0%BC%D0%B0_(%D0%B0%D0%B2%D1%82%D0%BE%D0%BC%D0%B0%D1%82)");
        }
    }
}
