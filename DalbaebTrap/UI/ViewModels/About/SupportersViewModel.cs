using System.Windows;

namespace DalbaebTrap.UI.ViewModels.About
{
    public class SupportersViewModel : NotifyPropertyChangedViewModel
    {
        public SupporterData? SupporterData { get; private set; }
        
        public GenericTriState LoadedState { get; set; } = GenericTriState.Unknown;

        public string LoadError { get; set; } = "";

        public int Columns { get; set; } = 3;

        public SizeChangedEventHandler? WindowResizeEvent;

        public SupportersViewModel()
        {
            WindowResizeEvent += OnWindowResize;

            SupporterData = new SupporterData
            {
                Monthly = new SupporterGroup
                {
                    Supporters = new List<Supporter>
                    {
                        new() { Name = "munLook2" }
                    }
                }
            };

            LoadedState = GenericTriState.Successful;
            OnPropertyChanged(nameof(SupporterData));
            OnPropertyChanged(nameof(LoadedState));
        }

        private void OnWindowResize(object sender, SizeChangedEventArgs e)
        {
            if (!e.WidthChanged)
                return;

            int newCols = (int)Math.Floor(e.NewSize.Width / 200);

            if (Columns == newCols)
                return;
             
            Columns = newCols;
            OnPropertyChanged(nameof(Columns));
        }
    }
}
