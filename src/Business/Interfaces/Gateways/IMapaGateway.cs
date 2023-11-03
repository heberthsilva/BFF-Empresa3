using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Models;

namespace Business.Interfaces.Gateways
{
    public interface IMapaGateway
    {
        DefaultRetorno GetParadasPorCoordenadas(string latitude, string longitude);
    }
}
