using System;
using System.Collections.Generic;
using System.Text;

namespace Validaciones
{
   public class ContextoValidacion<T>
   {
      public T Objeto { get; set; }
      public string StrMensaje { get; set; }
      public ResultadoValidacion ResultadoPreviaValidacion { get; set; }

   }
}
