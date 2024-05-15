
namespace Pure_Harmony_App.Views.Template
{
    internal class RelayCommand
    {
        private Action<object> login;

        public RelayCommand(Action<object> login)
        {
            this.login = login;
        }
    }
}