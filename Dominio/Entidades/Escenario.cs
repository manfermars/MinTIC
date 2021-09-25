using System;
using System.Collections.Generic;

namespace Dominio{
    public  class Escenario{
        public int Id{get;set;}
        public string Nombre{get;set;}
        public string Direccion{get;set;}
        public string Telefono{get;set;}
        public string Horario{get;set;}
        //Propiedad navigacional de tabla Cancha
        public List<Cancha> Canchas {get;set;}
        //Llave foranea de tabla Torneo
        public int TorneoId{get;set;}        
    }
}