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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace payroll_application.windows
{
    
    public partial class autWindow : Window
    {
   
        public autWindow()
        {
            InitializeComponent();

        }

        private void exitApp(object sender,MouseButtonEventArgs e) {
            Application.Current.Shutdown();
        }





        public void dragClick(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
