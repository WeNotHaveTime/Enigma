using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.IO;
using System.Linq;

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
        private void WhoIam(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "W")
                MessageBox.Show("Програму було розроблено Шафаренком Богданом, 2019", "_GG_");
        }

        public Settings Settings;
        public F_Cript()
        {
            InitializeComponent();
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Timer timer2 = new Timer();
            timer2.Tick += new EventHandler((sender2, e2) =>
            {
                if ((Opacity -= 0.025) < 0)
                {
                    timer2.Stop();
                    Application.Exit();
                }
            });
            timer2.Interval = 1;
            timer2.Start();

        }

        private void F_Cript_Load(object sender, EventArgs e)
        {

            Opacity = 0;
            Timer timer1 = new Timer();
            timer1.Tick += new EventHandler((sender1, e1) =>
            {
                if ((Opacity += 0.025) == 1)
                    timer1.Stop();
            });
            timer1.Interval = 1;
            timer1.Start();
        }

        private void B_Settings_Click(object sender, EventArgs e)
        {
            F_Settings M = Application.OpenForms.OfType<F_Settings>().Single(); // Звертання до існуючого екземпляру Форми
            M.Show();
            M.F_Load();
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

                string tx = T_Input.Text.ToUpper();
                Cript C = new Cript(tx, Settings);

                T_Cript.Text =  C.Output;
                System.Windows.Forms.Clipboard.SetDataObject(T_Cript.Text);
            }
        }

        private void B_Instruction_Click(object sender, EventArgs e)
        {
            F_Instuction I = new F_Instuction();
            I.Show();
        }

    }
}
