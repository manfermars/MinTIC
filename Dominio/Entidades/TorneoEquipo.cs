using System;
using System.Collections.Generic;

namespace Dominio{
    public  class TorneoEquipo{
        //Llave principal compuesta por dos campos ID
        public int TorneoId{get;set;}
        public int EquipoId{get;set;}
        //Propiedad navigacional de tabla Torneo
        public Torneo Torneo {get;set;}
        //Propiedad navigacional de tabla Equipo
        public Equipo Equipo {get;set;}

    }
}