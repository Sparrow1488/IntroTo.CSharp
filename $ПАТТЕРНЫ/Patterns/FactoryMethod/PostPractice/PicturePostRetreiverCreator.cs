using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class PicturePostRetreiverCreator : PostRetreiverCreator
    {
        public override PostRetreiver Create(Post post)
        {
            return new PicturePostRetreiver(post);
        }
    }
}
