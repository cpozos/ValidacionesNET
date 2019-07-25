using System;
using System.Collections.Generic;
using System.Text;

namespace Validaciones
{
   public class NotNullValidacion<T> : IValidacion<T>
   {
      public ResultadoValidacion Validar(ContextoValidacion<T> contexto)
      {
         ResultadoValidacion res = new ResultadoValidacion { BooEsValida = false, StrMensaje = "" };

         if (contexto.ResultadoPreviaValidacion != null && !contexto.ResultadoPreviaValidacion.BooEsValida)
            return res;
         

         else if (!(contexto.Objeto != null))
         {
            res.BooEsValida = false;
            res.StrMensaje = contexto.StrMensaje ?? "Error";
            return res;
         }

         return res;            
      }
   }
}
