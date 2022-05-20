using TaskList.Core;

namespace TaskList.Views.Models
{
    public class MainViewModel : ObservableObject
    {
        public RelayCommand NearViewCommand { get; set; }
        public RelayCommand TodayViewCommand { get; set; }
        public RelayCommand WeeklyViewCommand { get; set; }
        
        public NearViewModel NearVM { get; set; }
        public TodayViewModel TodayVM { get; set; }
        public WeeklyViewModel WeeklyVM { get; set; }
        
        private object _content;

        public object ContentView
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            NearVM = new NearViewModel();
            TodayVM = new TodayViewModel();
            WeeklyVM = new WeeklyViewModel();
            
            ContentView = NearVM;
            
            NearViewCommand = new RelayCommand(o =>
            {
                ContentView = NearVM;
            });
            
            TodayViewCommand = new RelayCommand(o =>
            {
                ContentView = TodayVM;
            });
            
            WeeklyViewCommand = new RelayCommand(o =>
            {
                ContentView = WeeklyVM;
            });
        }
        
    }
}