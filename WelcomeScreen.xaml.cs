using System;
using System.Windows;
using System.Windows.Threading;
namespace Genzflexy {
    public partial class WelcomeScreen : Window {
        public WelcomeScreen() {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(3);
            timer.Tick += (s, e) => {
                timer.Stop();
                new MainWindow().Show();
                this.Close();
            };
            timer.Start();
        }
    }
}
