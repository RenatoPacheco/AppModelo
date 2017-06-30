using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppModelo.ViewModels
{
    public class MainPageViewModel : Comum.BaseViewModel
    {
        public MainPageViewModel()
        {
            this.SubmeterCmd = new Command(() => {

            }, () => {
                return this.Opacidade > 0.5;
            });
        }

        public ICommand SubmeterCmd { get; private set; }

        private double _opacidade;
        public double Opacidade
        {
            get { return this._opacidade; }
            set
            {
                this._opacidade = value;
                // Avisando a mudança aos demais observadores
                this.OnPropertyChanged();
                // Avisando mudança ao comando
                ((Command)this.SubmeterCmd).ChangeCanExecute();
            }
        }

    }
}
