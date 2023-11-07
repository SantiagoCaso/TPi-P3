namespace TPi_P3.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public float TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public bool OrderState { get; set; }
    }
}
