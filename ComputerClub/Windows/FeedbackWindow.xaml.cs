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

namespace ComputerClub.Windows
{
    /// <summary>
    /// Логика взаимодействия для FeedbackWindow.xaml
    /// </summary>
    public partial class FeedbackWindow : Window
    {
        public FeedbackWindow()
        {
            InitializeComponent();
            LoadFeedback();
        }

        public void LoadFeedback()
        {
            using(var context = new Context())
            {
                var item = context.Feedbacks.ToList();

                FeedbackGrid.ItemsSource = item;

            }

            
        }

    }
}
