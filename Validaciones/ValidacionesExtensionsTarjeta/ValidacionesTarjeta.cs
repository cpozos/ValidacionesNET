using System;
using System.Collections.Generic;
using System.Text;

namespace Validaciones.Validaciones.ValidacionesExtensionsTarjeta
{
   public static class ValidacionesTarjeta
   {
      public static ContextoValidacion<Tarjeta> NotNullValidacion(this ContextoValidacion<Tarjeta> contexto)
      {
         contexto.ResultadoPreviaValidacion = new NotNullValidacion<Tarjeta>().Validar(contexto);
         return contexto;
      }

      public static ContextoValidacion<Tarjeta> LongitudMayorA (this ContextoValidacion<Tarjeta> contexto, int longitud)
      {
         ContextoValidacion<string> contextoValidacion = new ContextoValidacion<string>
         {
            ResultadoPreviaValidacion = contexto.ResultadoPreviaValidacion,
            StrMensaje = contexto.StrMensaje,
            Objeto = contexto.Objeto.StrNumero
         };

         contexto.ResultadoPreviaValidacion = new LongitudMayorA(longitud).Validar(contextoValidacion);

         return contexto;         
      }


   }
}
