using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Order.Persistence.DTO;
using Order.WPF.Model;
using Order.WPF.View;
namespace Order.WPF.ViewModel
{
    class OrdersViewModel : ViewModelBase
    {
        
        String _filter;
        private ObservableCollection<PanaszDTO> _orders;
        public DelegateCommand CancelCommand { get; set; }
        public DelegateCommand IsAccomplishedCommand { get; set; }
        public DelegateCommand ListingCommand { get; set; }
        public DelegateCommand RefreshCommand { get; set; }
        public DelegateCommand JustAccomplishedCommand { get; set; }
        public DelegateCommand JustNotAccomplishedCommand { get; set; }

        public DelegateCommand FilterNameCommand { get; set; }
        public DelegateCommand FilterAddressCommand { get; set; }
        private readonly IOrderModel _model;

        public ObservableCollection<PanaszDTO> Orders => _orders;
        public event EventHandler Canceled;
        public OrdersViewModel(IOrderModel model)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));
            LoadData();
            RefreshCommand = new DelegateCommand(param => LoadData());
            ListingCommand = new DelegateCommand(param => ListingOrderedItems());
            CancelCommand = new DelegateCommand(param => OnCancel());


        }
          
        private async void ListingOrderedItems()
        {
            try
            {
                List<int> counts = new List<int> { };
                List<string> list = new List<string> { };
                
                _orders = new ObservableCollection<PanaszDTO>(new ObservableCollection<PanaszDTO>(await _model.LoadOrders()).OrderByDescending(x => x.time).Where(x=>x.IsOk==false));
               
                new ListingOrderedItems(_orders).Show();
            }
            catch(Exception ex)
            {

            }
        }
        public String Filter
        {
            get => _filter;
            set
            {
                if (_filter != value)
                {
                    _filter = value;
                    OnPropertyChanged();
                }
            }
        }
        private async void LoadData()
        {
            try
            {
                _orders = new ObservableCollection<PanaszDTO>(new ObservableCollection<PanaszDTO>(await _model.LoadOrders()).OrderByDescending(x => x.time).Where(x => x.IsOk == false)); ;

                OnPropertyChanged(nameof(Orders));
            }
            catch (NetworkException ex)
            {
                OnMessageApplication($"Váratlan hiba történt! ({ex.Message})");
            }
        }
        private void OnCancel()
        {
            Canceled?.Invoke(this, EventArgs.Empty);
        }
    }
}
