//using PrettyHair.Lib.Interfaces;

namespace PrettyHair.Lib.Interfaces
{
    public interface IOrderLine
    {
        IProduct GetProduct { get; }

        decimal GetSubtotal();
    }
}