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
        private readonly IPaymentTypeRepository _paymentTypeRepository;
        private readonly IStatusRepository _statusRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DataInitializer(IUserRepository userRepository,
            IRoleRepository roleRepository,
            IProductRepository productRepository,
            IPaymentTypeRepository paymentTypeRepository,
            IStatusRepository statusRepository,
            ICategoryRepository categoryRepository,
            IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _productRepository = productRepository;
            _paymentTypeRepository = paymentTypeRepository;
            _statusRepository = statusRepository;
            _categoryRepository = categoryRepository;

            _unitOfWork = unitOfWork;
        }

        public void InitializeData()
        {
            try
            {
                var transaction = _unitOfWork.BeginTransaction();
                var isRolesInDatabase = _roleRepository.GetAll().Any();

                if (!isRolesInDatabase)
                {
                    var roles = GetDefaultRoles().ToList();

                    foreach (var role in roles)
                    {
                        _roleRepository.Add(role);
                    }
                }

                bool isUsersInDatabase = _userRepository.GetAll().Any();

                if (!isUsersInDatabase)
                {
                    var users = GetDefaultUsers().ToList();

                    foreach (var user in users)
                    {
                        _userRepository.Add(user);
                    }
                }

                bool isProductsInDatabase = _productRepository.GetAll().Any();

                if (!isProductsInDatabase)
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
            var admin = GetDefaultRoles().FirstOrDefault(x => x.Name == "Admin");
            var editor = GetDefaultRoles().FirstOrDefault(x => x.Name == "Editor");
            var member = GetDefaultRoles().FirstOrDefault(x => x.Name == "Member");

            var users = new List<User>()
            {
                new User() {Name = "Simon", Email = "simon@email.com", Password = "Haslo123", Roles = { admin, member}},
                new User() {},
                new User() {}
            };

            return users;
        }

        private static IEnumerable<Role> GetDefaultRoles()
        {
            var roles = new List<Role>()
            {
                new Role() {Name = "Admin", CreatedDate = DateTime.Now},
                new Role() {Name = "Editor", CreatedDate = DateTime.Now},
                new Role() {Name = "Member", CreatedDate = DateTime.Now}
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
