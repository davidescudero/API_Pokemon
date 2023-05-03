namespace NsPokemon.Clases;
class PokemonDTO{
    public int Id{set; get;}
    public string Nombre{set; get;}
    public string Tipo{set; get;}
    //public List<HabilidadDTO> Habilidades { get; set; }
    public int Habilidad { get; set; }
    public decimal Defensa { get; set; }
}

public class HabilidadDTO
{
    public string NombreHabilidad { get; set; }
    public List<string>valorHabilidad{set; get;}
}