namespace Model
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Product? Product { get; set; }
        public double Quantity { get; set; }
        public double PurchasePrice { get; set; }

        public bool Validade()
        {
            bool isValid = true;

            double quantityItems = 10;

            isValid = (Id > 0) &&
                      (Quantity > 0) &&
                      (PurchasePrice > 0) &&
                      Product != null;

            return isValid;
        }
    }
}
