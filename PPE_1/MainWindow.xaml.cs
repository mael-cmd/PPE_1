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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void SelectUserButton(object sender, RoutedEventArgs e)
        {
                {
                    SaisieClient subWindow = new SaisieClient();
                    subWindow.Show();
                    this.Close();
                }
        }

        private void CreateUserButton(object sender, RoutedEventArgs e)
        {
            {
                CreationClient subWindow = new CreationClient();
                subWindow.Show();
                this.Close();
            }
        }
    }
}
