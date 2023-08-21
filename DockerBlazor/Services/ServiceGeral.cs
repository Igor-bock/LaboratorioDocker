using DockerBlazor.Models;
using System.Text;

namespace DockerBlazor.Services;

public class ServiceGeral : ServiceAbstract
{
    public ServiceGeral(HttpClient p_HttpClient) : base(p_HttpClient) { }

    public override async Task<Jogo> CM_Inserir(Jogo p_Jogo)
    {
        try
        {
            var m_JogoSerialize = System.Text.Json.JsonSerializer.Serialize(p_Jogo);
            var m_StringContent = new StringContent(m_JogoSerialize, Encoding.UTF8, "application/json");
            var m_Resultado = await C_HttpClient!.PostAsync("jogo", m_StringContent);
            m_Resultado!.EnsureSuccessStatusCode();

            return p_Jogo;
        }
        catch (Exception ex)
        {
            return new Jogo { ds_nome = $"Um erro aconteceu: {ex.Message}" };
        }
    }
}
