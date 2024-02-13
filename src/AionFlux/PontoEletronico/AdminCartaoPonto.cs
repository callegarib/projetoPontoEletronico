using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoEletronico;

public class AdminCartaoPonto
{
    public List<Funcionario> funcionarios = new List<Funcionario>();
    public List<CartaoPonto> cartoesPonto = new List<CartaoPonto>();
    private List<Registro> registros = new List<Registro>();
    public void CadastrarFuncionario(Funcionario funcionario)
    {
        funcionarios.Add(funcionario);
    }

    public void EditarFuncionario(int funcionarioId, Funcionario novoFuncionario)
    {
        Funcionario funcionarioExistente = funcionarios.Find(f => f.Id == funcionarioId);
        if (funcionarioExistente != null)
        {
            funcionarioExistente.Nome = novoFuncionario.Nome;
            funcionarioExistente.PerfilTrabalho = novoFuncionario.PerfilTrabalho;
        }
    }

    public void RemoverFuncionario(int funcionarioId)
    {
        Funcionario funcionario = funcionarios.Find(f => f.Id == funcionarioId);
        if (funcionario != null)
        {
            funcionarios.Remove(funcionario);
        }
    }

    public void CadastrarRegistro(Registro registro)
    {
        registros.Add(registro);
    }

    public void EditarRegistro(int registroId, Registro novoRegistro)
    {
        Registro registroExistente = registros.Find(r => r.Id == registroId);
        if (registroExistente != null)
        {
            registroExistente.TipoAcao = novoRegistro.TipoAcao;
            registroExistente.HoraEntrada = novoRegistro.HoraEntrada;
            registroExistente.HoraSaida = novoRegistro.HoraSaida;           
        }
    }

    public void RemoverRegistro(int registroId)
    {
        Registro registro = registros.Find(r => r.Id == registroId);
        if (registro != null)
        {
            registros.Remove(registro);
        }
    }

    // Métodos para cadastrar, editar, atualizar e remover cartões ponto...

    public void CadastrarCartaoPonto(CartaoPonto cartaoPonto)
    {
        cartoesPonto.Add(cartaoPonto);
    }

    public void EditarCartaoPonto(int cartaoPontoId, CartaoPonto novoCartaoPonto)
    {
        CartaoPonto cartaoPontoExistente = cartoesPonto.Find(c => c.Id == cartaoPontoId);
        if (cartaoPontoExistente != null)
        {
            cartaoPontoExistente.Funcionario = novoCartaoPonto.Funcionario;
            cartaoPontoExistente.Data = novoCartaoPonto.Data;
            cartaoPontoExistente.Registros = novoCartaoPonto.Registros;
        }
    }

    public void RemoverCartaoPonto(int cartaoPontoId)
    {
        CartaoPonto cartaoPonto = cartoesPonto.Find(c => c.Id == cartaoPontoId);
        if (cartaoPonto != null)
        {
            cartoesPonto.Remove(cartaoPonto);
        }
    }
}
