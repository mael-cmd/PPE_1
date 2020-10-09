﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PPE_1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class SaisieClient: Window
    {
        public SaisieClient()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                FenetreClient subWindow = new FenetreClient();
                subWindow.Show();
                this.Close();
            }
        }

        private void ReturnButton(object sender, RoutedEventArgs e)
        {
            {
                MainWindow subWindow = new MainWindow();
                subWindow.Show();
                this.Close();
            }
        }
    }
}
