using SecuredServices.Core.Attributes;
using SecuredServices.Core.Providers;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SecuredServices.Core.Protectors
{
    public class EntityProtector<TEntity> : IEntityProtector<TEntity>
    {
        public EntityProtector(
            ManagerContext context,
            IPolicyProvider policies)
        {
            Context = context;
            _policies = policies;
        }

        private TEntity _currentEntityCheck;
        private TEntity _initialEntityCheck;
        private readonly IPolicyProvider _policies;

        public ManagerContext Context { get; }

        public bool IsProtected(TEntity toProtect, TEntity initial)
        {
            _currentEntityCheck = toProtect;
            _initialEntityCheck = initial;
            bool isProtected = true;
            var protectedProps = GetProtectedProperties(toProtect);
            foreach (var prop in protectedProps)
            {
                var initProperty = initial.GetType().GetProperty(prop.Name);
                var isChangeVerify = IsChangeVerified(prop, initProperty);

                isProtected = isChangeVerify;
                if (!isProtected)
                    break;
            }
            return isProtected;
        }

        private IEnumerable<PropertyInfo> GetProtectedProperties(TEntity entity)
        {
            return entity.GetType().GetProperties()
                    .Where(p => p.GetCustomAttributes<ProtectionAttribute>().Any());
        }

        private bool IsChangeVerified(
            PropertyInfo property, PropertyInfo initProperty)
        {
            var isVerified = true;
            var changeAttr = property.GetCustomAttribute<ChangeProtectionAttribute>();
            if(changeAttr is not null)
            {
                var propValue = property.GetValue(_currentEntityCheck);
                var initPropValue = initProperty.GetValue(_initialEntityCheck);
                isVerified = propValue == initPropValue;
                if (!isVerified)
                {
                    isVerified = IsManagerPolicyGreaterOrEqual(changeAttr.Policy);
                }
            }
            return isVerified;
        }

        private bool IsManagerPolicyGreaterOrEqual(string policy)
        {
            var isGreaterOrEqual = false;
            var managerPolicyRank = _policies.GetPolicyRank(Context.Role);
            var currentPolicyRank = _policies.GetPolicyRank(policy);
            if (managerPolicyRank >= currentPolicyRank)
                isGreaterOrEqual = true;
            return isGreaterOrEqual;
        }
    }
}
