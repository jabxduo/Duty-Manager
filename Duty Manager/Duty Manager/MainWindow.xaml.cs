using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Duty_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
/*
                List<Lodger> lodgers = new List<Lodger>();
                lodgers = LodgerParser.LoadLodgers();
                foreach (Lodger l in lodgers)
                {
                    Console.WriteLine(l.Name);
                }
*/
            InitializeComponent();
        }

    }
}
