namespace Warehouse.Business
{
    using Data.Contract;
    using Data.Model;
    using NHibernate;
    using Warehouse.Data.Repository;
    using System.Collections.Generic;
    using System.Linq;

    public class UserBl
    {
        private readonly IUserRepository _userRepository;

        public UserBl(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> Get(User user)
        {
            IEnumerable<User> userList = from users in _userRepository.GetAll()
                   where users.Username == user.Username && users.Password == user.Password
                   select users;

            return !userList.Any() ? null : userList;
        }
    }
}
