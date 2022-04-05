using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTGUI_W7.Logic
{
    public interface IGameControl
    {
        void Move(MoveEnum moveEnum);
    }
}
