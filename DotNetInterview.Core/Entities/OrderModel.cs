namespace DotNetInterview.Core.Entities;

public record OrderModel
{
    public int Id { get; set; }
    public ClientModel Client { get; set; }
    public string OrderNumber { get; set; }
    public DateTime CreatedDate { get; set; }
    public decimal GrandTotal { get; set; }
    public decimal AmountPaid { get; set; }
}