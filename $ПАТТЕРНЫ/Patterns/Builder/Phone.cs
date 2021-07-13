namespace Builder
{
    internal abstract class Phone
    {
        public Display Display { get; set; }
        public Processor Processor { get; set; }
        public Button Button { get; set; }
        public Corpus Corpus { get; set; }
    }
}
