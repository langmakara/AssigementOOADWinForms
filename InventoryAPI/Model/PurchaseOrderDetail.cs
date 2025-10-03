namespace InventoryAPI.Model
{
    public class PurchaseOrderDetail
    {
        public int PurchaseOrderDetailID { get; set; }  // PK
        public int PurchaseOrderID { get; set; }        // ? must be int
        public int ProductID { get; set; }              // ? must be int
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        public Product Product { get; set; }
    }
}
