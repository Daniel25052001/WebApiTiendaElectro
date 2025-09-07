var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

app.UseHttpsRedirection();
//////////////////////////////
app.MapGet("/paisget", () =>
{
    ApiPais apiPais = new ApiPais();
    return apiPais.ConsultarPais;

})
.WithName("GetPais");

////////////////////////////////////////7
app.MapPost("/paispost",(PaisModel paisModel) =>
{
    ApiPais apiPais = new ApiPais();
    return apiPais.IngresarPais(paisModel);

})
.WithName("PostPais");


////////////////////////////////////////////////7
app.MapPut("/paisput",(int idPais, PaisModel paisModel) =>
{
    ApiPais apiPais = new ApiPais();
    return apiPais.ModificarPais(idPais, paisModel);

})
.WithName("PutPais");


//////////////////////////////////////
app.MapDelete("/paisdelete", (int idPais) =>
{
    ApiPais apiPais = new ApiPais();
    return apiPais.EliminarPais(idPais);

})
.WithName("DeletePais");



app.Run();