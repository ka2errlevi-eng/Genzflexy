using System;
using System.Windows;
using System.Windows.Threading;

namespace Genzflexy {
    public partial class WelcomeScreen : Window {
        public WelcomeScreen() {
            InitializeComponent();
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(3) };
            timer.Tick += (s, e) => {
                timer.Stop();
                new MainWindow().Show();
                this.Close();
            };
            timer.Start();
        }
    }
}
