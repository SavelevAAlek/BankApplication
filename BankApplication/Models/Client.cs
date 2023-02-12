using BankApplication.ViewModels.Base;

namespace BankApplication.Models
{
    public class Client : ViewModelBase
    {
        private string? _name;
        private string? _surname;
        private string? _patronymic;
        private string? _phoneNumber;
        private string? _passportData;

        public string? Name { get => _name; set => SetProperty(ref _name, value); }
        public string? Surname { get => _surname; set => SetProperty(ref _surname, value); }
        public string? Patronymic { get => _patronymic; set => SetProperty(ref _patronymic, value); }
        public string? PhoneNumber { get => _phoneNumber; set => SetProperty(ref _phoneNumber, value); }
        public string? PassportData { get => _passportData; set => SetProperty(ref _passportData, value); }

        public Client() { }
        public Client(string? name, string? surname, string? patronymic, string? phoneNumber, string? passportData)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
            PassportData = passportData;
        }   
    }
}
