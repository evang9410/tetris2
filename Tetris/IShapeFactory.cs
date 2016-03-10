using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public interface IShapeFactory
    {
        void DeployNewShape();
        IShape CurrentShape { get; }

    }
}
