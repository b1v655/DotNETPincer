using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using Order.WPF.Model;
using Order.Persistence.DTO;
namespace Order.WPF.ViewModel
{
    class AddMenuItemViewModel : ViewModelBase
    {
        private readonly IOrderModel _model;
        private PanaszDTO _newMenuItem;
        
        public DelegateCommand SendCommand { get; set; }
        public DelegateCommand CancelCommand { get; set; }
        
        public event EventHandler Success;
        public event EventHandler Canceled;

        public AddMenuItemViewModel(IOrderModel model)
        {
            _model = model;

            _newMenuItem = new PanaszDTO();
            SendCommand = new DelegateCommand(param => AddNewMenuItem());
            CancelCommand = new DelegateCommand(param => OnCancel());
            
        }

        public PanaszDTO NewMenuItem
        {
            get => _newMenuItem;
            set
            {
                _newMenuItem = value;
                OnPropertyChanged();
            }
        }


        

        private async void AddNewMenuItem()
        {
            if (!CheckModel()) { return; }
            if (await _model.SendAccomplishedOrder(NewMenuItem))
            {
                OnSuccessfulAdd();
            }
            else
            {
                OnMessageApplication("Nem sikerült hozzáadni a listához.");
            }
        }

        private void OnCancel()
        {
            Canceled?.Invoke(this, EventArgs.Empty);
        }

        private void OnSuccessfulAdd()
        {
            Success?.Invoke(this, EventArgs.Empty);
        }

        private Boolean CheckModel()
        {
            if (NewMenuItem.ManName == null)
            {
                OnMessageApplication("Nem adta meg a nevet!");
                return false;
            }
            if (NewMenuItem.ManAddress == null)
            {
                OnMessageApplication("Nem adott meg címet!");
                return false;
            }
            if (NewMenuItem.fail == null)
            {
                OnMessageApplication("Nem adott meg hibát!");
                return false;
            }
            return true;
        }
    }
}
