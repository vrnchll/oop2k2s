using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wpf_7_8
{
    class WindowCommands
    {
        static WindowCommands()
        {
            dELETE = new RoutedCommand("dELETE", typeof(MainWindow));
            Reset = new RoutedCommand("Reset", typeof(MainWindow));
            Search = new RoutedCommand("Search", typeof(MainWindow));
            ByCategory = new RoutedCommand("ByCategory", typeof(MainWindow));
            ByPriority = new RoutedCommand("ByPriority", typeof(MainWindow));
            ByDate = new RoutedCommand("ByDate", typeof(MainWindow));
            AddNewTask = new RoutedCommand("AddNewTask", typeof(MainWindow));

        }
        public static RoutedCommand Reset { get; set; }
        public static RoutedCommand Search { get; set; }
        public static RoutedCommand ByCategory { get; set; }
        public static RoutedCommand ByPriority { get; set; }
        public static RoutedCommand ByDate { get; set; }
        public static RoutedCommand AddNewTask { get; set; }

        public static RoutedCommand dELETE { get; set; }


    }
}
