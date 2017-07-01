using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.ViewModels.Comum
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // Esse método é usado para indicar que houve atualização no binding
        public void OnPropertyChanged([CallerMemberName]string name = "")
        {
            // Usar ?. é equivalente a checar se  PropertyChanged é diferente de nulo para poder usar.
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
