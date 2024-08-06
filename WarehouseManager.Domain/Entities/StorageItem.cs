namespace WarehouseManager.Domain.Entities;

public class StorageItem
{
    public int Id { get; set; }
    public int ComponentId { get; set; }
    public virtual Component Component { get; set; }
    public int WarehouseId { get; set; }
    public virtual Warehouse Warehouse { get; set; }
    public int Quantity { get; set; }
}
