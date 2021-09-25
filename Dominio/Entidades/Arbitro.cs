using System;
using System.Collections.Generic;

namespace Dominio{
    public  class Arbitro{
        public int Id{get;set;}
        public string Documento{get;set;}
        public string Nombres{get;set;}
        public string Apellidos{get;set;}
        public string Genero{get;set;}
        public string Celular{get;set;}
        public string Correo{get;set;}
        public string Disciplina{get;set;}
        //Llave foranea de tabla Torneo
        public int TorneoId{get;set;}
        //Llave foranea de tabla ColegioInstruccion
        public int ColegioId{get;set;}          
    }
}