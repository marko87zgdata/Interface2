using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8
{
    interface IDepozit
    {
        public bool HasCashDepozit();

        public double GetCashDepozitAmount();
    }
}
