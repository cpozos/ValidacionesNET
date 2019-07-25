using System;
using System.Collections.Generic;
using System.Text;

namespace Validaciones
{
   public interface IValidacion<T>
   {
      ResultadoValidacion Validar(ContextoValidacion<T> contexto);
   }
}
