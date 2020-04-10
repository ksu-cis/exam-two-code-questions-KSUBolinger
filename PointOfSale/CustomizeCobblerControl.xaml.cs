using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
        }

        void Button_Clicked(object sender, RoutedEventArgs e)
        {
            Cobbler cobbler = (Cobbler)DataContext;
            if(((Button)sender).Name == "Peach_Button")
            {
                cobbler.Fruit = ExamTwoCodeQuestions.Data.FruitFilling.Peach;
            }
            else if(((Button)sender).Name == "Cherry_Button")
            {
                cobbler.Fruit = ExamTwoCodeQuestions.Data.FruitFilling.Cherry;
            }
            else if(((Button)sender).Name == "Blueberry_Button")
            {
                cobbler.Fruit = ExamTwoCodeQuestions.Data.FruitFilling.Blueberry;
            }

            else if(((Button)sender).Name == "WithIceCream_Button")
            {
                cobbler.WithIceCream = true;
            }
            else if(((Button)sender).Name == "WithoutIceCream_Button")
            {
                cobbler.WithIceCream = false;
            }

            
        }
    }
}
