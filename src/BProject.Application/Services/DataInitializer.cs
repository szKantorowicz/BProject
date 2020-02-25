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
        private readonly IRoleRepository _roleRepository;
        private readonly IProductRepository _productRepository;
        private readonly IPaymentTypeRepsitory _paymentTypeRepsitory;
        private readonly IStatusRepository _statusRepository;
        private readonly ICategoryRepository _categoryRepository;
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

                    foreach (var user in users)
                    {
                        _userRepository.Add(user);
                    }
                }

                bool isRolesInDatabase = _roleRepository.GetAll().Any();

                if (!isRoleInDatabase)
                {
                    var roles = GetDefaultRoles().ToList();

                    foreach (var role in roles)
                    {
                        _userRepository.Add(role);
                    }
                }

                bool isProductsInDatabase = _productRepository.GetAll().Any();

                if (!isProductInDatabase)
                {
                    var products = GetDefaultProducts().ToList();

                    foreach (var product in products)
                    {
                        _productRepository.Add(product);
                    }
                }

                bool isPaymentTypesInDatabase = _paymentTypeRepository.GetAll().Any();

                if (!isPaymentTypesInDatabase)
                {
                    var paymentTypes = GetDefaultPaymentTypes().ToList();

                    foreach (var paymentType in paymentTypes)
                    {
                        _paymentTypeRepository.Add(paymentType);
                    }
                }

                bool isStatusesInDatabase = _statusRepository.GetAll().Any();

                if (!isStatusesInDatabase)
                {
                    var statuses = GetDefaultStatuses().ToList();

                    foreach (var status in statuses)
                    {
                        _statusRepository.Add(status);
                    }
                }

                bool isCategoriesInDatabase = _statusRepository.GetAll().Any();

                if (!isCategoriesInDatabase)
                {
                    var categories = GetDefaultCategory().ToList();

                    foreach (var category in categories)
                    {
                        _categoryRepository.Add(category);
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

        private static IEnumerable<Role> GetDefaultRoles()
        {
            var roles = new List<Role>()
            {
                new Role() {},
                new Role() {},
                new Role() {}
            };

            return roles;
        }

        private static IEnumerable<Product> GetDefaultProducts()
        {
            var products = new List<Product>()
            {
                new Product() { },
                new Product() { },
                new Product() { },
                new Product() { },
                new Product() { },
                new Product() { },
                new Product() { },
            };

            return products;

        }

        private static IEnumerable<PaymentType> GetDefaultPaymentTypes()
        {
            var paymentTypes = new List<PaymentType>()
            {
                new PaymentType() { },
                new PaymentType() { },
                new PaymentType() { },
            };

            return paymentTypes;
        }

        private static IEnumerable<Status> GetDefaultStatuses()
        {
            var statuses = new List<Status>()
            {
                new Status() { },
                new Status() { },
                new Status() { },
            };

            return statuses;
        }

        private static IEnumerable<Category> GetDefaultCategory()
        {
            var categories = new List<Category>()
            {
                new Category() { },
                new Category() { },
                new Category() { },
            };

            return categories;
        }
    }
}
