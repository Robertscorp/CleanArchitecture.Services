using CleanArchitecture.StaticEntity.Entities;
using CleanArchitecture.StaticEntity.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using var _ServiceProvider
    = new ServiceCollection()
            .AddDbContext<IPersistenceContext, PersistenceContext>(opts => opts.UseSqlite("Data Source=Database.db"))
            .BuildServiceProvider();

var _PersistenceContext = _ServiceProvider.GetService<IPersistenceContext>()!;
var _Context = (PersistenceContext)_PersistenceContext;
_Context.Database.Migrate();

// Gender doesn't exist in the database, but the "Use Case" isn't aware of that!
foreach (var _Gender in _PersistenceContext.GetEntities<Gender>())
    Console.WriteLine($"{_Gender.ID}: {_Gender.Name}");

foreach (var _Person in _PersistenceContext.GetEntities<Person>())
    Console.WriteLine($"{_Person.ID}: {_Person.Name} ({_Person.Gender.Name})");

try
{
    // EFCore can't translate this query - it doesn't know anything about Gender.
    foreach (var _Person in _PersistenceContext.GetEntities<Person>().Where(p => p.Gender.ID == 3))
        Console.WriteLine($"Mayonnaisian: {_Person.Name}");
}
catch (Exception _Exception)
{
    Console.WriteLine(_Exception.ToString());
}