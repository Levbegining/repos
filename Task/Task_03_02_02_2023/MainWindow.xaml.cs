using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Task_03_02_02_2023
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();


        public MainWindow()
        {
            InitializeComponent();
            
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += Timer_Tick;
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Random r_1 = new Random();
            int step_1 = r_1.Next(10, 20);

            Random r_2 = new Random();
            int step_2 = r_2.Next(10, 20);

            Random r_3 = new Random();
            int step_3 = r_3.Next(10, 20);
            Canvas.SetLeft(button_1, Canvas.GetLeft(button_1) + step_1);
            Canvas.SetLeft(button_2, Canvas.GetLeft(button_2) + step_2);
            Canvas.SetLeft(button_3, Canvas.GetLeft(button_3) + step_3);
            if (Canvas.GetLeft(button_1) == 670)
            {
                timer.Stop();
            }
            else if (Canvas.GetLeft(button_2) == 670)
            {
                timer.Stop();
            }
            else if (Canvas.GetLeft(button_3) == 670)
            {
                timer.Stop();
            }

        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            
            timer.Start();
        }
    }
}
