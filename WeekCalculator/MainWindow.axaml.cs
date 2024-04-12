using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Tmds.DBus.Protocol;

namespace WeekCalculator;

public partial class MainWindow : Window
{
    Solver CalSolver;

    //top is where the input is stored
    string top="";
    //bottom is where the output is stored
    string bottom="";
    
    public MainWindow()
    {        
        InitializeComponent();
        TextBox1.Text = top + "\n--------------\n" + bottom;
        CalSolver = new Solver();
    }

    public void Display()
    {
        TextBox1.Text = top + "\n--------------\n" + bottom;
    }

    public void ButtonACClick(object sender, RoutedEventArgs args)
    {
        top = "";
        bottom = "";
        Display();
    }
    //Numbers
    public void Button0Click(object sender, RoutedEventArgs args)
    {
        top += "0";
        Display();
    }
    public void Button1Click(object sender, RoutedEventArgs args)
    {
        top += "1";
        Display();
    }
    public void Button2Click(object sender, RoutedEventArgs args)
    {
        top += "2";
        Display();
    }
    public void Button3Click(object sender, RoutedEventArgs args)
    {
        top += "3";
        Display();
    }
    public void Button4Click(object sender, RoutedEventArgs args)
    {
        top += "4";
        Display();
    }
    public void Button5Click(object sender, RoutedEventArgs args)
    {
        top += "5";
        Display();
    }
    public void Button6Click(object sender, RoutedEventArgs args)
    {
        top += "6";
        Display();
    }
    public void Button7Click(object sender, RoutedEventArgs args)
    {
        top += "7";
        Display();
    }
    public void Button8Click(object sender, RoutedEventArgs args)
    {
        top += "8";
        Display();
    }
    public void Button9Click(object sender, RoutedEventArgs args)
    {
        top += "9";
        Display();
    }
    //Operators
    public void ButtonPlusClick(object sender, RoutedEventArgs args)
    {
        top += "+";
        Display();
    }
    public void ButtonMinusClick(object sender, RoutedEventArgs args)
    {
        top += "-";
        Display();
    }
    public void ButtonMultiplyClick(object sender, RoutedEventArgs args)
    {
        top += "*";
        Display();
    }
    public void ButtonDivClick(object sender, RoutedEventArgs args)
    {
        top += "/";
        Display();
    }
    public void ButtonDecimalClick(object sender, RoutedEventArgs args)
    {
        top += ".";
        Display();
    }

    public void ButtonModClick(object sender, RoutedEventArgs args)
    {
        top += "%";
        Display();
    }
    public void ButtonPLMClick(object sender, RoutedEventArgs args)
    {
        top += "-";
        Display();
    }
    public void ButtonEqualClick(object sender, RoutedEventArgs args)
    {
        try
        {
            if (bottom != null)
            {
                CalSolver.Accumulate(top);
                TextBox1.Text += "\n--------------\n";
                bottom += CalSolver.Solve().ToString();
                Display();
                CalSolver.Clear();
            }
            else 
            {
                bottom = "Error";
                Display();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            top = "";
            bottom = "Error";
            Display();
        }
        
    }
}