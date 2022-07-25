using System.Collections.Generic;

namespace SecuredServices.Core.Providers
{
    public interface IPolicyProvider
    {
        IEnumerable<string> Policies { get; }
        int GetPolicyRank(string policy);
    }
}
