using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime;
using System;

namespace Calculation_of_functions
{
    public class Formula : INotifyPropertyChanged
    {
        private string title;
        private string formulaOfFunction;
        private double coefficientA;
        private double coefficientB;
        private int[] coefficientC;
        private double valueX; 
        private double valueY;
        private double valueFXY;
       

      

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public string FormulaOfFunction
        {
            get { return formulaOfFunction; }
            set
            {
                formulaOfFunction = value;
                OnPropertyChanged("FormulaOfFunction");
            }
        }

        public double CoefficientA
        {
            get { return coefficientA; }
            set
            {
                coefficientA = value;
                OnPropertyChanged("CoefficientA");
            }
        }

        public double CoefficientB
        {
            get { return coefficientB; }
            set
            {
                coefficientB = value;
                OnPropertyChanged("CoefficientB");
            }
        }

        public int[] CoefficientC
        {
            get { return coefficientC; }
            set
            {
                coefficientC = value; ;
                OnPropertyChanged("CoefficientC");
            }
        }

        public double ValueX
        {
            get { return valueX; }
            set
            {
                valueX = value;
                OnPropertyChanged("ValueX");
            }
        }

        public double ValueY
        {
            get { return valueY; }
            set
            {
                valueY = value;
                OnPropertyChanged("ValueY");
            }
        }

        public double ValueFXY
        {
            get { return valueFXY; }
            set
            {
                if (Title == "Линейная функция")
                {
                    valueFXY = valueX+valueY;
                }
               
                OnPropertyChanged("ValueFXY");
            }
        }

        public double LinearFunction()
        {
            //f(x, y) = ax + by^0 + c
            valueFXY = Math.Pow(coefficientA * valueX, 1) + Math.Pow(coefficientB * valueY, 0) + coefficientC[0];
            return valueFXY;
        }

        public double QuadraticFunction()
        {
            //f(x, y) = ax^3 + by^2 + c
            double valueFXY = Math.Pow(coefficientA * valueX, 2) + Math.Pow(coefficientB * valueY, 1) + coefficientC[0];
            return valueFXY;
        }

        public double QubicFunction()
        {
            //f(x, y) = ax ^ 3 + by ^ 2 + c"
            double valueFXY = Math.Pow(coefficientA * valueX, 3) + Math.Pow(coefficientB * valueY, 2) + coefficientC[0];
            return valueFXY;
        }

        public double FourthDegreeFunction()
        {
            //f(x, y) = ax ^ 4 + by ^ 3 + c"
            double valueFXY = Math.Pow(coefficientA * valueX, 4) + Math.Pow(coefficientB * valueY, 3) + coefficientC[0];
            return valueFXY;
        }

        public double FifthDegreeFunction()
        {
            //f(x, y) = ax ^ 5 + by ^ 4 + c"
            double valueFXY = Math.Pow(coefficientA * valueX, 5) + Math.Pow(coefficientB * valueY, 4) + coefficientC[0];
            return valueFXY;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


    }
}