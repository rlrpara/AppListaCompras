namespace AppListaCompras.Domain.Entities;

public class ListToBuy
{
    public int Codigo { get; set; }
    public string? Nome { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
}
