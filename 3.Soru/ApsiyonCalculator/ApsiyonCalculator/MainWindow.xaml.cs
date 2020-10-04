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

namespace ApsiyonCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double lastNumber, result;
        SelectedOperator selectedOperator;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = 0;
            if (sender == btn0)
                selectedValue = 0; 
            if (sender == btn1)
                selectedValue = 1;
            if (sender == btn2)
                selectedValue = 2;
            if (sender == btn3)
                selectedValue = 3;
            if (sender == btn4)
                selectedValue = 4;
            if (sender == btn5)
                selectedValue = 5;
            if (sender == btn6)
                selectedValue = 6;
            if (sender == btn7)
                selectedValue = 7;
            if (sender == btn8)
                selectedValue = 8;
            if (sender == btn9)
                selectedValue = 9;
            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = $"{selectedValue}";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{selectedValue}"; 
            }
        }
        public enum SelectedOperator
        {
            Addition,
            Substraction,
            Multiplication,
            Division
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
            lastNumber = 0;
            result = 0;
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
            lastNumber = 0;
            result = 0;
        }

        private void btnPercent_Click(object sender, RoutedEventArgs e)
        {
            double tempNumber;
            if (double.TryParse(resultLabel.Content.ToString(), out tempNumber))
            {
                tempNumber = tempNumber / 100;
                if (lastNumber != 0)
                    tempNumber *= lastNumber;
                resultLabel.Content = tempNumber.ToString();
            }
        }

        private void btnDenom_Click(object sender, RoutedEventArgs e)
        {

            result = Convert.ToDouble(resultLabel.Content);
            resultLabel.Content = (1 / result).ToString();

        }

        private void btnSquare_Click(object sender, RoutedEventArgs e)
        {
            result = Convert.ToDouble(resultLabel.Content);
            resultLabel.Content = (Math.Pow(result, 2)).ToString();
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            result = Convert.ToDouble(resultLabel.Content);
            resultLabel.Content = (Math.Sqrt(result)).ToString();
        }

        private void btnComma_Click(object sender, RoutedEventArgs e)
        {
            if (resultLabel.Content.ToString().Contains("."))
            {
               
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}.";
            }
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            double NewNumber;
            if (double.TryParse(resultLabel.Content.ToString(), out NewNumber))
            {
                switch (selectedOperator)
                {
                    case SelectedOperator.Addition:
                        result = Calculation.Add(lastNumber, NewNumber);
                        break;
                    case SelectedOperator.Substraction:
                        result = Calculation.Substraction(lastNumber, NewNumber);
                        break;
                    case SelectedOperator.Multiplication:
                        result = Calculation.Multiply(lastNumber, NewNumber);
                        break;
                    case SelectedOperator.Division:
                        result = Calculation.Divide(lastNumber, NewNumber);
                        if(result==0)
                        {
                            resultLabel.Content = "Error";
                        }
                        break;
                }
                resultLabel.Content = result.ToString();

            }
        }

        private void btnPosNeg_Click(object sender, RoutedEventArgs e)
        {
            double dresult = Convert.ToDouble(resultLabel.Content);
            resultLabel.Content = (dresult * (-1)).ToString();
        }

        private void btnOperation_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                resultLabel.Content = "0";
            }
            if (sender == btnMulti)
                selectedOperator = SelectedOperator.Multiplication;
            if (sender == btnDivision)
                selectedOperator = SelectedOperator.Division;
            if (sender == btnAdd)
                selectedOperator = SelectedOperator.Addition;
            if (sender == btnSubs)
                selectedOperator = SelectedOperator.Substraction;
        }

        public class Calculation
        {
            public static double Add(double n1, double n2)
            {
                return n1 + n2;
            }
            public static double Substraction(double n1, double n2)
            {
                return n1 - n2;
            }
            public static double Multiply(double n1, double n2)
            {
                return n1 * n2;
            }
            public static double Divide(double n1, double n2)
            {
                
                return n1 / n2;
            }
               
            }
        }


    }



