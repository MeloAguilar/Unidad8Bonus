using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Listas
{
    public class ListadosPlantas
    {

        private List<clsPlanta> plantas { get; set; }

        public ListadosPlantas()
        {
            plantas = GenerarListadoCompleto();
        }

        /// <summary>
        /// Método que se encarga de recoger una planta dado su nombre y la devuelve como salida
        /// </summary>
        /// <param name="Nombre"></param>
        /// <returns>clsPlanta: salida</returns>
        public clsPlanta RecogerPlanta(string Nombre)
        {
            bool encontrado = false;
            clsPlanta salida = null;
            for (int i = 0; i < plantas.Count && !encontrado; i++)
            {
                if (Nombre == plantas.ElementAt(i).Nombre)
                {

                    salida = plantas.ElementAt(i);
                }
            }
            return salida;
        }

        /// <summary>
        /// Cuando tengamos base de datos esto irá en la carpeta de gestion de datos
        /// mientras tanto me parece que es lo único que se puede hacer
        /// </summary>
        /// <returns></returns>
        public List<clsPlanta> ListadoPlantas() 
        { 
            return GenerarListadoCompleto();
        }



        //En realidad en esta capa se realizarían las llamadas a la base de datos
        //Para esta ocasion se utilizará como base de datos esta misma clase por lo que este método servirá como conexion
        private List<clsPlanta> GenerarListadoCompleto()
        {
            List<clsPlanta> plants = new List<clsPlanta>();
            int cont = 0;
            plants.Add(new clsPlanta()
            {
                Id = cont,
                Nombre = "Aloe vera",
                Datos = "De la familia de las Asphodelaceae, " +
                "pertenece al género Aloe, que cuenta con más de " +
                "350 especies vegetales. Esta especie, muy habitual " +
                "entre las plantas de interior, tiene infinidad de " +
                "aplicaciones en diversos remedios naturales, " +
                "especialmente para los de la piel. Entre ellas, " +
                "la de aliviar las quemaduras, rozaduras e, incluso, " +
                "psoriasis y picaduras de insectos."
            });
            plants.Add(new clsPlanta()
            {
                Id= cont++,
                Nombre = "Valeriana",
                Datos = "La valeriana o Valeriana officinalis es una " +
                "de las plantas medicinales más empleadas en la fitoterapia. " +
                "Y es normal, ya que tiene infinidad de beneficios pero quizás " +
                "el más conocido sea el ayudar a relajarnos. La valeriana es " +
                "una planta que disminuye la ansiedad y ayuda a dormir. "
            });
            plants.Add(new clsPlanta()
            {
                Id= cont++,
                Nombre = "Amapola",
                Datos = "La amapola o Papaver rhoeas L., es una planta curativa " +
                "de la que se usan las semillas. Con estas semillas se consigue " +
                "prevenir enfermedades cardiovasculares, anemias o afecciones de " +
                "la piel."
            });
            plants.Add(new clsPlanta()
            {
                Id= cont++,
                Nombre = "Eucalipto",
                Datos = "El eucalipto o eucaliptas es una de las plantas que más usamos" +
                " para decorar la casa. Son plantas muy resistentes y perfectas " +
                "para añadir a cualquier centro de mesa. " +
                "Pero además de decorar el interior de nuestra casa, " +
                "los eucaliptos son plantas medicinales muy beneficiosas para la salud." +
                " Entre sus propiedades más conocidas está la de aliviar los síntomas " +
                "de los resfriados, en concreto afecciones respiratorias " +
                "(tos, bronquitis, neumonía, asma...)."
            });
            plants.Add(new clsPlanta()
            {
                Id= cont++,
                Nombre = "Salvia",
                Datos = "La salvia o Salvia officinalis es una de las plantas " +
                "más conocidas por utilizarse en cosméticos, pero también tiene" +
                "otras funciones. Entre las más conocidas está su utilización " +
                "para aliviar los síntomas de la menopausia."
            });
            plants.Add(new clsPlanta()
            {
                Id= cont++,
                Nombre = "Arándanos",
                Datos = "Los arándanos o también llamado como cranberry " +
                "(o Vaccinium macrocarpon) junto con las frambuesas " +
                "son algunos de los ingredientes principales de los boles " +
                "que más verás en un desayuno saludable. " +
                "Pues bien, los arándanos, muy populares en la fitoterapia, " +
                "a pesar de ser muy pequeños, cuentan con muchas propiedades, " +
                "entre las que destaca su capacidad antibacteriana, " +
                "ya que ayuda a combatir infecciones. "
            });
            return plants;
        }
    }
}
