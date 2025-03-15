namespace Musakai.Shared.DTOs.Requests.EmailService;

public sealed class ContactEmailRequest
{
    public string Receiver { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public string Sender { get; set; } = string.Empty;
}
