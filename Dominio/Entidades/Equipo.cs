using System;
using System.Collections.Generic;

namespace Dominio{
    public  class Equipo{
        public int Id{get;set;}
        public string Identificacion{get;set;}
        public string Nombre{get;set;}
        public int CantidadDeportistas{get;set;}
        public string Disciplina{get;set;}
        //Propiedad navigacional de tabla Entrenador
        public Entrenador Entrenador {get;set;}
        //Llave foranea de tabla Patrocinador
        public int PatrocinadorId{get;set;}
        //Propiedad navigacional de tabla intermedia TorneoEquipo
        public List<TorneoEquipo> TorneosEquipos{get;set;}
        //Propiedad navigacional de tabla Deportista
        public List<Deportista> Deportistas{get;set;}
    }
}