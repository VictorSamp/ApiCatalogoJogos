using ApiCatalogoJogos.InputModel;
using ApiCatalogoJogos.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Services
{
    public interface IJogoService : IDisposable
    {
        Task<List<JogoViewModel>> ObterTodosJogos(int pagina, int quantidade);

        Task<JogoViewModel> ObterJogoPorId(Guid id);

        Task<JogoViewModel> InserirJogo(JogoInputModel jogo);

        Task Atualizar(Guid id, JogoInputModel jogo);

        Task Atualizar(Guid id, double preco);

        Task Remover(Guid id);
    }
}