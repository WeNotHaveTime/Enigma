using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Enigma
{
    public partial class F_SettingsManager : Form
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
            T.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.025) == 1)
                    T.Stop();
            });
            T.Interval = 1;
            T.Start();
        }

        public F_SettingsManager()
        {
            InitializeComponent();
        }

        public Settings setting;


        private bool NewName()
        {
            bool new_name = true;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == T_Name.Text)
                {
                    new_name = false;
                }
            }
            return new_name;
        }
        private void B_Add_Click(object sender, EventArgs e)
        {
            if (T_Name.Text != string.Empty)
            {
                if (NewName())
                {
                    var F = new F_Stage_1(T_Name.Text);
                    F.Show();
                    T_Name.Clear();
                    Hide();
                }
                else MessageBox.Show("Дане ім'я вже існує!");
            }
            else
            {
                MessageBox.Show("Введінь назву, щоб створити налаштування!");
            }
        }
        private void B_Rem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                DBComunicate.Remove(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                DBComunicate.Select_toTable(ref dataGridView1);
            }
            else MessageBox.Show("Таблиця пуста!");
        }
        private void B_Choose_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DBComunicate.DB_to_Settings(name, ref setting);
                var F = Application.OpenForms.OfType<F_Cript>().Single();
                F.Settings = setting;
                F.Show();
                Hide();
                
            }
            else MessageBox.Show("Таблиця пуста!"); 
        }
        
        private void F_SettingsManager_Load(object sender, EventArgs e)
        {
            Visual_Load_Form();
            DBComunicate.Select_toTable(ref dataGridView1);
        }
        private void B_Exit_Click(object sender, EventArgs e)
        {
            var F = Application.OpenForms.OfType<F_Cript>().Single();
            F.Show();
            Close();
        }

        private void B_Export_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DBComunicate.DB_to_Settings(name, ref setting);

                saveFileDialog1.FileName = name;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sr = new StreamWriter(saveFileDialog1.FileName);
                    sr.WriteLine("Моя'Enigma' v" + Application.ProductVersion + " Налаштування");
                    for (int i = 0; i < setting.Save_text().Count; i++)
                    {
                        sr.WriteLine(setting.Save_text()[i]);
                    }
                    sr.Flush();
                    sr.Close();
                }
            }
            else MessageBox.Show("Таблиця пуста!");
        }
        private void B_Import_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);

                string name = "";
                string alphabet = "";
                bool sensitivity = false;
                string reflector = "";
                List<string> Plugboard = new List<string>();
                List<string> Rotors = new List<string>();
                List<int> Positions = new List<int>();


                string text = "";
                int i = 0;
                int j = 0;
                int n = 0;
                do
                {
                    text = sr.ReadLine();

                    if (text.Contains("Назва: "))
                    {
                        name = text.Substring(text.IndexOf("Назва: ") + 7);
                    }
                    if (text.Contains("Алфавіт: "))
                    {
                        alphabet = text.Substring(text.IndexOf("Алфавіт: ") + 9);
                    }
                    if (text.Contains("Регістр: "))
                    {
                        sensitivity = Convert.ToBoolean(text.Substring(text.IndexOf("Регістр: ") + 9));
                    }
                    if (text.Contains("Комутаційна пара" + n + ": "))
                    {
                        Plugboard.Add(text.Substring(text.IndexOf("Комутаційна пара" + n + ": ") + 19));
                        n++;
                    }
                    if (text.Contains("Ротор" + i + ": "))
                    {
                        Rotors.Add(text.Substring(text.IndexOf("Ротор" + i + ": ") + 8));
                        i++;
                    }
                    if (text.Contains("Позиція" + j + ": "))
                    {
                        Positions.Add(Convert.ToInt32(text.Substring(text.IndexOf("Позиція" + j + ": ") + 10)));
                        j++;
                    }
                    if (text.Contains("Рефлектор: "))
                    {
                        reflector = text.Substring(text.IndexOf("Рефлектор: ") + 11);
                    }
                }
                while (!sr.EndOfStream);
                sr.Close();
                try
                {
                    for (i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if(dataGridView1.Rows[i].Cells[0].Value.ToString() == name)
                        {
                            if(MessageBox.Show("В базі даних вже існують налаштування під даною назвою, замінити?", "Імпорт налаштування під назвою: "+ name,
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                DBComunicate.Remove(name);
                                DBComunicate.Insert(name, alphabet, sensitivity, reflector, Rotors, Positions, Plugboard);
                                DBComunicate.Select_toTable(ref dataGridView1);
                            }
                            return;
                        }
                    }
                    DBComunicate.Insert(name, alphabet, sensitivity, reflector, Rotors, Positions, Plugboard);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DBComunicate.Select_toTable(ref dataGridView1);
                }
            }
        }

        private void B_Combinations_Click(object sender, EventArgs e)
        {
            string name = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            DBComunicate.DB_to_Settings(name, ref setting);

            MessageBox.Show(
                "Кількість пар комутаційної панелі: " + setting.Plugboard.Count + Environment.NewLine +
                "Кількість роторів: " + setting.Rotors.Count + Environment.NewLine +
                "Криптостійкість (кількість комбінацій заданих налаштувань): " + Combinations.Calculate_combinations(setting).ToString(),
                "Налаштування: " + setting.Name);
        }
    }
}
