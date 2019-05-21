//David
//may 21st 2019
//factorials

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

namespace Factorials
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ulong x = 40;
            MessageBox.Show(factorial(x).ToString());
        }

        public ulong factorial(ulong f)
        {
            if (f == 1 || f == 0)
            {
                return 1;
            }
            else
            {
                return f * factorial(f - 1);
            }
        }
    }
}
