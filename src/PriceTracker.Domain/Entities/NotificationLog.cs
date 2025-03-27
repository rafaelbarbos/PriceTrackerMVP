public class NotificationLog
{
    // Identificador único do log
    public int Id { get; set; }
    
    // Produto relacionado à notificação
    public int ProductId { get; set; }
    public Product Product { get; set; }
    
    // Canal usado para enviar a notificação
    public NotificationType Channel { get; set; }
    
    // Conteúdo da mensagem enviada
    public string Message { get; set; }
    
    // Momento do envio
    public DateTime SentAt { get; set; }
    
    // Indica se a notificação foi enviada com sucesso
    public bool WasSuccessful { get; set; }
}