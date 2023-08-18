namespace DockerAPI;

[Table("produto", Schema = "public")]
public class Produto
{
    [Key]
    public int cd_codigo { get; set; }
    public string? ds_nome { get; set; }
    public decimal? vl_preco { get; set; }
}
