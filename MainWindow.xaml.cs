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

namespace CommandeRoutees
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CouperCopierColler_CanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Couper_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Box.Cut();
            MessageBox.Show("le texte à été coupé ! ");
        }

        
        private void Copier_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Box.Copy();
            MessageBox.Show("le texte à été copié ! ");
        }

        private void Coller_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Box.Paste();
            MessageBox.Show("le texte à été Collé ! ");
        }


    }
}
