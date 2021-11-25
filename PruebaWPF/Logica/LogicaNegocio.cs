using PruebaWPF.datos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaWPF.Logica
{
    public class LogicaNegocio
    {
       public ObservableCollection<Alimento> listaAlimentos{ get; set; }
       public LogicaNegocio()
        {

            listaAlimentos = new ObservableCollection<Alimento>();
            Alimento alimento = new Alimento("manzana", 56, 0, 0);
            Alimento alimento1 = new Alimento("pera", 52, 0, 0);
            Alimento alimento2 = new Alimento("platano", 60, 0, 0);
            listaAlimentos.Add(alimento);
            listaAlimentos.Add(alimento1);
            listaAlimentos.Add(alimento2);
        }
        public void aniadirAlimento(Alimento alimento)
        {
            listaAlimentos.Add(alimento);
        }
    }
}
