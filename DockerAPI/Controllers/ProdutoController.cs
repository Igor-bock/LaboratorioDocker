namespace DockerAPI;

[ApiController]
[Route("api/[controller]")]
public class ProdutoController : Controller
{
    public TesteDbContext? C_Context { get; set; }

    public ProdutoController(TesteDbContext p_Context)
    {
        C_Context = p_Context;
    }

    ~ProdutoController()
    {
        if (C_Context != null)
            C_Context.Dispose();
    }

    [HttpGet("produtos")]
    public string GetProdutos()
    {
        try
        {
            if (C_Context == null)
                return $"{nameof(C_Context)} não está instanciado!";

            var m_Produtos = C_Context.Produtos;

            if (m_Produtos.Any() == false)
                return "Nenhum resultado encontrado!";

            return System.Text.Json.JsonSerializer.Serialize(m_Produtos);
        }
        catch (Exception ex)
        {
            return $"Um erro aconteceu: {ex!.Message!} \nStackTrace: {ex!.StackTrace!} \nInnerException: {ex!.InnerException!.Message!}";
        }
    }
}
