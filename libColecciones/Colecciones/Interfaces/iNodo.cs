﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Colecciones.Interfaces
{
    interface iNodo <Tipo>
    {
        Tipo darItem();
        void ponerItem(Tipo prmContenido);
    }
}
