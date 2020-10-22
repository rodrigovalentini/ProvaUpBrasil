using AutoMapper;
using Prova.Business.Models;
using Prova.WebUI.ViewModels;


namespace Prova.WebUI.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Bairro, BairroViewModel>().ReverseMap();
            CreateMap<Cidade, CidadeViewModel>().ReverseMap();
            CreateMap<Cliente, ClienteViewModel>().ReverseMap();
            CreateMap<EnderecoCliente, EnderecoClienteViewModel>().ReverseMap();
            CreateMap<GrupoItem, GrupoItemViewModel>().ReverseMap();
            CreateMap<Item, ItemViewModel>().ReverseMap();
            CreateMap<StatusVenda, StatusVendaViewModel>().ReverseMap();
            CreateMap<TelefoneCliente, TelefoneClienteViewModel>().ReverseMap();
            CreateMap<TipoEndereco, TipoEnderecoViewModel>().ReverseMap();
            CreateMap<TipoItem, TipoItemViewModel>().ReverseMap();
            CreateMap<TipoTelefone, TipoTelefoneViewModel>().ReverseMap();
            CreateMap<TipoVenda, TipoVendaViewModel>().ReverseMap();
            CreateMap<Uf, UfViewModel>().ReverseMap();
            CreateMap<Venda, VendaViewModel>().ReverseMap();
            CreateMap<VendaItem, VendaItemViewModel>().ReverseMap();
            CreateMap<Vendedor, VendedorViewModel>().ReverseMap();
        }
    }
}
