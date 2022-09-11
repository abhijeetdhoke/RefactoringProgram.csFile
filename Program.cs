using cleanProgramFile.ProjectStartUp;

var builder = WebApplication.CreateBuilder(args);
//Refactored the webApp services
builder.Services.RegisterService();

var app = builder.Build();

//Refactored the Swagger
app.ConfigureSwagger();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
