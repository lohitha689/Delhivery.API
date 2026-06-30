namespace Delhivery.Data.Exceptions
{
    public class ShipmentNotFoundException : Exception
    {
        public ShipmentNotFoundException(string message) : base(message)
        {
        }
    }
}