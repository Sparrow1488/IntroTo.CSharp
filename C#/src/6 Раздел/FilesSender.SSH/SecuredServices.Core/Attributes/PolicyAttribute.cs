using System;

namespace SecuredServices.Core.Attributes
{
    public class PolicyAttribute : Attribute
    {
        public PolicyAttribute(int rank)
        {
            Rank = rank;
        }

        public int Rank { get; }
    }
}
