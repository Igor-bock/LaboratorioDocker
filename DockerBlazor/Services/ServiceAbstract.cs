using DockerBlazor.Models;

namespace DockerBlazor.Services;

public abstract class ServiceAbstract
{
    public string C_Url { get => "http://localhost:8000/api"; }
    public HttpClient? C_HttpClient { get; set; }

    public ServiceAbstract(HttpClient p_HttpClient)
    {
        C_HttpClient = p_HttpClient;
        C_HttpClient.BaseAddress = new Uri(C_Url);
    }

    public abstract Task<Jogo> CM_Inserir(Jogo p_Jogo);
}
