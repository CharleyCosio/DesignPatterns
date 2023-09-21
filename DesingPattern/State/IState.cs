using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.State
{
    public interface IState
    {

        void Action(CustomerContext customerContext,decimal amount);


    }
}
