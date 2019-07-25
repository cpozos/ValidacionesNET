using System;

namespace Validaciones
{
   public interface IValidator<T>
   {
      ResultadoValidacion Validar(T entidad);
   }
}
