using System;
using System.Windows.Controls;
using Order.WPF.Model;


namespace Order.WPF.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        private readonly IOrderModel _model;

        public DelegateCommand ExitCommand { get; set; }
        public DelegateCommand LoginCommand { get; set; }

        public string UserName { get; set; }

        public event EventHandler ExitApplication;
        public event EventHandler LoginSuccess;
        public event EventHandler LoginFailed;

        public LoginViewModel(IOrderModel model)
        {
            this._model = model ?? throw new ArgumentNullException(nameof(model));
            UserName = String.Empty;

            ExitCommand = new DelegateCommand(param => OnExitApplication());
            LoginCommand = new DelegateCommand(param => LoginAsync(param as PasswordBox));
        }

        private async void LoginAsync(PasswordBox passwordBox)
        {
            if (passwordBox == null)
                return;

            try
            {
                bool result = await _model.LoginAsync(UserName, passwordBox.Password);

                if (result)
                    OnLoginSuccess();
                else
                    OnLoginFailed();
            }
            catch (NetworkException ex)
            {
                OnMessageApplication($"Váratlan hiba történt! ({ex.Message})");
            }
        }

        private void OnLoginSuccess()
        {
            LoginSuccess?.Invoke(this, EventArgs.Empty);
        }

        private void OnExitApplication()
        {
            ExitApplication?.Invoke(this, EventArgs.Empty);
        }

        private void OnLoginFailed()
        {
            LoginFailed?.Invoke(this, EventArgs.Empty);
        }

    }
}

