using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace Calculation_of_functions.ViewModel
{
    public class ViewModelFormula : INotifyPropertyChanged
    {
        private Formula selectedFormula;

        public ObservableCollection<Formula> Formulas { get; set; }
        public Formula SelectedFormula
        {
            get { return selectedFormula; }
            set
            {
                selectedFormula = value;
                OnPropertyChanged("selectedFormula");
            }
        }

        public ViewModelFormula()
        {
            Formulas = new ObservableCollection<Formula>
            {
                new Formula { Title="Линейная функция", FormulaOfFunction ="f(x, y) = ax + by^0 + c"},
                new Formula {Title="Квадратичная функция", FormulaOfFunction="f(x, y) = ax^2 + by^1 + c"},
                new Formula {Title="Кубическая функция", FormulaOfFunction="f(x, y) = ax^3 + by^2 + c",},
                new Formula {Title="Функция 4-ой степени", FormulaOfFunction="f(x, y) = ax^4 + by^3 + c"},
                new Formula {Title="Функция 5-ой степени", FormulaOfFunction="f(x, y) = ax^5 + by^4 + c"},
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
