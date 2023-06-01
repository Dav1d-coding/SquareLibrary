using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary.Figures
{
    public class Triangle : Figure
    {
        private readonly Lazy<bool> _isRightAngled;

        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }

        public bool IsRightAngled => _isRightAngled.Value;



        private bool CheckIsRightAngled()
        {
            var maxSide = new[] { FirstSide, SecondSide, ThirdSide }.Max();
            var maxSideSqr = maxSide * maxSide;
            return maxSideSqr + maxSideSqr == FirstSide * FirstSide + SecondSide * SecondSide + ThirdSide * ThirdSide;
        }

        public Triangle(double firstSide, double secondSide, double thirdSide) 
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
                throw new ArgumentOutOfRangeException("Сторона не может быть отрицательной");
            if(firstSide + secondSide < thirdSide ||  thirdSide + secondSide < firstSide || firstSide + thirdSide < secondSide)
                throw new ArgumentOutOfRangeException("Фигура не является треугольником");
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;

            _isRightAngled = new Lazy<bool>(CheckIsRightAngled);
        }
        protected sealed override double CalculateSquare()
        {
            var semiPer = (FirstSide + SecondSide + ThirdSide) / 2;

            return Math.Sqrt(semiPer * (semiPer - FirstSide) * (semiPer - SecondSide) * (semiPer - ThirdSide));
        }
    }
}
