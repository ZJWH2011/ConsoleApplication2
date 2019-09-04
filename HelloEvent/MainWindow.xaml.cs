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

namespace HelloEvent
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //public bool CanChecked { get; set; }

        ViewModel1 vm = new ViewModel1();

        public MainWindow()
        {
            InitializeComponent();


            this.DataContext = vm;

            this.button1.Click += delegate
            {
            };

            this.checkBox.Click += delegate
            {
                vm.CanChecked = (bool)this.checkBox.IsChecked;

                vm.BuildCommand.RaiseCanExecuteChanged();
            };

            //this.checkBox1.IsChecked = vm.BoxSet;
        }

    }
}
