using PruebaWPF.datos;
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
using System.Windows.Shapes;

namespace PruebaWPF
{
    /// <summary>
    /// Lógica de interacción para DialogoAlimento.xaml
    /// </summary>
    public partial class DialogoAlimento : Window
    {
        private LogicaNegocio logicaNegocio; //instanciamos la otra clase
        public Alimento alimento;
        private int errores;

        public DialogoAlimento(LogicaNegocio logicaNegocio) //referenciamos para poder llamar sus metodos
        {   
            InitializeComponent();
            this.logicaNegocio = logicaNegocio; // la iniciamos
            alimento = new Alimento();
            this.DataContext = alimento;
        }

        private void Enviar_Click(object sender, RoutedEventArgs e)
        {
            logicaNegocio.aniadirAlimento(alimento);
            alimento = new Alimento();
            this.DataContext = alimento;
            this.Close();

        }
        public void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
            {
                errores++;
            }
            else
                errores--;
            if (errores == 0)
                Enviar.IsEnabled = true;
            else
                Enviar.IsEnabled = false;
        }
    }
}
