namespace RockScissorsPaper
{
    public class ThrowDownTestBase
    {
        protected ThrowDownResult ThrowDownBetween(IThrow throwOne, IThrow throwTwo)
        {
            return new ThrowDown(throwOne, throwTwo).Commence();
        }
    }
}