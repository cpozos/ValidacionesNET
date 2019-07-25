using System;
using System.Collections.Generic;
using System.Text;

namespace Validaciones.Validaciones
{
   public class LongitudMayorA : IValidacion<string>
   {
      public int Longitud { get; set; }

      public LongitudMayorA(int pLongitud)
      {
         Longitud = pLongitud;
      }
      public ResultadoValidacion Validar(ContextoValidacion<string> contexto)
      {
         var res = new ResultadoValidacion { BooEsValida = true, StrMensaje = "" };

         if (contexto.ResultadoPreviaValidacion != null && !contexto.ResultadoPreviaValidacion.BooEsValida)
            return res;
         
         if (contexto.Objeto.Length < Longitud)
         {
            res.BooEsValida = false;
            res.StrMensaje = contexto.StrMensaje ?? "";
         }

         return res;
      }
   }
}
