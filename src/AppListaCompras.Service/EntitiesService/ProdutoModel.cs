namespace AppListaCompras.Service.EntitiesService;

public class ProdutoModel
{
    public int Codigo { get; set; }
    public string? Nome { get; set; }
    public int Quantidade { get; set; }
    public string? UnidadeMedida { get; set; }
    public decimal Preco { get; set; }
}
