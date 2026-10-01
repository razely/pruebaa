using MinimalAPI.Controladores;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Registrar las rutas desde la carpeta Controladores
app.RegistrarEndpointsEquipo();
app.RegistrarEndpointsUsuario();

app.Run();