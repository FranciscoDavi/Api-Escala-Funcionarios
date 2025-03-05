using Api.Data;
using Api.Repositories;
using Api.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();


builder.Services.AddDbContext<StaffScheduleDBContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

//Injetando depencias de Funcionarios(Employees)
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<EmployeeService>();

//Injetando dependencias de Turnos(Shifts)
builder.Services.AddScoped<IShiftRepository, ShiftRepository>();
builder.Services.AddScoped<ShiftService>();

//Injetando dependencias de Tarefas(Tasks)
builder.Services.AddScoped<ITaskRepository, TaskRepository>();
builder.Services.AddScoped<TaskService>();

builder.Services.AddScoped<ITaskEmployeeRepository, TaskEmployeeRepository>();
builder.Services.AddScoped<TaskEmployeeService>();

builder.Services.AddScoped<IShiftTaskRepository, ShiftTaskRepository>();
builder.Services.AddScoped<ShiftTaskService>();

builder.Services.AddScoped<IShiftEmployeeRepository, ShiftEmployeeRepository>();
builder.Services.AddScoped<ShiftEmployeeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
