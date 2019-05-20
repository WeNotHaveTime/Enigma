using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
    public partial class F_Stage_1 : Form
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
        public void AutoComplete()
        {
            SqlDataReader sqlReader = null;  // ініціалізація 

            var alphabet = new AutoCompleteStringCollection();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBSettings.mdf;Integrated Security=True"; // адреса БД
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand M = new SqlCommand("SELECT Alphabet FROM [Main]", conn);
            try
            {
                sqlReader = M.ExecuteReader();
                while (sqlReader.Read())
                {
                    alphabet.Add(sqlReader[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
                T_Alphabet.AutoCompleteCustomSource = alphabet;
            }

        }

        string name;
        public F_Stage_1(string name)
        {
            InitializeComponent();
            this.name = name;
            AutoComplete();
        }

        private void F_Stage1_Load(object sender, EventArgs e)
        {
            Visual_Load_Form();
        }
        private void B_Exit_Click(object sender, EventArgs e)
        {
            var F = Application.OpenForms.OfType<F_SettingsManager>().Single();
            F.Show();
            Close();
        }


        private void B_Next_Click(object sender, EventArgs e)
        {
            if (T_Alphabet.Text.Length == 0)
            {
                MessageBox.Show("Будь ласка введіть дані!");
                return; 
            }
            
            if (T_Alphabet.Text.Length % 2 != 0)
            {
                MessageBox.Show("Алфавіт повинен містити парну кількість символів!");
                return;
            }

            string tx = T_Alphabet.Text;

            if (!CH_Sensitivity.Checked) tx = tx.ToUpper();

            for(int i = 0; i < tx.Length; i++)
            {
                char ch = tx[i];
                string txx = tx.Substring(i + 1);
                if (txx.Contains(ch))
                {
                    MessageBox.Show("Літери не можуть повторюватись! (Для використання маленьких літер поставте прапорець чутливості регістру)");
                    return;
                }
            }

      
            F_Stage_2 F = new F_Stage_2(name, tx, CH_Sensitivity.Checked);
            F.Show();
            Hide();
        }               
    }
}
