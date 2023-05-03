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
    /*public List<PokemonDTO> ConsultaUno(int id){
        ClsPokemon obj_pokemon = new ClsPokemon();
        return Results.Ok(this.DB.Single(obj_pokemon=>obj_pokemon.Id == id));
    }*/

    public  List<PokemonDTO> All(){
        return this.DB;
    }

    public void Delete(int id){
        ClsPokemon obj_pokemon = new ClsPokemon();
        this.DB.RemoveAll(obj_pokemon => obj_pokemon.Id == id);
    }
    
}