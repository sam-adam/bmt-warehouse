using System;

namespace Warehouse.Application
{
    using Warehouse.Application.Contract;
    using Warehouse.Application.Properties;

    public class ApplicationManager
    {
        private readonly IApplicationConnection _applicationConnection;
        private readonly EntityManager _entityManager;

        public ApplicationManager(IApplicationConnection applicationConnection, EntityManager entityManager)
        {
            _applicationConnection = applicationConnection;
            _entityManager = entityManager;
        }

        public IApplicationConnection ApplicationConnection
        {
            get { return _applicationConnection; }
        }

        public void SetConnectionProperties(string server, string database, string userId, string password)
        {
            _applicationConnection.Server = server;
            _applicationConnection.Database = database;
            _applicationConnection.UserId = userId;
            _applicationConnection.Password = password;

            SaveConnectionSetting();
        }

        private void SaveConnectionSetting()
        {
            var validationResults = _entityManager.Validate(_applicationConnection);

            foreach (var validationResult in validationResults)
            {
                throw new ApplicationException(validationResult);
            }

            Settings.Default.Save();
        }
    }
}
