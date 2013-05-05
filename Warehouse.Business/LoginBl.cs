namespace Warehouse.Business
{
    using Warehouse.Data.Contract;
    using Warehouse.Data.Model;
    using System.Linq;

    public class LoginBl
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
                _common.LoggedInUser = _user;
            }

            return _user != null;
        }
    }
}
