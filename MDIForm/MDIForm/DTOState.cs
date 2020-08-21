using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDIForm
{

    [Serializable]
    public class DTOState
    {
        public int Index { get; set; }

        public Point Location { get; set; }

        public Size Size { get; internal set; }

        public DTOState()
        {

        }

        public DTOState(Int32 index, Point location, Size size)
        {
            this.Index = index;
            this.Location = location;
            this.Size = size;

        }

    }

}


