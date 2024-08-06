namespace WarehouseManager.Domain.Entities;

public class Operation
{
    public int Id { get; set; }
    public EOperationType OperationType { get; set; }
    public EOperationState OperationState { get; set; }
    public int WarehouseId { get; set; }
    public DateTime EditionTime { get; set; }
    public DateTime? AcceptanceTime { get; set; }
    public int CreationUserId { get; set; }
    public int? AcceptingUserId { get; set; }
    public List<OperationItem> OperationItems { get; set; }
}
