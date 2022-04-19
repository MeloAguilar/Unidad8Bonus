using DAL.Listas;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.ViewModels
{
    public class PlantasDescripcionesVM
    {
        #region Atributos Privados

        private List<clsPlanta> plantas;
        #endregion

        #region Atributos Publicos
        public List<clsPlanta> Plantas
        {
            get
            {
                ListadosPlantas p = new ListadosPlantas();
                return plantas = p.ListadoPlantas();   
            }
        }



        public clsPlanta PlantaSeleccionada { get; set; }
        #endregion

        public PlantasDescripcionesVM()
        {
            PlantaSeleccionada = new clsPlanta() { Nombre = "", Datos = "" };
           
        }
    }
}
