using System;
using Dominio;
using Persistencia;
using System.Collections.Generic;

namespace Consola
{
    class Program
    {
        //Instanciar objeto de tipo IRepositorioMunicipio
        private static IRepositorioMunicipio _repmunicipio=new RepositorioMunicipio(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            /*bool res= crearMunicipios();
            if (resultado)
            {
                Console.WriteLine("Municipio agregado con exito");
            }
            else
            {
                Console.WriteLine("Falla en el proceso de registro");
            }*/
            //---------------------------------------------------------
            /*bool res = eliminarMunicipios();
            if (res)
            {
                Console.WriteLine("Municipio eliminado con exito");
            }
            else
            {
                Console.WriteLine("Falla en el proceso de eliminacion");
            }*/
            //----------------------------------------------------------
            /*bool res = actualizarMunicipios();
            if (res)
            {
                Console.WriteLine("Municipio actualizado con exito");
            }
            else
            {
                Console.WriteLine("Falla en el proceso de actualizacion");
            }
            Console.WriteLine("Lista actualizada");
            listarMunicipios();*/

            buscarMunicipios();
        }
        private static bool crearMunicipios(){
        
        var municipio = new Municipio{
            Nombre="Cartagena"
        };
        bool resultado= _repmunicipio.CrearMunicipio(municipio);
        return resultado;
        }

        private static void listarMunicipios(){
            IEnumerable<Municipio> municipios=_repmunicipio.ListarMunicipio();
            foreach (var mun in municipios){
                Console.WriteLine(mun.Id+" "+mun.Nombre);
            }
        }

        private static bool eliminarMunicipios(){
            bool resultado = _repmunicipio.EliminarMunicipio(2);
            return resultado;
        }

        private static bool actualizarMunicipios(){
            var municipio=new Municipio{
                Id=3,
                Nombre="Cali"
            };
            bool resultado=_repmunicipio.ActualizarMunicipio(municipio);
            return resultado;
        }

        private static void buscarMunicipios(){
            var mun=_repmunicipio.BuscarMunicipio(3);
            if (mun!=null)
            {
                Console.WriteLine(mun.Id);
                Console.WriteLine(mun.Nombre);
            }
            else
            {
                Console.WriteLine("Municipio no encontrado");
            }
        }
    }    
}
