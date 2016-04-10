using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entidades
{
    public class ClsCurso
    {
        /// <summary>
        /// 1=Educacion General
        /// 2=Area Básica Formativa I
        /// 3=Area Basica Formativa II
        /// 4=Desarrollo de Software
        /// 5=Administracion de Base de Datos e Inteligencia de Negoios
        /// 6=Administracion de Redes e Infraestructura de TI
        /// 7=Gestion de Proyectos de TI 
        /// </summary>
        public string NombDoc { get; private set; }
        public int Area { get; private set; }
        List<ClsDia> dias = new List<ClsDia>();
    }
}