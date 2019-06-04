using System.Windows;
using System.Windows.Input;

namespace EnigmaWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class F_Cript : Window
    {

        public F_Cript()
        {
            InitializeComponent();
        }

        private void B_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Panel_Capture_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
