using SecuredServices.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SecuredServices.Core.Providers
{
    public class PolicyProvider : IPolicyProvider
    {
        public PolicyProvider(Type entityWithPolicies)
        {
            _entityWithPolicies = entityWithPolicies;
            _policiesWithRanks = GetPolicies();
        }

        private readonly IDictionary<string, int> _policiesWithRanks;
        private readonly IList<string> _policiesList = new List<string>();
        private readonly Type _entityWithPolicies;

        public IEnumerable<string> Policies => _policiesList;

        public virtual int GetPolicyRank(string policy)
        {
            _policiesWithRanks.TryGetValue(policy, out int policyRank);
            return policyRank;
        }

        private IDictionary<string, int> GetPolicies()
        {
            var dictionary = new Dictionary<string, int>();
            var policiesProps = GetPolicyProperties();
            foreach (var prop in policiesProps)
            {
                var attribute = prop.GetCustomAttribute<PolicyAttribute>();
                dictionary.Add(prop.Name, attribute.Rank);
            }
            return dictionary;
        }

        private IEnumerable<FieldInfo> GetPolicyProperties()
        {
            return _entityWithPolicies.GetFields()
                .Where(x => x.GetCustomAttribute<PolicyAttribute>() is not null);
        }
    }
}
