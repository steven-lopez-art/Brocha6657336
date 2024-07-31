using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Brocha6657336.ViewModels
{
    public partial class MainViewModels : ObservableObject
    {
        [ObservableProperty]
        public int metrosc;

        [ObservableProperty]
        public string costo;


        [RelayCommand]
        public void Calcular()
        {
            double a = Metrosc * 1.50;
            Costo = $" ${a:F2}";
        }
    }
}