namespace Computer
{
    public abstract class Seller : ISeller
    {
        private ISeller next;

        public bool SetNext(ISeller nextSeller)
        {
            if (nextSeller != null && nextSeller != next && nextSeller != this)
            {
                next = nextSeller;
                return true;
            }

            return false;
        }

        public bool TrySell(IComputer computer)
        {
            if (HandleSellOperation(computer))
            {
                return true;
            }

            return next?.TrySell(computer) ?? false;
        }

        protected abstract bool HandleSellOperation(IComputer computer);
    }
}