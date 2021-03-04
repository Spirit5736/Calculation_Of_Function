using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Calculation_of_functions
{
    public class Formula : INotifyPropertyChanged
    {
        private string title;
        private string formulaOfFunction;

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
                title = value;
                OnPropertyChanged("formulaOfFunction");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}