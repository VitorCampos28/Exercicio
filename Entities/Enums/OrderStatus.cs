using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_de_Fixacao.Entities.Enums
{
    enum OrderStatus : int 
    {
        PendingPatment = 0 ,
        Processing = 1 ,
        Shipped = 2 ,
        Delivered = 3 
    }
}
