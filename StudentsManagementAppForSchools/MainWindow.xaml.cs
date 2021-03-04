using System.Windows;

namespace StudentsManagementAppForSchools
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnInsert_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Here should be the method to insert the data to the DB");
        }

        private void BtnExit_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
