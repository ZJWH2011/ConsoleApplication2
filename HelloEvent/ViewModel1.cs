using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HelloEvent
{
    class ViewModel1: INotifyPropertyChanged
    {
        public HelloWorldEvent BuildCommand { get; set; }

        public bool CanChecked { get; set; }

        private bool _boxSet = false;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool BoxSet
        {
            get
            {
                return _boxSet;
            }
            set
            {
                _boxSet = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoxSet"));
            }
        }

        public ViewModel1()
        {
            BuildCommand = new HelloWorldEvent();
            BuildCommand.ExecuteCommand = new Action<object>(Build);
            BuildCommand.CanExecuteChanged += hh;
            BuildCommand.CanExecuteCommand = sssss;
        }
        private void Build(object obj)
        {
            string str = (string)obj;

            MessageBox.Show(str);
        }

        private void hh(object sender, EventArgs e)
        {
            BoxSet = CanChecked;
        }

        private bool sssss(object sender)
        {
            return CanChecked;
        }
    }
}
