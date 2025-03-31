namespace PriceTracker.Domain.Entities;{
    public class Product
{
    // Identificador único do produto
    public int Id { get; set; }
    
    // Nome do produto para identificação
    public string Name { get; set; }
    
    // URL da página do produto para realizar o scraping
    public string Url { get; set; }
    
    // Preço atual do produto
    public decimal CurrentPrice { get; set; }
    
    // Preço alvo que o usuário deseja ser notificado
    public decimal TargetPrice { get; set; }
    
    // Menor preço já registrado para comparação
    public decimal LowestRecordedPrice { get; set; }
    
    // Loja de origem do produto
    public string StoreSource { get; set; }
    
    // Status atual do produto (em promoção, ativo, etc)
    public ProductStatus Status { get; set; }
    
    // Timestamp da última verificação de preço
    public DateTime LastCheckedAt { get; set; }
    
    // Histórico de preços do produto
    public List<PriceHistory> PriceHistory { get; set; }
}
}
