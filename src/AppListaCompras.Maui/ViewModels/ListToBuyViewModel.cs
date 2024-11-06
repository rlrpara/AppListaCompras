using AppListaCompras.Service.EntitiesService;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace AppListaCompras.Maui.ViewModels;

public partial class ListToBuyViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<ListToBuyModel> _listToBuy;
    
    public ListToBuyViewModel()
    {
        ListToBuy =
        [
            new ListToBuyModel()
            {
                Nome = "Minha Lista",
                Usuarios =
                [
                    new UsuarioModel() { Nome = "Rodrigo Ribeiro", Email = "rlr.para@gmail.com" },
                    new UsuarioModel() { Nome = "Rosenira Malato", Email = "roseniramalato@gmail.com" },
                ],
                Produtos =
                [
                    new ProdutoModel() { },
                    new ProdutoModel() { },
                    new ProdutoModel() { },
                ]
            },
            new ListToBuyModel()
            {
                Nome = "Minha Lista 2",
                Usuarios =
                [
                    new UsuarioModel() { Nome = "Rosenira Malato", Email = "roseniramalato@gmail.com" },
                ],
                Produtos =
                [
                    new ProdutoModel() { },
                    new ProdutoModel() { },
                    new ProdutoModel() { },
                ]
            },
        ];
    }
}
