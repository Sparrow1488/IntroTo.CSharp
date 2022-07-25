using System;

namespace SecuredServices.Core.Protectors.Processors
{
    public abstract class ProtectProcessor<TEntity>
    {
        public ProtectProcessor(ProcessorContext<TEntity> context)
        {
            Context = context;
        }

        public abstract Type HandleAttributeType { get; }
        public ProcessorContext<TEntity> Context { get; }

        public void HandleEntity()
        {

        }
    }
}
