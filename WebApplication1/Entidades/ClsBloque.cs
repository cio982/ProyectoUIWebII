using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Entidades
{
    public class ClsBloque
    {
        public string HoraE { get; private set; }
        public string HoraS { get; private set; }
        public ClsSalon salon= new ClsSalon();
        
    }
}