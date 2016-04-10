using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entidades
{
    public class ClsDia
    {
        public string Nomb { get; private set; }
        List<ClsBloque> bloques = new List<ClsBloque>();
    }
}