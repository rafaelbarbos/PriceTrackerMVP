public class NotificationSettings
{
    // Identificador único das configurações
    public int Id { get; set; }
    
    // Identificador do usuário
    public string UserId { get; set; }
    
    // Canal preferido de notificação
    public NotificationType PreferredChannel { get; set; }
    
    // Email ou ID do chat para envio da notificação
    public string ContactInfo { get; set; }
    
    // Flag para habilitar/desabilitar notificações
    public bool IsEnabled { get; set; }
}