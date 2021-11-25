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
    /// Lógica de interacción para DialogoModificarAlimento.xaml
    /// </summary>
    public partial class DialogoModificarAlimento : Window
    {
        private LogicaNegocio logicaNegocio; //instanciamos la otra clase
        public Alimento alimento;

        public DialogoModificarAlimento(LogicaNegocio logicaNegocio) //referenciamos para poder llamar sus metodos
        {
            InitializeComponent();
            this.logicaNegocio = logicaNegocio; // la iniciamos
            alimento = new Alimento();
            this.DataContext = alimento;
        }

        private void cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            int cambiar_cantidad = Convert.ToInt32(CambiarCantidad.Text);
            foreach (Alimento alimento in logicaNegocio.listaAlimentos)
            { 
                if (alimento.Nombre.Equals(nombreAlimento.Text))
                {
                    alimento.Clone();
                    alimento.cantidadConsumida = cambiar_cantidad;
                }
            }
            this.Close();
        }
    }
}
