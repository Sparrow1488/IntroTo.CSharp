namespace Builder
{
    internal abstract class PhoneBuilder
    {
        public abstract void BuildCorpus();
        public abstract void BuildDisplay();
        public abstract void BuildProcessor();
        public abstract void BuildButton();
        public abstract Phone GetResult();
    }
}
