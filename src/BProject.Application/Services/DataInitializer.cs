using System;
using System.Collections.Generic;
using System.Linq;
using BProject.Application.Services.Base;
using BProject.Core.Models;
using BProject.Core.Repositories;
using BProject.Infrastructure.EntityFramework;

namespace BProject.Application.Services
{
    public class DataInitializer : IDataInitializer
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DataInitializer(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public void InitializeData()
        {
            try
            {
                // todo dodać obiekty w liscie które trzeba dodać do bazy
                var transaction = _unitOfWork.BeginTransaction();

                bool isUsersInDatabase = _userRepository.GetAll().Any();

                if (!isUsersInDatabase)
                {
                    var users = GetDefaultUsers().ToList();
                    users.ForEach(user => _userRepository.Add(user));

                    // todo do usniecia jak wybierzesz, który Ci bardziej pasi
                    foreach (var user in users)
                    {
                        _userRepository.Add(user);
                    }
                }

                _unitOfWork.CommitTransaction(transaction);
            }
            catch (Exception exception)
            {
                // todo dodać data initializer exception i wyrzucić
            }
        }

        private static IEnumerable<User> GetDefaultUsers()
        {
            var users = new List<User>()
            {
                new User() {},
                new User() {},
                new User() {}
            };

            return users;
        }
    }
}
