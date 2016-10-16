using Material.Dominio.Cadastros.Repositorios;
using Material.Dominio.Cadastros.Servicos;
using Material.Infra.Persistencia;
using Material.Infra.Repositorios.Cadastros;
using Material.Servico.Services.Cadastros;
using Microsoft.Practices.Unity;

namespace Material.IoC
{
    public class DependencyRegister
    {
        public static void Register(UnityContainer container)
        {
            container.RegisterType<MaterialContext, MaterialContext>();
            container.RegisterType<IProdutoRepositorio, ProdutoRepositorio>();
            container.RegisterType<IProdutoServico, ProdutoServico>();

        }
    }
}
