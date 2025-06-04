namespace Context;

public class Product
{
    public int Id { get; set; }
    
    [System.ComponentModel.DataAnnotations.MaxLength(200)]
    public required string Description { get; set; } = string.Empty;
    
    [System.ComponentModel.DataAnnotations.MaxLength(26)]
    public required string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }
    public bool Available { get; set; }
}