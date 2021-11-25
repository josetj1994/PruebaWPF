using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaWPF.datos
{
     public class Alimento : INotifyPropertyChanged,IDataErrorInfo,ICloneable
    {
        public int cantidad;

        public String Nombre
        {
            get;
            set;
        }

        public int caloriasMedias
        {
            get;
            set;
        }
        public int cantidadConsumida
        {
            get { return cantidad; }
            set
            {
                this.cantidad = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("cantidadConsumida"));
            }
        }
        public int caloriasConsumidas { get; set; }

        public string Error
        {
            get { return ""; } 
        }

        public string this[string columnName]
        {
            get
            {
                string result = "";
                if (columnName == "Nombre")
                {
                    if (string.IsNullOrEmpty(Nombre))
                        result = "Debe introducir nombre";
                }
                if (columnName == "caloriasMedias")
                {
                    if (caloriasMedias.Equals(0))
                        result = "Debe introducir calorias";
                }
                if (columnName == "cantidadConsumida")
                {
                    if (cantidadConsumida.Equals(0))
                        result = "Debe introducir calorias";
                }
                return result;
            }
        }
        public Alimento(String nombre, int caloriasMedias, int cantidadConsumida, int caloriasConsumidas)
        {
            this.Nombre = nombre;
            this.caloriasMedias = caloriasMedias;
            this.cantidad = cantidadConsumida;
            this.caloriasConsumidas = caloriasConsumidas;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public Alimento()
        {
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
