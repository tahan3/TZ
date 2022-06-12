namespace Computer
{
    public class AppleOfficialSeller : Seller
    {
        protected override bool HandleSellOperation(IComputer computer)
        {
            //only apple computers
            if (computer.Type == Computer.AppleComputer)
            {
                //sell
                return true;
            }

            return false;
        }
    }
}