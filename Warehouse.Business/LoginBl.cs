namespace Warehouse.Business
{
    using Warehouse.Business.Contract;
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;
    using System.Linq;

    public class LoginBl : ILoginBl
    {
        private User _user;
        private readonly Common _common;
        private readonly IUserRepository _userRepository;

        public LoginBl(IUserRepository userRepository, Common common)
        {
            _common = common;
            _userRepository = userRepository;
        }

        public bool DoLogin(User user)
        {
            user.EncryptPassword();

            var userList = _userRepository.GetAll()
                        .Where(u => u.Username == user.Username)
                        .Where(u => u.Password == user.Password)
                        .ToList();

            if (userList.Any())
            {
                _user = userList.First();

                SetLoggedInUser(_user);
            }

            return _user != null;
        }

        public void SetLoggedInUser(User user)
        {
            _common.LoggedInUser = _user;
        }
    }
}
