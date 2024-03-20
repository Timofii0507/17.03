using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._03
{
    public interface IVisitor
    {
        void VisitCircle(Circle circle);
        void VisitSquare(Square square);
    }

}
