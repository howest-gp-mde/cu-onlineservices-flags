using CommunityToolkit.Mvvm.ComponentModel;
using Mde.OnlineServices.Flags.Models;
using Mde.OnlineServices.Flags.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Mde.OnlineServices.Flags.ViewModels
{
    public class MainViewModel : ObservableObject
    {
		private ObservableCollection<Flag> flags;
        private readonly IFlagService flagService;

        public ObservableCollection<Flag> Flags
        {
			get { return flags; }
			set { SetProperty(ref flags, value); }
		}

        public ICommand LoadFlags => new Command(async () => await Load());

        public MainViewModel(IFlagService flagService)
        {
            this.flagService = flagService;
        }

        private async Task Load()
        {
            var flags = await flagService.GetFlags();
            Flags = new ObservableCollection<Flag>(flags);
        }

    }
}
