﻿using System.Drawing;
using System.Windows;


namespace NetSparkle.TestAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Sparkle _sparkle;

        public MainWindow()
        {           
            InitializeComponent();

            // remove the netsparkle key from registry 
            try
            {
                Microsoft.Win32.Registry.CurrentUser.DeleteSubKeyTree("Software\\Microsoft\\NetSparkle.TestAppWPF");
            }
            catch { }

            _sparkle = new Sparkle("http://update.applimit.com/netsparkle/versioninfo.xml", SystemIcons.Application); //, "NetSparkleTestApp.exe");
            _sparkle.StartLoop(true, true);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            _sparkle.StopLoop();
            Close();
        }
    }
}
