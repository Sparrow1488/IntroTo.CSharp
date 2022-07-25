using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using SecuredServices.Core.Protectors;
using SecuredServices.Core.Providers;
using SecuredServices.Core.Tests.TestEntities;
using SecuredServices.Core.Tests.TestPolicy.Roles;

namespace SecuredServices.Core.Tests
{
    public class EntityPretectorTests
    {
        private IServiceCollection _services;
        private IServiceScope _scope => _services.BuildServiceProvider().CreateScope();

        [SetUp]
        public void Setup()
        {
            _services = new ServiceCollection();
            _services.AddTransient<IEntityProtector<Group>, EntityProtector<Group>>();
            _services.AddTransient<IPolicyProvider, PolicyProvider>(x => new PolicyProvider(typeof(TestRole)));
        }

        [Test]
        public void IsProtected_EditedGroupByUser_False()
        {
            var initial = new Group() { Title = "Hello group!" };
            var edited = new Group() { Title = "Edited group title" };
            RegisterManagerContext(isAuth: true, role: TestRole.User);
            var protector = _scope.ServiceProvider.GetService<IEntityProtector<Group>>();

            var isProtected = protector.IsProtected(edited, initial);

            Assert.False(isProtected);
        }

        [Test]
        public void IsProtected_EditedGroupByEditor_True()
        {
            var initial = new Group() { Title = "Hello group!" };
            var edited = new Group() { Title = "Edited group title" };
            RegisterManagerContext(isAuth: true, role: TestRole.Editor);
            var protector = _scope.ServiceProvider.GetService<IEntityProtector<Group>>();

            var isProtected = protector.IsProtected(edited, initial);

            Assert.True(isProtected);
        }

        [Test]
        public void IsProtected_ReadGroupPropsByNotConfigrmed_False()
        {
            var initial = new Group() { Title = "Public title", Description = "Hi, User!", IsPrivate = true };
            RegisterManagerContext(isAuth: true, role: TestRole.NotConfirmed);
            var protector = _scope.ServiceProvider.GetService<IEntityProtector<Group>>();

            var isProtected = protector.IsProtected(initial);
        }

        private void RegisterManagerContext(bool isAuth = false, string role = TestRole.User)
        {
            _services.AddTransient(x => new ManagerContext()
            {
                IsAuthorized = isAuth,
                Role = role
            });
        }
    }
}