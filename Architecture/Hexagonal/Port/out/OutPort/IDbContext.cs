using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutPort
{
    public interface IDbContext
    {
        IDbConnection GetConnection(string conn = "TTPHotel");
    }
}
