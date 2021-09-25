using System;
using System.Collections.Generic;

namespace Dominio{
    public  class Torneo{
        public int Id{get;set;}
        public string Nombre{get;set;}
        public DateTime FechaInicial{get;set;}
        public DateTime FechaFinal{get;set;}
        public string Tipo{get;set;}
        //Propiedad navigacional de tabla intermedia TorneoEquipo
        public List<TorneoEquipo> TorneosEquipos{get;set;}
        //Llave foranea tabla Municipio
        public int MunicipioId{get;set;}
        //Propiedad navigacional de tabla Arbitro
        public List<Arbitro> Arbitros {get;set;}
        //Propiedad navigacional de tabla Escenario
        public List<Escenario> Escenarios{get;set;}
    }
}