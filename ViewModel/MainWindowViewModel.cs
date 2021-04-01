using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Calculation_of_functions.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private ViewModelFormula selectedFormula;

        public ObservableCollection<ViewModelFormula> Formulas { get; set; }
        //public List<Formula> DatagridFormulas { get; set; }
        public ViewModelFormula SelectedFormula
        {
            get { return selectedFormula; }
            set
            {
                selectedFormula = value;
                OnPropertyChanged(nameof(SelectedFormula));
            }
        }

        public MainWindowViewModel()
        {
            Formulas = new ObservableCollection<ViewModelFormula>
            {
                new ViewModelFormula {Title="Линейная функция", FormulaOfFunction ="f(x, y) = ax + by^0 + c", CoefficientsC = new int[] {1, 2, 3, 4, 5 }, CoefficientA = 2, CoefficientB = 4, Degree =1, },
                new ViewModelFormula {Title="Квадратичная функция", FormulaOfFunction="f(x, y) = ax^2 + by^1 + c", CoefficientsC = new int[] { 10, 20, 30, 40, 50 }, Degree =2,},
                new ViewModelFormula {Title="Кубическая функция", FormulaOfFunction="f(x, y) = ax^3 + by^2 + c", CoefficientsC = new int[] { 100, 200, 300, 400, 500 }, Degree =3,},
                new ViewModelFormula {Title="Функция 4-ой степени", FormulaOfFunction="f(x, y) = ax^4 + by^3 + c", CoefficientsC = new int[] { 1000, 2000, 3000, 4000, 5000 }, Degree =4,},
                new ViewModelFormula {Title="Функция 5-ой степени", FormulaOfFunction="f(x, y) = ax^5 + by^4 + c", CoefficientsC = new int[] { 10000, 20000, 30000, 40000, 50000 }, Degree =5,},
            };
        }
    }
}
