namespace AppListaCompras.Domain.Entities;

public class Usuario
{
    public int Codigo { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public string? CodigoAcessoTemp { get; set; }
    public DateTimeOffset DataCodigoAcessoTemp { get; set; }
}
