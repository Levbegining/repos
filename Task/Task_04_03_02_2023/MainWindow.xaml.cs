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

namespace Task_04_03_02_2023
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        Rect rect_1;
        Rect rect_2;
        Rect rect_3;
        Rect rect_obstacle;
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Tick += Timer_Tick; ;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
             rect_1 = new Rect(Canvas.GetLeft(button_1), Canvas.GetTop(button_1),
                 button_1.Width, button_1.Height);
             rect_2 = new Rect(Canvas.GetLeft(button_2), Canvas.GetTop(button_2),
                 button_1.Width, button_2.Height);
             rect_3 = new Rect(Canvas.GetLeft(button_3), Canvas.GetTop(button_3),
                 button_3.Width, button_3.Height);
            rect_obstacle = new Rect(Canvas.GetLeft(Obstacle), Canvas.GetTop(Obstacle),
                 Obstacle.Width, Obstacle.Height);
            Random r_1 = new Random();
            int step_1 = r_1.Next(10, 20);

            Random r_2 = new Random();
            int step_2 = r_2.Next(10, 20);

            Random r_3 = new Random();
            int step_3 = r_3.Next(10, 20);
            Canvas.SetLeft(button_1, Canvas.GetLeft(button_1) + step_1);
            Canvas.SetLeft(button_2, Canvas.GetLeft(button_2) + step_2);
            Canvas.SetLeft(button_3, Canvas.GetLeft(button_3) + step_3);
            if (rect_1.IntersectsWith(rect_obstacle) || rect_2.IntersectsWith(rect_obstacle)
                || rect_3.IntersectsWith(rect_obstacle))
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
