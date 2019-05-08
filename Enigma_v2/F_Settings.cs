using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Enigma
{
    public partial class F_Settings : Form
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


        Settings NewSettings = null;
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ!.,-?0123456789 АБВГҐДЕЁЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЪЫЬЮЯ";
        int index_rotor = 1;
        bool start = true;

        public F_Settings()
        {
            InitializeComponent();

        }


        // Загальні функції
        private void TextBoxEntry(TextBox TB, Label L_Alpha)
        {
            L_Alpha.Text = Alphabet;

            string tx = TB.Text;
            for (int i = 0; i < tx.Length; i++)
            {
                if (L_Alpha.Text.Contains(tx[i])) L_Alpha.Text = L_Alpha.Text.Remove(L_Alpha.Text.IndexOf(tx[i]), 1);
                else TB.Text = tx.Remove(tx.IndexOf(tx[i]), 1);
            }

            TB.SelectionStart = TB.Text.Length;

        }  // Загальна ф-ція заповнення полів відповідно до алфавіту
        private void RemoveAlphas()
        {
            L_Alpha_K.Text = Alphabet.Insert(42, "\r\n");
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                string couple = dataGridView2.Rows[i].Cells[0].Value.ToString();
                L_Alpha_K.Text = L_Alpha_K.Text.Remove(L_Alpha_K.Text.IndexOf(couple.ElementAt(0)), 1).Remove(L_Alpha_K.Text.IndexOf(couple.ElementAt(1)), 1);
            }
        }  
        private string Generate()
        {
            int c = Alphabet.Length;
            Random random = new Random();

            string rotor = "";
            for (int i = 0; i < c; i++)
            {
                char j = Alphabet[random.Next(0, Alphabet.Length)];
                while (rotor.Contains(j))
                {
                    j = Alphabet[random.Next(0, Alphabet.Length)];
                }
                rotor += j;
            }
            return rotor;
        } // Генерація випадкових роторів/рефлекторів
        private bool Save_settings()
        {
            // Збереження комутаційної панелі
            List<string> Plugboard = new List<string>();
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                Plugboard.Add(dataGridView2.Rows[i].Cells[0].Value.ToString());
            }

            // Збереження роторів та їх позицій
            List<string> Rotors = new List<string>();
            List<int> Positions = new List<int>();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                Rotors.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
                Positions.Add(Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString()));
            }

            // Збереження рефлектора
            string Reflector;
            if (T_Reflector.Text.Count() == Alphabet.Count() && T_Reflector.Text != string.Empty)
            {
                Reflector = T_Reflector.Text;
            }
            else
            {
                pictureBox1.Visible = true;
                MessageBox.Show("Для роботи машини наявність рефлектору є обов'зковим!");
                T_Reflector.Focus();
                return false;
            }
            NewSettings = new Settings(Plugboard, Rotors, Positions, Reflector);

            Export("SaveSettings.GG");
            return true;
        }

        public void F_Load()
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
        private void F_Settings_Load(object sender, EventArgs e)
        {
            if (start)
            {
                if (File.Exists("SaveSettings.GG"))
                {
                    Import("SaveSettings.GG");
                    B_Done_Click(sender, e);    
                }
                F_Load();
            }
            else
            {
                F_Load();
            }
        }

        // Експорт/Імпорт налаштувань
        private void B_Export_Click(object sender, EventArgs e)
        {
            if (!Save_settings()) return;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Export(saveFileDialog1.FileName);
            }
        }
        private void Export(string file_name)
        {
            StreamWriter sr = new StreamWriter(file_name);
            sr.WriteLine("Моя'Enigma' v" + Application.ProductVersion + " Налаштування");
            for (int i = 0; i < NewSettings.Save_text().Count; i++)
            {
                sr.WriteLine(NewSettings.Save_text()[i]);
            }
            sr.Flush();
            sr.Close();
        }
        private void B_Import_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Import(openFileDialog1.FileName);
            }
        }
        public void Import(string file_name)
        {
            StreamReader sr = new StreamReader(file_name);

            List<string> Rotors = new List<string>();
            List<int> Positions = new List<int>();

            string text = "";
            int i = 0;
            int j = 0;
            int n = 0;
            do
            {
                text = sr.ReadLine();
                if (text.Contains("Комутаційна пара" + n + ": "))
                {
                    dataGridView2.Rows.Add(text.Substring(text.IndexOf("Комутаційна пара" + n + ": ") + 19));
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
                    T_Reflector.Text = text.Substring(text.IndexOf("Рефлектор: ") + 11);
                }
            }
            while (!sr.EndOfStream);
            sr.Close();

            for (i = 0; i < Rotors.Count; i++)
            {
                string rotor = Rotors[i];
                int pos = Positions[i];
                if (dataGridView1.RowCount == 0)
                    dataGridView1.Rows.Add(index_rotor, rotor, pos);
                else dataGridView1.Rows.Add(++index_rotor, rotor, pos);
            }
            RemoveAlphas();
        }

        // Ротори
        private void B_Random_Rotor_Click(object sender, EventArgs e)
        {
            string rotor = Generate(); //Генерація випадкового ротора
            if (dataGridView1.RowCount == 0)
                dataGridView1.Rows.Add(index_rotor, rotor, 0);
            else dataGridView1.Rows.Add(++index_rotor, rotor, 0);

        } // Випадковий ротор
        private void B_New_Rotor_Click(object sender, EventArgs e)
        {
            if (T_New_Rotor.Text.Length != Alphabet.Length)
            {
                MessageBox.Show("Будь ласка заповніть поле для введення повністю!");
            }
            else
            {
                string rotor = T_New_Rotor.Text;
                if (dataGridView1.RowCount == 0)
                    dataGridView1.Rows.Add(index_rotor, rotor, 0);
                else dataGridView1.Rows.Add(++index_rotor, rotor, 0);
                T_New_Rotor.Clear();
            }
        } // Новий ротор
        private void T_New_Rotor_TextChanged(object sender, EventArgs e)
        {
            TextBoxEntry(T_New_Rotor, L_Alpha_Rotor);
        } // Створення ротору
        private void B_Remove_Rotor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.RowCount - 1);
            }
            else MessageBox.Show("Ви не додали жодного ротору!");
        } // Видалення ротору
        private void Num_Ring_ValueChanged(object sender, EventArgs e)
        {
            int pos = Convert.ToInt32(Num_Ring.Value);
            int index = dataGridView1.SelectedRows[0].Index;
            dataGridView1.Rows[index].Cells[2].Value = pos;
        }// Зміна стартової позиції ротору
        private void B_Reset_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Index != -1)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows[index].Cells[2].Value = 0;

            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть ротор!");
            }
        } // Скинути позицію ротору
        private void B_Reset_All_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[2].Value = 0;
            }
        } // Скинути позиції роторів
        private void B_Up_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Index == 0) return;
            int index = dataGridView1.SelectedRows[0].Index;
            var r = dataGridView1.SelectedRows[0];
            dataGridView1.Rows.Remove(r);
            dataGridView1.Rows.Insert(index - 1,r);
        } // Зміна порядку роторів
        private void B_Down_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Index == dataGridView1.RowCount - 1) return;
            int index = dataGridView1.SelectedRows[0].Index;
            var r = dataGridView1.SelectedRows[0];
            dataGridView1.Rows.Remove(r);
            dataGridView1.Rows.Insert(index + 1, r);
        } // Зміна порядку роторів
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            T_New_Rotor.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        } // Полегшення редагування ротору

        // Рефлектор
        private void B_Random_Reflector_Click(object sender, EventArgs e)
        {
            string reflect = Generate(); // Генерування
            T_Reflector.Text = reflect;
            //L_Alph_Reflect.Text = Alphabet;
        } // Випадковий рефлектор
        private void T_Reflector_TextChanged(object sender, EventArgs e)
        {
            TextBoxEntry(T_Reflector, L_Alph_Reflect);
            pictureBox1.Visible = false;
        } // Створення рефлектору

        // Комутаційна панель
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
            }
        }// Фільтрування
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
            }
        }// Фільтрування
        private void B_Remove_Couple_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount != 0)
                dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
            else
            {
                MessageBox.Show("Ви не додали жодної комутаційної пари!");
            }
        }



        private void B_Exit_Click(object sender, EventArgs e)
        {
                Timer timer2 = new Timer();
                timer2.Tick += new EventHandler((sender2, e2) =>
                {
                    if ((Opacity -= 0.025) < 0)
                    {
                        timer2.Stop();
                        F_Cript M = Application.OpenForms.OfType<F_Cript>().Single(); // Звертання до існуючого екземпляру Форми
                        M.Show();
                        Hide();
                    }
                });
                timer2.Interval = 1;
                timer2.Start();
        }
        private void B_Done_Click(object sender, EventArgs e)
        {
            if(!Save_settings()) return;

            Timer timer2 = new Timer();
            timer2.Tick += new EventHandler((sender2, e2) =>
            {
                if ((Opacity -= 0.025) < 0)
                {
                    timer2.Stop();
                    F_Cript M;
                    if (start)
                    {
                        M = new F_Cript();
                        start = false;

                    }
                    else
                    {
                        M = Application.OpenForms.OfType<F_Cript>().Single(); // Звертання до існуючого екземпляру Форми
                    }
                    M.Settings = NewSettings;
                    M.Show();
                    Hide();
                }
            });
            timer2.Interval = 1;
            timer2.Start();

        } // Збереження налаштувань



        private void B_Compinations_Click(object sender, EventArgs e)
        {
            Save_settings();
            L_Combinations.Text = Combinations.Calculate_combinations(NewSettings, Alphabet.Length).ToString();
        }

        private void B_Instruction_Click(object sender, EventArgs e)
        {
            F_Instuction I = new F_Instuction();
            I.Show();
        }
    }
}
