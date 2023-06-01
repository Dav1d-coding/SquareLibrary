using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    public abstract class Figure
    {
        private Lazy<double> _square;

        public double Square => _square.Value;

        protected Figure() 
        {
            _square = new Lazy<double>(CalculateSquare);
        }

        protected abstract double CalculateSquare();
    }
}
