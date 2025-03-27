public class PriceHistory
{
    // Identificador único do registro de histórico
    public int Id { get; set; }
    
    // Referência ao produto
    public int ProductId { get; set; }
    public Product Product { get; set; }
    
    // Preço registrado neste momento
    public decimal Price { get; set; }
    
    // Momento em que o preço foi verificado
    public DateTime CheckedAt { get; set; }
}