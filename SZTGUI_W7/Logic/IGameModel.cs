using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTGUI_W7.Logic
{
    public interface IGameModel
    {
        double Position { get; set; }
        event EventHandler Changed;
        public Ball Orb { get; set; }
        public Wall Barrier { get; set; }
    }
}
