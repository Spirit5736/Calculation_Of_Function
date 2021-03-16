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
    public class ViewModelFormula : INotifyPropertyChanged
    {
        private Formula selectedFormula;
        
        

        public ObservableCollection<Formula> Formulas { get; set; }
        public List<Formula> DatagridFormulas { get; set; }
        public Formula SelectedFormula
        {
            get { return selectedFormula; }
            set
            {
                selectedFormula = value;
                OnPropertyChanged("SelectedFormula");
            }
        }

        public ViewModelFormula()
        {
            Formulas = new ObservableCollection<Formula>
            {
                new Formula {Title="Линейная функция", FormulaOfFunction ="f(x, y) = ax + by^0 + c", CoefficientC = new int[] { 1, 2, 3, 4, 5 }},
                new Formula {Title="Квадратичная функция", FormulaOfFunction="f(x, y) = ax^2 + by^1 + c", CoefficientC = new int[] { 10, 20, 30, 40, 50 }},
                new Formula {Title="Кубическая функция", FormulaOfFunction="f(x, y) = ax^3 + by^2 + c", CoefficientC = new int[] { 100, 200, 300, 400, 500 }},
                new Formula {Title="Функция 4-ой степени", FormulaOfFunction="f(x, y) = ax^4 + by^3 + c", CoefficientC = new int[] { 1000, 2000, 3000, 4000, 5000 }},
                new Formula {Title="Функция 5-ой степени", FormulaOfFunction="f(x, y) = ax^5 + by^4 + c", CoefficientC = new int[] { 10000, 20000, 30000, 40000, 50000 }},
            };  
        }

        
        


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));

        }

    }

}
