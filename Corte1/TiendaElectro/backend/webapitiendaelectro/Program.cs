
using domain.geografia.ciudad;
using domain.geografia.departamento;
using domain.producto.categoria;
using dominio.transaccion.detalleventa;
using Dominio.Transaccion.EstadoVenta;
using Dominio.Transaccion.Venta;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOpenApi();

var app = builder.Build();

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
    return apiPais.ConsultarPais();

})
.WithName("GetPais");


///////////////////////////////

app.MapPost("/paispost", (PaisModel paisModel) =>
{
    ApiPais apiPais = new ApiPais();
    return apiPais.IngresarPais(paisModel);

})
.WithName("PostPais");

///////////////////////////

app.MapPut("/paisput",(int idPais, PaisModel paisModel) =>
{
    ApiPais apiPais = new ApiPais();
    return apiPais.ModificarPais(idPais, paisModel);

})
.WithName("PutPais");

///////////////////////////

app.MapDelete("/paisdelete", (int idPais) =>
{
    ApiPais apiPais = new ApiPais();
    return apiPais.EliminarPais(idPais);

})
.WithName("DeletePais");


//////////////////////////////
// CIUDAD
//////////////////////////////

// GET: Consultar todas las ciudades
app.MapGet("/ciudad", () =>
{
    ApiCiudad apiCiudad = new ApiCiudad();
    return apiCiudad.ConsultarCiudad();
})
.WithName("GetCiudad");

// POST: Crear ciudad
app.MapPost("/ciudad", (CiudadModel ciudadModel) =>
{
    ApiCiudad apiCiudad = new ApiCiudad();
    return apiCiudad.IngresarCiudad(ciudadModel);
})
.WithName("PostCiudad");

// PUT: Modificar ciudad
app.MapPut("/ciudad/{id}", (int idCiudad, CiudadModel ciudadModel) =>
{
    ApiCiudad apiCiudad = new ApiCiudad();
    return apiCiudad.ModificarCiudad(idCiudad, ciudadModel);
})
.WithName("PutCiudad");

// DELETE: Eliminar ciudad
app.MapDelete("/ciudad/{id}", (int idCiudad) =>
{
    ApiCiudad apiCiudad = new ApiCiudad();
    return apiCiudad.EliminarCiudad(idCiudad);
})
.WithName("DeleteCiudad");

////////////////////////////////////////////////////////////////

// ENDPOINTS DEPARTAMENTO


// GET: Consultar todos los departamentos
app.MapGet("/departamento", () =>
{
    ApiDepartamento apiDepartamento = new ApiDepartamento();
    return apiDepartamento.ConsultarDepartamento();
}).WithName("GetDepartamento");

// POST: Crear departamento
app.MapPost("/departamento", (DepartamentoModel departamentoModel) =>
{
    ApiDepartamento apiDepartamento = new ApiDepartamento();
    return apiDepartamento.IngresarDepartamento(departamentoModel);
}).WithName("PostDepartamento");

// PUT: Modificar departamento
app.MapPut("/departamento/{id}", (int iddepartamento, DepartamentoModel departamentoModel) =>
{
    ApiDepartamento apiDepartamento = new ApiDepartamento();
    return apiDepartamento.ModificarDepartamento(iddepartamento, departamentoModel);
}).WithName("PutDepartamento");

// DELETE: Eliminar departamento
app.MapDelete("/departamento/{id}", (int iddepartamento) =>
{
    ApiDepartamento apiDepartamento = new ApiDepartamento();
    return apiDepartamento.EliminarDepartamento(iddepartamento);
}).WithName("DeleteDepartamento");


////////////////////////////////////////////////////////////////////


// ENDPOINTS COMPRADOR

// GET: Consultar todos los compradores
app.MapGet("/comprador", () =>
{
    ApiComprador apiComprador = new ApiComprador();
    return apiComprador.Consultarcomprador();
}).WithName("GetComprador");

// POST: Crear comprador
app.MapPost("/comprador", (CompradorModel compradorModel) =>
{
    ApiComprador apiComprador = new ApiComprador();
    return apiComprador.IngresarComprador(compradorModel);
}).WithName("PostComprador");

// PUT: Modificar comprador
app.MapPut("/comprador/{id}", (int idComprador, CompradorModel compradorModel) =>
{
    ApiComprador apiComprador = new ApiComprador();
    return apiComprador.ModificarComprador(idComprador, compradorModel);
}).WithName("PutComprador");

// DELETE: Eliminar comprador
app.MapDelete("/comprador/{id}", (int idComprador) =>
{
    ApiComprador apiComprador = new ApiComprador();
    return apiComprador.EliminarComprador(idComprador);
}).WithName("DeleteComprador");


//////////////////////////////////////////////////////////////////

// ENDPOINTS DOCUMENTO

// GET: Consultar todos los documentos
app.MapGet("/documento", () =>
{
    ApiDocumento apiDocumento = new ApiDocumento();
    return apiDocumento.ConsultarDocumento();
}).WithName("GetDocumento");

// POST: Crear documento
app.MapPost("/documento", (DocumentoModel documentoModel) =>
{
    ApiDocumento apiDocumento = new ApiDocumento();
    return apiDocumento.IngresarDocumento(documentoModel);
}).WithName("PostDocumento");

// PUT: Modificar documento
app.MapPut("/documento/{id}", (int idDocumento, DocumentoModel documentoModel) =>
{
    ApiDocumento apiDocumento = new ApiDocumento();
    return apiDocumento.ModificarDocumento(idDocumento, documentoModel);
}).WithName("PutDocumento");

// DELETE: Eliminar documento
app.MapDelete("/documento/{id}", (int idDocumento) =>
{
    ApiDocumento apiDocumento = new ApiDocumento();
    return apiDocumento.EliminarDocumento(idDocumento);
}).WithName("DeleteDocumento");



/////////////////////////////////////////////////
// ENDPOINTS GENERO

// GET: Consultar todos los generos
app.MapGet("/genero", () =>
{
    ApiGenero apiGenero = new ApiGenero();
    return apiGenero.ConsultarGenero();
}).WithName("GetGenero");

// POST: Crear genero
app.MapPost("/genero", (GeneroModel generoModel) =>
{
    ApiGenero apiGenero = new ApiGenero();
    return apiGenero.IngresarGenero(generoModel);
}).WithName("PostGenero");

// PUT: Modificar genero
app.MapPut("/genero/{idGenero}", (int idGenero, GeneroModel generoModel) =>
{
    ApiGenero apiGenero = new ApiGenero();
    return apiGenero.ModificarGenero(idGenero, generoModel);
}).WithName("PutGenero");

// DELETE: Eliminar genero
app.MapDelete("/genero/{idGenero}", (int idGenero) =>
{
    ApiGenero apiGenero = new ApiGenero();
    return apiGenero.EliminarGenero(idGenero);
}).WithName("DeleteGenero");


//////////////////////////////////////////////////////////////


// ENDPOINTS SEDE

// GET: Consultar todas las sedes
app.MapGet("/sede", () =>
{
    ApiSede apiSede = new ApiSede();
    return apiSede.ConsultarSede();
}).WithName("GetSede");

// POST: Crear sede
app.MapPost("/sede", (SedeModel sedeModel) =>
{
    ApiSede apiSede = new ApiSede();
    return apiSede.IngresarSede(sedeModel);
}).WithName("PostSede");

// PUT: Modificar sede
app.MapPut("/sede/{id}", (int idSede, SedeModel sedeModel) =>
{
    ApiSede apiSede = new ApiSede();
    return apiSede.ModificarSede(idSede, sedeModel);
}).WithName("PutSede");

// DELETE: Eliminar sede
app.MapDelete("/sede/{id}", (int idSede) =>
{
    ApiSede apiSede = new ApiSede();
    return apiSede.EliminarSede(idSede);
}).WithName("DeleteSede");
/////////////////////////////////////////////////////////////////


// ENDPOINTS TIENDA

// GET: Consultar todas las tiendas
app.MapGet("/tienda", () =>
{
    ApiTienda apiTienda = new ApiTienda();
    return apiTienda.ConsultarTienda();
}).WithName("GetTienda");

// POST: Crear tienda
app.MapPost("/tienda", (TiendaModel tiendaModel) =>
{
    ApiTienda apiTienda = new ApiTienda();
    return apiTienda.IngresarTienda(tiendaModel);
}).WithName("PostTienda");

// PUT: Modificar tienda
app.MapPut("/tienda/{id}", (int idTienda, TiendaModel tiendaModel) =>
{
    ApiTienda apiTienda = new ApiTienda();
    return apiTienda.ModificarTienda(idTienda, tiendaModel);
}).WithName("PutTienda");

// DELETE: Eliminar tienda
app.MapDelete("/tienda/{id}", (int idTienda) =>
{
    ApiTienda apiTienda = new ApiTienda();
    return apiTienda.EliminarTienda(idTienda);
}).WithName("DeleteTienda");

////////////////////////////////////////////////////////



// ENDPOINTS VENDEDOR

// GET: Consultar todos los vendedores
app.MapGet("/vendedor", () =>
{
    ApiVendedor apiVendedor = new ApiVendedor();
    return apiVendedor.ConsultarVendedor();
}).WithName("GetVendedor");

// POST: Crear vendedor
app.MapPost("/vendedor", (VendedorModel vendedorModel) =>
{
    ApiVendedor apiVendedor = new ApiVendedor();
    return apiVendedor.IngresarVendedor(vendedorModel);
}).WithName("PostVendedor");

// PUT: Modificar vendedor
app.MapPut("/vendedor/{id}", (int idVendedor, VendedorModel vendedorModel) =>
{
    ApiVendedor apiVendedor = new ApiVendedor();
    return apiVendedor.ModificarVendedor(idVendedor, vendedorModel);
}).WithName("PutVendedor");

// DELETE: Eliminar vendedor
app.MapDelete("/vendedor/{id}", (int idVendedor) =>
{
    ApiVendedor apiVendedor = new ApiVendedor();
    return apiVendedor.EliminarVendedor(idVendedor);
}).WithName("DeleteVendedor");


////////////////////////////////////////////////

// ENDPOINTS CATEGORIA

// GET: Consultar todas las categorias
app.MapGet("/categoria", () =>
{
    ApiCategoria apiCategoria = new ApiCategoria();
    return apiCategoria.ConsultarCategoria();
}).WithName("GetCategoria");

// POST: Crear categoria
app.MapPost("/categoria", (CategoriaModel categoriaModel) =>
{
    ApiCategoria apiCategoria = new ApiCategoria();
    return apiCategoria.IngresarCategoria(categoriaModel);
}).WithName("PostCategoria");

// PUT: Modificar categoria
app.MapPut("/categoria/{id}", (int idCategoria, CategoriaModel categoriaModel) =>
{
    ApiCategoria apiCategoria = new ApiCategoria();
    return apiCategoria.ModificarCategoria(idCategoria, categoriaModel);
}).WithName("PutCategoria");

// DELETE: Eliminar categoria
app.MapDelete("/categoria/{id}", (int idCategoria) =>
{
    ApiCategoria apiCategoria = new ApiCategoria();
    return apiCategoria.EliminarCategoria(idCategoria);
}).WithName("DeleteCategoria");

//////////////////////////////////////////////////////////////


// ENDPOINTS MARCA

// GET: Consultar todas las marcas
app.MapGet("/marca", () =>
{
    ApiMarca apiMarca = new ApiMarca();
    return apiMarca.ConsultarMarca();
}).WithName("GetMarca");

// POST: Crear marca
app.MapPost("/marca", (MarcaModel marcaModel) =>
{
    ApiMarca apiMarca = new ApiMarca();
    return apiMarca.IngresarMarca(marcaModel);
}).WithName("PostMarca");

// PUT: Modificar marca
app.MapPut("/marca/{id}", (int idMarca, MarcaModel marcaModel) =>
{
    ApiMarca apiMarca = new ApiMarca();
    return apiMarca.ModificarMarca(idMarca, marcaModel);
}).WithName("PutMarca");

// DELETE: Eliminar marca
app.MapDelete("/marca/{id}", (int idMarca) =>
{
    ApiMarca apiMarca = new ApiMarca();
    return apiMarca.EliminarMarca(idMarca);
}).WithName("DeleteMarca");


/////////////////////////////////////////////////////////////////


// ENDPOINTS MODELO

// GET: Consultar todos los modelos
app.MapGet("/modelo", () =>
{
    ApiModelo apiModelo = new ApiModelo();
    return apiModelo.ConsultarModelo();
}).WithName("GetModelo");

// POST: Crear modelo
app.MapPost("/modelo", (ModeloModel modeloModel) =>
{
    ApiModelo apiModelo = new ApiModelo();
    return apiModelo.IngresarModelo(modeloModel);
}).WithName("PostModelo");

// PUT: Modificar modelo
app.MapPut("/modelo/{id}", (int idModelo, ModeloModel modeloModel) =>
{
    ApiModelo apiModelo = new ApiModelo();
    return apiModelo.ModificarModelo(idModelo, modeloModel);
}).WithName("PutModelo");

// DELETE: Eliminar modelo
app.MapDelete("/modelo/{id}", (int idModelo) =>
{
    ApiModelo apiModelo = new ApiModelo();
    return apiModelo.EliminarModelo(idModelo);
}).WithName("DeleteModelo");


///////////////////////////////////////////////////////////

// ENDPOINTS DETALLEVENTA

// GET: Consultar detalles de venta
app.MapGet("/detalleventa", () =>
{
    ApiDetalleVenta apiDetalleVenta = new ApiDetalleVenta();
    return apiDetalleVenta.ConsultarDetalleVenta();
}).WithName("GetDetalleVenta");

// POST: Crear detalle de venta
app.MapPost("/detalleventa", (DetalleVentaModel detalleVentaModel) =>
{
    ApiDetalleVenta apiDetalleVenta = new ApiDetalleVenta();
    return apiDetalleVenta.IngresarDetalleVenta(detalleVentaModel);
}).WithName("PostDetalleVenta");

// PUT: Modificar detalle de venta
app.MapPut("/detalleventa/{id}", (int idDetalleVenta, DetalleVentaModel detalleVentaModel) =>
{
    ApiDetalleVenta apiDetalleVenta = new ApiDetalleVenta();
    return apiDetalleVenta.ModificarDetalleVenta(idDetalleVenta, detalleVentaModel);
}).WithName("PutDetalleVenta");

// DELETE: Eliminar detalle de venta
app.MapDelete("/detalleventa/{id}", (int idDetalleVenta) =>
{
    ApiDetalleVenta apiDetalleVenta = new ApiDetalleVenta();
    return apiDetalleVenta.EliminarDetalleVenta(idDetalleVenta);
}).WithName("DeleteDetalleVenta");


///////////////////////////////////////////////////7
// ENDPOINTS ESTADO VENTA

// GET: Consultar todos los estados de venta
app.MapGet("/estadoventa", () =>
{
    ApiEstadoVenta apiEstadoVenta = new ApiEstadoVenta();
    return apiEstadoVenta.ConsultarEstadoVenta();
}).WithName("GetEstadoVenta");

// POST: Crear estado de venta
app.MapPost("/estadoventa", (EstadoVentaModel estadoVentaModel) =>
{
    ApiEstadoVenta apiEstadoVenta = new ApiEstadoVenta();
    return apiEstadoVenta.IngresarEstadoVenta(estadoVentaModel);
}).WithName("PostEstadoVenta");

// PUT: Modificar estado de venta
app.MapPut("/estadoventa/{id}", (int idEstadoVenta, EstadoVentaModel estadoVentaModel) =>
{
    ApiEstadoVenta apiEstadoVenta = new ApiEstadoVenta();
    return apiEstadoVenta.ModificarEstadoVenta(idEstadoVenta, estadoVentaModel);
}).WithName("PutEstadoVenta");

// DELETE: Eliminar estado de venta
app.MapDelete("/estadoventa/{id}", (int idEstadoVenta) =>
{
    ApiEstadoVenta apiEstadoVenta = new ApiEstadoVenta();
    return apiEstadoVenta.EliminarEstadoVenta(idEstadoVenta);
}).WithName("DeleteEstadoVenta");

///////////////////////////////////////////////////////////////


// ENDPOINTS VENTA

// GET: Consultar todas las ventas
app.MapGet("/venta", () =>
{
    ApiVenta apiVenta = new ApiVenta();
    return apiVenta.ConsultarVenta();
}).WithName("GetVenta");

// POST: Crear una venta
app.MapPost("/venta", (VentaModel ventaModel) =>
{
    ApiVenta apiVenta = new ApiVenta();
    return apiVenta.IngresarVenta(ventaModel);
}).WithName("PostVenta");

// PUT: Modificar una venta
app.MapPut("/venta/{id}", (int idventa, VentaModel ventaModel) =>
{
    ApiVenta apiVenta = new ApiVenta();
    return apiVenta.ModificarVenta(idventa, ventaModel);
}).WithName("PutVenta");

// DELETE: Eliminar una venta
app.MapDelete("/venta/{id}", (int idventa) =>
{
    ApiVenta apiVenta = new ApiVenta();
    return apiVenta.EliminarVenta(idventa);
}).WithName("DeleteVenta");













app.Run();