namespace Builder
{
    internal class SamsungPhoneBuilder : PhoneBuilder
    {
        private SamsungPhone _phone;
        public SamsungPhoneBuilder()
        {
            _phone = new SamsungPhone();
        }
        public override void BuildButton() => _phone.Button = new Button();
        public override void BuildCorpus() => _phone.Corpus = new Corpus();
        public override void BuildDisplay() => _phone.Display = new Display();
        public override void BuildProcessor() => _phone.Processor = new Processor();
        public override Phone GetResult() => _phone;
    }
}
