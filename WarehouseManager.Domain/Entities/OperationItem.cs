namespace WarehouseManager.Domain.Entities;

public class OperationItem
{
    public int Id { get; set; }
    public int ComponentId { get; set; }
    public int Quantity { get; set; }
    public int StorageOperationId { get; set; }
    public virtual StorageOperation StorageOperation { get; set; }
}
