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

namespace logic_model
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        public string rezult;


        public Button yes = new Button();
        public Button no = new Button();
        public bool flag=false;
        private void button_Click(object sender, RoutedEventArgs e)
        {
                
                button.Visibility = Visibility.Hidden;
                label.Content = "Это животное летает?";
                yes.Width = 97;
                yes.Height = 35;
                yes.Content = "Да";
                yes.HorizontalAlignment = HorizontalAlignment.Left;
                yes.VerticalAlignment = VerticalAlignment.Top;
                yes.Margin = new Thickness(10, 151, 0, 0);
                Big_grid.Children.Add(yes);
                yes.Click += new RoutedEventHandler(yes_click);
                no.Width = 97;
                no.Height = 35;
                no.Content = "Нет";
                no.HorizontalAlignment = HorizontalAlignment.Left;
                no.VerticalAlignment = VerticalAlignment.Top;
                no.Margin = new Thickness(178, 151, 0, 0);
                Big_grid.Children.Add(no);
                no.Click += new RoutedEventHandler(no_click);
                if(flag==true)
            {
                this.Close();
                

            }

        }
        private void yes_click(object sender, RoutedEventArgs e)
        {
            flag = true;
            rezult += "1";
            if (rezult == "1") 
            {
                label.Content = "Яркая окраска?";
            }
            if(rezult=="11")
            {
                label.Content = "Может говорить?";
            }
            if(rezult=="111")
            {
                label.Content = "Это попугай!";
                yes.Visibility = Visibility.Hidden;
                no.Visibility = Visibility.Hidden;
                Big_grid.Children.Remove(yes);
                Big_grid.Children.Remove(no);
                button.Content = "Выход";
                button.Visibility = Visibility.Visible;
                flag = true;
                              
                

            }
            if(rezult=="101")
            {
                label.Content = "Это пеликан";
                yes.Visibility = Visibility.Hidden;
                no.Visibility = Visibility.Hidden;
                Big_grid.Children.Remove(yes);
                Big_grid.Children.Remove(no);
                button.Content = "Выход";
                button.Visibility = Visibility.Visible;
                flag = true;

            }
            if (rezult=="001")
            {
                label.Content = "Имееи ли иголки?";
            }
            if(rezult=="0011")
            {
                label.Content = "Это йожик";
                yes.Visibility = Visibility.Hidden;
                no.Visibility = Visibility.Hidden;
                Big_grid.Children.Remove(yes);
                Big_grid.Children.Remove(no);
                button.Content = "Выход";
                button.Visibility = Visibility.Visible;
                flag = true;

            }

            if (rezult=="01")
            {
                label.Content = "Гавкает?";
            }
            if(rezult=="011")
            {
                label.Content = "Это собака";
                yes.Visibility = Visibility.Hidden;
                no.Visibility = Visibility.Hidden;
                Big_grid.Children.Remove(yes);
                Big_grid.Children.Remove(no);
                button.Content = "Выход";
                button.Visibility = Visibility.Visible;
                flag = true;

            }
            if (rezult == "0001")
            {
                label.Content = "Это единорог!";
                yes.Visibility = Visibility.Hidden;
                no.Visibility = Visibility.Hidden;
                Big_grid.Children.Remove(yes);
                Big_grid.Children.Remove(no);
                button.Content = "Выход";
                button.Visibility = Visibility.Visible;
                flag = true;

            }
        }
            
          
        private void no_click(object sender, RoutedEventArgs e)
        {
            rezult += "0";
            if (rezult == "0")
            {
                label.Content = "Домашний?";
            }
            if(rezult=="10")
            {
                label.Content = "Морской обитатель?";
            }
            if(rezult=="100")
            {
                label.Content = "Это воробей";
                yes.Visibility = Visibility.Hidden;
                no.Visibility = Visibility.Hidden;
                Big_grid.Children.Remove(yes);
                Big_grid.Children.Remove(no);
                button.Content = "Выход";
                button.Visibility = Visibility.Visible;
                flag = true;
            }
            if(rezult=="00")
            {
                label.Content = "Маленький?";
            }
            if(rezult=="0010")
            {
                label.Content = "Это мышь";
                yes.Visibility = Visibility.Hidden;
                no.Visibility = Visibility.Hidden;
                Big_grid.Children.Remove(yes);
                Big_grid.Children.Remove(no);
                button.Content = "Выход";
                button.Visibility = Visibility.Visible;
                flag = true;
            }
            if(rezult=="010")
            {
                label.Content = "Это кошка";
                yes.Visibility = Visibility.Hidden;
                no.Visibility = Visibility.Hidden;
                Big_grid.Children.Remove(yes);
                Big_grid.Children.Remove(no);
                button.Content = "Выход";
                button.Visibility = Visibility.Visible;
                flag = true;
            }
            if (rezult == "000")
            {
                label.Content = "Имеет ли рог?";
            }
            if(rezult=="0000")
            {
                label.Content = "Это тирекс!";
                yes.Visibility = Visibility.Hidden;
                no.Visibility = Visibility.Hidden;
                Big_grid.Children.Remove(yes);
                Big_grid.Children.Remove(no);
                button.Content = "Выход";
                button.Visibility = Visibility.Visible;
                flag = true;
            }
          
            if(rezult=="110")
            {
                label.Content = "Это райская птица!";
                yes.Visibility = Visibility.Hidden;
                no.Visibility = Visibility.Hidden;
                Big_grid.Children.Remove(yes);
                Big_grid.Children.Remove(no);
                button.Content = "Выход";
                button.Visibility = Visibility.Visible;
                flag = true;

            }

            }
            
            
            
        }
        

    }

