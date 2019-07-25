using System;
using System.Collections.Generic;
using System.Text;

namespace Validaciones
{
   public abstract class AbstractValidator<T> : IValidator<T>
   { 
      protected ContextoValidacion<T> _contexto;

      public AbstractValidator()
      {
         _contexto = new ContextoValidacion<T>();
      }

      public ResultadoValidacion Validar(T pObjeto)
      {
         _contexto = new ContextoValidacion<T>();
         _contexto.Objeto = pObjeto;

         return EjecucionValidaciones();
      }

      protected abstract ResultadoValidacion EjecucionValidaciones();

      
   }
}
