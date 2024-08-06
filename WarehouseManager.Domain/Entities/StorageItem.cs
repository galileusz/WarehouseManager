namespace WarehouseManager.Domain.Entities;

public class StorageItem
{
    public int Id { get; set; }
    public int StorageComponentId { get; set; }
    public virtual StorageComponent StorageComponent { get; set; }
    public int WarehouseId { get; set; }
    public virtual Warehouse Warehouse { get; set; }
    public int Quantity { get; set; }
}
