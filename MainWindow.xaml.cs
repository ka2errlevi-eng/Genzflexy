using System.Windows;

namespace Genzflexy {
    public partial class MainWindow : Window {
        public MainWindow() { InitializeComponent(); }
        private void Button_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Ready to send! Connect your phone via USB.\nSoftware by Ka2errLevi");
        }
    }
}
