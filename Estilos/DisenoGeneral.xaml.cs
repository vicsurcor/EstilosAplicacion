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

namespace Estilos
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class DisenoGeneral : Window
    {
        public DisenoGeneral()
        {
            InitializeComponent();
        }

        public void VolverAlMenu(object sender, RoutedEventArgs args)
        {

            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();

        }
    }
}
