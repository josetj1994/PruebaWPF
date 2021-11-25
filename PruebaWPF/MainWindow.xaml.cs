using PruebaWPF.Logica;
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

namespace PruebaWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LogicaNegocio logicaNegocio;
        public MainWindow()
        {
            InitializeComponent();
            logicaNegocio = new LogicaNegocio();
            tablaAlimentos.DataContext = logicaNegocio;
            
        }

        private void añadir_Click(object sender, RoutedEventArgs e)
        {
            DialogoAlimento dialogoAlimento = new DialogoAlimento(logicaNegocio);
            dialogoAlimento.Show();
        }

        private void modificar_Click(object sender, RoutedEventArgs e)
        {
            DialogoModificarAlimento dialogoModificarAlimento = new DialogoModificarAlimento(logicaNegocio);
            dialogoModificarAlimento.Show();

        }
        //  private void Validation_Error(object sencer,ValidationErrorEventArgs e)
        //{
        //    if(e.Action ==)
        //  }
    }
}
