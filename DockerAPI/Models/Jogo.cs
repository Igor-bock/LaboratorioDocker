using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerAPI.Models;

[Table("jogos", Schema = "public")]
public class Jogo
{
    [Key]
    public int cd_codigo { get; set; }
    public string? ds_nome { get; set; }
}
