namespace NsPokemon.Clases;

interface IPokemon{
    void Add(PokemonDTO obj_pokemon);
    void Delete(int id);
    PokemonDTO ConsultaUno(int id);
    void Update(int id,PokemonDTO obj_pokemon);
    List<PokemonDTO> All();
    List<PokemonDTO> ConsultaPorTipo(string tipo);
}