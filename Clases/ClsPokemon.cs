namespace NsPokemon.Clases;

class ClsPokemon:IPokemon{

    private  List<PokemonDTO> DB = new List<PokemonDTO>();

    public ClsPokemon(){
        this.DB = new List<PokemonDTO>();
    }

    public void Add(PokemonDTO obj_pokemon){
        this.DB.Add(obj_pokemon);
    }

    public void AddMultiples(List<PokemonDTO> obj_pokemon){
        foreach(var item in obj_pokemon){
            this.DB.Add(item);
        }
    }

    public void Update(int id, PokemonDTO obj_pokemon ){
        PokemonDTO pokeUpdate = this.DB.Single(obj_pokemon => obj_pokemon.Id == id);
         pokeUpdate.Nombre = obj_pokemon.Nombre;
         pokeUpdate.Tipo = obj_pokemon.Tipo;
         pokeUpdate.Habilidad = obj_pokemon.Habilidad;
         pokeUpdate.Defensa = obj_pokemon.Defensa;
    }
        
    
    public PokemonDTO ConsultaUno(int id){
        ClsPokemon obj_pokemon = new ClsPokemon();
        return this.DB.Single(obj_pokemon=>obj_pokemon.Id == id);
    }
    public List<PokemonDTO> ConsultaPorTipo(string tipo){
        List<PokemonDTO> Lista = new List<PokemonDTO>();
         foreach(PokemonDTO item in this.DB){
            if(item.Tipo.IndexOf(tipo)  != -1){
                Lista.Add(item);
            }
         }
        return Lista;
        
    }

    public  List<PokemonDTO> All(){
        return this.DB;
    }

    public void Delete(int id){
        ClsPokemon obj_pokemon = new ClsPokemon();
        this.DB.RemoveAll(obj_pokemon => obj_pokemon.Id == id);
    }
    
}