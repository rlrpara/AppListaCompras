namespace AppListaCompras.Service.EntitiesService;

public class ListToBuyModel
{
    public int Codigo { get; set; }
    public string? Nome { get; set; }
    public List<UsuarioModel>? Usuarios { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
}
