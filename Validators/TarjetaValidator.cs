using System;
using System.Collections.Generic;
using System.Text;

using Validaciones.Validaciones.ValidacionesExtensionsTarjeta;

namespace Validaciones
{
   public class TarjetaValidator : AbstractValidator<Tarjeta>
   {
      protected override ResultadoValidacion EjecucionValidaciones()
      {
         _contexto
            .NotNullValidacion()
            .LongitudMayorA(15);

         return _contexto.ResultadoPreviaValidacion;
      }
   }
}
