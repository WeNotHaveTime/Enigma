using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Enigma
{
    public partial class F_Stage_4 : Form
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

        public async void My_ExecuteNonQueryAsync(SqlCommand command)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DBSettings.mdf;Integrated Security=True"; // адреса БД
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            command.Connection = conn;
            await command.ExecuteNonQueryAsync();
            conn.Close();
        } //Виконання команди
        public void Insert(string name, string alphabet, bool sensitivity, string reflector, List<string> Rotors, List<int> Positions, List<string> Plugboard)
        {
            SqlCommand addM = new SqlCommand("INSERT INTO [Main] ([Name], [Alphabet], [Sensitivity], [Reflector]) VALUES (@Name, @Alphabet, @Sensitivity, @Reflector)");
            addM.Parameters.AddWithValue("Name", name);
            addM.Parameters.AddWithValue("Alphabet", alphabet);
            addM.Parameters.AddWithValue("Sensitivity", Convert.ToInt16(sensitivity));
            addM.Parameters.AddWithValue("Reflector", reflector);
            My_ExecuteNonQueryAsync(addM);

            for (int i = 0; i < Rotors.Count; i++)
            {
                SqlCommand addR = new SqlCommand("INSERT INTO [Rotors] ([Name], [Rotor], [Position]) VALUES (@Name, @Rotor, @Position)");
                addR.Parameters.AddWithValue("Name", name);
                addR.Parameters.AddWithValue("Rotor", Rotors[i]);
                addR.Parameters.AddWithValue("Position", Positions[i]);
                My_ExecuteNonQueryAsync(addR);
            }
            for (int i = 0; i < Plugboard.Count; i++)
            {
                SqlCommand addP = new SqlCommand("INSERT INTO [Plugboard] ([Name], [Couple]) VALUES (@Name, @Couple)");
                addP.Parameters.AddWithValue("Name", name);
                addP.Parameters.AddWithValue("Couple", Plugboard[i]);
                My_ExecuteNonQueryAsync(addP);
            }

        } // Додавання елементу

        ToolTip T = new ToolTip();
        string name;
        string alphabet;
        bool sensitivity;
        string reflector;
        List<string> Rotors = new List<string>();
        List<int> Positions = new List<int>();

        public F_Stage_4(string name, string alphabet, bool sensitivity, string reflector, List<string> Rotors, List<int> Positions)
        {
            InitializeComponent();
            this.name = name;
            this.alphabet = alphabet;
            this.sensitivity = sensitivity;
            L_Alpha_K.Text = alphabet;
            T.SetToolTip(this.L_Alpha_K, L_Alpha_K.Text);
            this.reflector = reflector;
            this.Rotors.AddRange(Rotors);
            this.Positions.AddRange(Positions);
            if (!sensitivity)
            {
                T_K1.CharacterCasing = CharacterCasing.Upper;
                T_K2.CharacterCasing = CharacterCasing.Upper;
            }
        }

        private void T_K1_TextChanged(object sender, EventArgs e)
        {
            if (T_K1.Text == "")
                return;
            if (L_Alpha_K.Text.Contains(T_K1.Text))
                T_K2.Focus();
            if (L_Alpha_K.Text.Contains(T_K1.Text) && L_Alpha_K.Text.Contains(T_K2.Text) && T_K1.Text != "" && T_K2.Text != "")
            {
                L_Alpha_K.Text = L_Alpha_K.Text.Replace(T_K1.Text, "");
                L_Alpha_K.Text = L_Alpha_K.Text.Replace(T_K2.Text, "");
                dataGridView2.Rows.Add(T_K1.Text + T_K2.Text);
                T_K1.Clear();
                T_K2.Clear();
                T_K1.Focus();
                T.SetToolTip(L_Alpha_K, L_Alpha_K.Text);
            }
        }
        private void T_K2_TextChanged(object sender, EventArgs e)
        {
            if (T_K2.Text == "")
                return;
            if (L_Alpha_K.Text.Contains(T_K2.Text))
                T_K1.Focus();
            if (L_Alpha_K.Text.Contains(T_K1.Text) && L_Alpha_K.Text.Contains(T_K2.Text) && T_K1.Text != "" && T_K2.Text != "")
            {
                L_Alpha_K.Text = L_Alpha_K.Text.Replace(T_K1.Text, "");
                L_Alpha_K.Text = L_Alpha_K.Text.Replace(T_K2.Text, "");
                dataGridView2.Rows.Add(T_K1.Text + T_K2.Text);
                T_K1.Clear();
                T_K2.Clear();
                T_K1.Focus();
                T.SetToolTip(L_Alpha_K, L_Alpha_K.Text);
            }
        }
        private void B_Remove_Couple_Click(object sender, EventArgs e)
        {
                if (dataGridView2.RowCount != 0)
                    dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
                else
                {
                    MessageBox.Show("Ви не додали жодної комутаційної пари!");
                }

        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            
            List<string> Plugboard = new List<string>();
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                Plugboard.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
            }
            Insert(name, alphabet, sensitivity, reflector, Rotors, Positions, Plugboard);
            var F = Application.OpenForms.OfType<F_SettingsManager>().First();
            Application.OpenForms.OfType<F_Stage_1>().First().Close();
            Application.OpenForms.OfType<F_Stage_2>().First().Close();
            Application.OpenForms.OfType<F_Stage_3>().First().Close();
            F.Select_toTable();
            F.Show();
            Close();
        }

        private void B_Back_Click(object sender, EventArgs e)
        {
            var F = Application.OpenForms.OfType<F_Stage_3>().Single();
            F.Show();
            Close();
        }
        private void F_Stage_4_Load(object sender, EventArgs e)
        {
            Visual_Load_Form();
        }
    }
}
