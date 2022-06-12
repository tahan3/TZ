namespace Computer
{
    public class ComputerSeller : Seller
    {
        protected override bool HandleSellOperation(IComputer computer)
        {
            //sell any computer
            return true;
        }
    }
}