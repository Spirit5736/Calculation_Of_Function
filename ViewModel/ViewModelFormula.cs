using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.Windows.Data;
using Calculation_of_functions.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Dynamic;
using System.Data;


namespace Calculation_of_functions.ViewModel 
{
    public class ViewModelFormula : BaseViewModel
    {
        private string title;
        private string formulaOfFunction;
        private double coefficientA;
        private double coefficientB;
        private int coefficientC;
        private int[] coefficientsC = new int[] { 0, 1, 2, 3,};
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

        public int CoefficientC
        {
            get { return coefficientC; }
            set
            {
                coefficientC = value ;
                OnPropertyChanged("CoefficientC");
            }
        }
        public int[] CoefficientsC
        {
            get { return coefficientsC; }
            set
            {
                coefficientsC = value;
                OnPropertyChanged("CoefficientsC");
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
                valueFXY = ValueX + ValueY;
                OnPropertyChanged("ValueFXY");
               

            }
        }
        public int Degree { get; set; }
        public double CalculateOfFunction()
        {
            //f(x, y) = ax + by^0 + c
            valueFXY = Math.Pow(coefficientA * valueX, Degree) + Math.Pow(coefficientB * valueY, Degree - 1);
            return valueFXY;
        }
    }

}
