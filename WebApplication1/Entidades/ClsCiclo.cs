using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entidades
{
    public class ClsCiclo
    {
        public int Numero { get; private set; }
        List<ClsDia> dias = new List<ClsDia>();
    }
}