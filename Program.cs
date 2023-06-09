using NsPokemon.Clases;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


ClsPokemon obj_pokemon = new ClsPokemon();

//Para crear 1 pokémon
app.MapPost("/api/v1/pokemones", (PokemonDTO obj_dto) => {
    obj_pokemon.Add(obj_dto);
});

//Para crear multiples  pokémon
app.MapPost("/api/v1/pokemones/multiples", (List<PokemonDTO> obj_dto) => {
    obj_pokemon.AddMultiples(obj_dto);
});

//traer todos los pokemosnes almacenados
app.MapGet("/api/v1/pokemones", () => {
    return Results.Ok(obj_pokemon.All());
});

//Para eliminar 1 pokémon
app.MapDelete("/api/v1/pokemones/{id}", (int id) => {
    obj_pokemon.Delete(id);
});

//Para traer  1 pokémon
app.MapGet("/api/v1/pokemones/{id}", (int id) => {
    return Results.Ok(obj_pokemon.ConsultaUno(id));
});

//Para traer  todos los pokemones de un tipo
app.MapGet("/api/v1/pokemones/tipo/{tipo}", (string tipo) => {
    return Results.Ok(obj_pokemon.ConsultaPorTipo(tipo));
});

//Para editar 1 pokémon
app.MapPut("/api/v1/pokemones/{id}", (int id, PokemonDTO obj_dto) => {
    obj_pokemon.Update(id, obj_dto);
});


app.Run();
