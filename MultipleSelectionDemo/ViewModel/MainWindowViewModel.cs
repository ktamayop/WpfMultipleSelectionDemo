using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using MultipleSelectionDemo.Model;
using WpfApplication1.Annotations;

namespace MultipleSelectionDemo.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private List<Player> players;
        private string summary;

        public MainWindowViewModel()
        {
            //Get some test data
            Players = new List<Player>
            {
                new Player {Name = "Cristiano Ronaldo", Number = 7, PictureName = "cristiano.jpg"},
                new Player {Name = "Karim Benzema", Number = 9, PictureName = "benzema.jpg"},
                new Player {Name = "Gareth Frank Bale", Number = 11, PictureName = "bale.jpg"},
                new Player {Name = "James Rodríguez", Number = 10, PictureName = "james.jpg"}
            };

            //Initialize the command
            CheckRosterCommand = new RelayCommand<ObservableCollection<object>>(FindSelectedPlayers);
        }

        public List<Player> Players
        {
            get { return players; }
            set
            {
                if (Equals(value, players)) return;
                players = value;
                OnPropertyChanged();
            }
        }

        public ICommand CheckRosterCommand { get; set; }

        public string Summary
        {
            get { return summary; }
            set
            {
                if (value == summary) return;
                summary = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void FindSelectedPlayers(ObservableCollection<object> obj)
        {
            var selectedPlayers = obj.Cast<Player>();
            var isBbsPlaying = selectedPlayers
                                    .Select(p => p.Number)
                                    .Intersect(new[] { 7, 9, 11 })
                                    .Count() == 3;

            Summary = isBbsPlaying ? "¡La BBC juega hoy!" : "El Real Madrid juega sin la BBC.";
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}