namespace NsPokemon.Clases;
class PokemonDTO{
    public int Id{set; get;}
    public string Nombre{set; get;}
    public string Tipo{set; get;}
    public List<int> Habilidad { get; set; }
    //public int Habilidad { get; set; }
    public decimal Defensa { get; set; }
}

public class HabilidadDTO
{
    public string NombreHabilidad { get; set; }
    public int valorHabilidad{set; get;}
}