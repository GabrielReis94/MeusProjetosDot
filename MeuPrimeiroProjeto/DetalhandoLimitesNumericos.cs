using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto
{
    public class DetalhandoLimitesNumericos
    {
        public static void AnalisandoDados()
        { 
            Int16 x = Int16.MinValue;//460; // minimo -32768 maximo 32767
            UInt16 y = 6056; // minimo 0 maximo 65535

            Int32 u = 8606; // minimo -2147483648 maximo  2147483647
            UInt32 p = 56869; // minimo 0 maximo 4294967295

            Int64 e = 124950; // minimo -9223372036854775808  maximo 9223372036854775807
            UInt64 q = 584500; // minimo -9223372036854775808 maximo 9223372036854775807

        }
    }
}
