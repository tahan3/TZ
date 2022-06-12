namespace Computer
{
    public interface ISeller
    {
        public bool TrySell(IComputer computer);
        public bool SetNext(ISeller nextSeller);
    }
}