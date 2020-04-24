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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;
using System.ComponentModel;
using Wpf_7_8.Services;
using Wpf_7_8.Models;
using WpfApp_todos.Services;

namespace Wpf_7_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
   
    public partial class MainWindow : Window
    {
        public string ViewModel { get; set; }
        public List<string> CategoryL { get; set; }
        public List<string> PriorityL { get; set; }
      

        private readonly string Path = $"{Environment.CurrentDirectory}\\toDoMod.json";
        private readonly string FilterPath = $"{Environment.CurrentDirectory}\\filter.json";
        private readonly string SearchPath = $"{Environment.CurrentDirectory}\\search.json";

        public static BindingList<ToDoMod> _toDoData;
        private SaveToOrReadFrom _saveToOrReadFrom;
        private SaveToOrReadFrom _filterIOService;
        private SaveToOrReadFrom _searchIOService;
        private FilterService _filterService;
        private SearchService _searchService;
    
        public MainWindow()
        {
            SetCursor();
            CategoryL = new List<string>();
            CategoryL.Add("Личное");
            CategoryL.Add("Работа");
            CategoryL.Add("Учеба");
            CategoryL.Add("Дом");
         

            PriorityL = new List<string>();
            PriorityL.Add("Высокий");
            PriorityL.Add("Средний");
            PriorityL.Add("Низкий");






            InitializeComponent();


            Category.ItemsSource = CategoryL;
            Priority.ItemsSource = PriorityL;

         
            CommandBinding commandBinding = new CommandBinding();
            CommandBinding ExitcommandBinding = new CommandBinding();
            CommandBinding SearchCommandBinding = new CommandBinding();
          
           

            // устанавливаем команду   

            ExitcommandBinding.Command = ApplicationCommands.Close;
            commandBinding.Command = ApplicationCommands.New;
           
          

            // устанавливаем метод, который будет выполняться при вызове команды

            commandBinding.Executed += New_Executed;
        
            ExitcommandBinding.Executed += ExitcommandBinding_execute;
            

            // добавляем привязку к коллекции привязок элемента 

            Exit.CommandBindings.Add(ExitcommandBinding);


            List<string> styles = new List<string> { "Light", "Dark" };
            Theme.SelectionChanged += ThemeChange;
            Theme.ItemsSource = styles;


        


        }

     
        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = Theme.SelectedItem as string;
            // определяем путь к файлу ресурсов
            var uri = new Uri(style + ".xaml", UriKind.Relative);
            // загружаем словарь ресурсов
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.Clear();
            // добавляем загруженный словарь ресурсов
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }
  

        private void Reset_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            _saveToOrReadFrom = new SaveToOrReadFrom(Path);
            toDoL.ItemsSource = _toDoData;
            _toDoData.ListChanged += _toDoData_ListChanged;
        }

      

        private void dELETE_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Prompt prompt = new Prompt();
            if (prompt.ShowDialog() == true)
            {
                _toDoData.RemoveAt(toDoL.SelectedIndex);
                toDoL.ItemsSource = _toDoData;
                _toDoData.ListChanged += _toDoData_ListChanged;
                MessageBox.Show("Успешно удалено!");
            }
        }

        private void New_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CreateTask createTask = new CreateTask();
            createTask.Show();
        }

        private void ByCategory_Executed(object sender, RoutedEventArgs e)
        {
            _saveToOrReadFrom = new SaveToOrReadFrom(Path);
            _filterIOService = new SaveToOrReadFrom(FilterPath);
            _filterService = new FilterService();
            MenuItem menuItem = (MenuItem)sender;//определение по какой категории будет фильтр
            try
            {
                toDoL.ItemsSource = _filterService.FilterBy("By Category", _toDoData, menuItem.Header.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
                throw;
            }

        }
        private void ByPriority_Executed(object sender, RoutedEventArgs e)
        {
            _saveToOrReadFrom = new SaveToOrReadFrom(Path);
            _filterIOService = new SaveToOrReadFrom(FilterPath);
            _filterService = new FilterService();
            MenuItem menuItem = (MenuItem)sender;//определение по какой категории будет фильтр
            try
            {
                toDoL.ItemsSource = _filterService.FilterBy("By Priority", _toDoData, menuItem.Header.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
                throw;
            }

        }

        private void ByDate_Executed(object sender, RoutedEventArgs e)
        {
            _saveToOrReadFrom = new SaveToOrReadFrom(Path);
            _filterIOService = new SaveToOrReadFrom(FilterPath);
            _filterService = new FilterService();
            MenuItem menuItem = (MenuItem)sender;//определение по какой категории будет фильтр
            try
            {
                toDoL.ItemsSource = _filterService.FilterBy("By Date", _toDoData, menuItem.Header.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
                throw;
            }

        }



        private void ExitcommandBinding_execute(object sender, ExecutedRoutedEventArgs e)
        {
            Environment.Exit(0);
        }


        private void Close(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            App.LanguageChanged += LanguageChanged;
            CultureInfo currLang = App.Language;

            foreach (var lang in App.Languages)
            {
                MenuItem menuLang = new MenuItem();
                menuLang.Header = lang.DisplayName;
                menuLang.Tag = lang;
                menuLang.IsChecked = lang.Equals(currLang);
                menuLang.Click += ChangeLanguage;
                menuLanguage.Items.Add(menuLang);
            }

            _saveToOrReadFrom = new SaveToOrReadFrom(Path);
            try
            {
                _toDoData = _saveToOrReadFrom.ReadFrom();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
            toDoL.ItemsSource = _toDoData;
            _toDoData.ListChanged += _toDoData_ListChanged;
        }
        public static void AddTask(ToDoMod data) {
            _toDoData.Add(data);
            }
        private void _toDoData_ListChanged(object sender, ListChangedEventArgs e)
        {
            if(e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {
                try
                {
                    _saveToOrReadFrom.Save(sender);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        }





        private void LanguageChanged(object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

            //Отмечаем нужный пункт смены языка как выбранный язык
            foreach (MenuItem i in menuLanguage.Items)
            {
                CultureInfo ci = i.Tag as CultureInfo;
                i.IsChecked = ci != null && ci.Equals(currLang);
            }
        }

        private void ChangeLanguage(object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                CultureInfo lang = mi.Tag as CultureInfo;
                if (lang != null)
                {
                    App.Language = lang;
                    
                }
            }

        }


        private void Search(object sender, RoutedEventArgs e)
        {
            _saveToOrReadFrom = new SaveToOrReadFrom(SearchPath);
            _searchIOService = new SaveToOrReadFrom(FilterPath);
            _searchService = new SearchService();
            try
            {
                if (SearchInput.Text != null)
                    toDoL.ItemsSource = _searchService.SearchItems(_toDoData, SearchInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
                throw;
            }
        }

        private void SetCursor()
        {
            var info = Application.GetResourceStream(new Uri("pack://application:,,,/Images/4.cur"));
            Cursor customCursor = new Cursor(info.Stream);
            this.Cursor = customCursor;
        }

        private void Search_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void MenuItem_ByCategory(object sender, RoutedEventArgs e)
        {
           
            _saveToOrReadFrom = new SaveToOrReadFrom(Path);
            _filterIOService = new SaveToOrReadFrom(FilterPath);
            _filterService = new FilterService();
            MenuItem menuItem = (MenuItem)sender;//определение по какой категории будет фильтр
            try
            {
                toDoL.ItemsSource = _filterService.FilterBy("By Category", _toDoData, menuItem.Header.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
                throw;
            }

        }
        private void MenuItem_ByPriority(object sender, RoutedEventArgs e)
        {
            _saveToOrReadFrom = new SaveToOrReadFrom(Path);
            _filterIOService = new SaveToOrReadFrom(FilterPath);
            _filterService = new FilterService();
            MenuItem menuItem = (MenuItem)sender;//определение по какой категории будет фильтр
            try
            {
                toDoL.ItemsSource = _filterService.FilterBy("By Priority", _toDoData, menuItem.Header.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
                throw;
            }

        }

        private void MenuItem_ByDate(object sender, RoutedEventArgs e)
        {
           
            _saveToOrReadFrom = new SaveToOrReadFrom(Path);
            _filterIOService = new SaveToOrReadFrom(FilterPath);
            _filterService = new FilterService();
            MenuItem menuItem = (MenuItem)sender;//определение по какой категории будет фильтр
            try
            {
                toDoL.ItemsSource = _filterService.FilterBy("By Date", _toDoData, menuItem.Header.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
                throw;
            }

        }

        
    }


 
}
