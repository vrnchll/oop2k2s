﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wpf_7_8.Models
{
    public class ToDoMod:INotifyPropertyChanged
    {
        public DateTime CreationDate { get; set; } = DateTime.Now;

		private bool _Status;

        public ToDoMod(string _Category,string _Priority, string _DateEnd, string _Description, string _Task,bool _Status)
        {
            this.Category = _Category;
            this._Description = _Description;
            this._EndDate = _DateEnd;
            this._Name = _Task;
            this._Status = _Status;
            this._Priority = _Priority;
        }
		public bool Status
		{
			get { return _Status; }
			set {
				if (_Status == value)
					return;
				else _Status = value;
				OnPropertyChanged("Status");
 }
		}

		private string _EndDate;

		public string EndDate
		{
			get { return _EndDate; }
			set
			{
				if (_EndDate == value)
					return;
				_EndDate = value;
				OnPropertyChanged("EndDate");
			}
		}

		private string _Name;

		public string Name
		{
			get { return _Name; }
			set {
				if (_Name == value)
					return;
				_Name = value;
				OnPropertyChanged("Name");
			}

		}


		private string _Category;

		public string Category
		{
			get { return _Category; }
			set {
				if (_Category == value)
					return;
				_Category = value;
				OnPropertyChanged("Category");
			}
		}


		private string _Description;

		public string Description
		{
			get { return _Description; }
			set { if (_Description == value)
					return;
				_Description = value;
				OnPropertyChanged("Description");
			}
		}



		private string _Priority;

		

		public string Priority
		{
			get { return _Priority; }
			set { if (_Priority == value)
					return;
				_Priority = value;
				OnPropertyChanged("Priority");
			}
		}

		private ToDoMod selectedTask;
		public ToDoMod SelectedTask
		{
			get { return selectedTask; }
			set
			{
				selectedTask = value;
				OnPropertyChanged("SelectedTask");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
			
		}

	

	}
	public class RelayCommand : ICommand
	{
		private Action<object> execute;
		private Func<object, bool> canExecute;

		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
		{
			this.execute = execute;
			this.canExecute = canExecute;
		}

		public bool CanExecute(object parameter)
		{
			return this.canExecute == null || this.canExecute(parameter);
		}

		public void Execute(object parameter)
		{
			this.execute(parameter);
		}
	}
}
