using PizzariaAspNet.Dto;
using PizzariaAspNet.Models;

namespace PizzariaAspNet.Services.Pizza;

public interface IPizzaInterface
{
    Task<PizzaModel> CriarPizza(PizzaCriacaoDto pizzaCriacaoDto, IFormFile foto);
    Task<List<PizzaModel>> GetPizzas();
    Task<PizzaModel> GetPizzaPorId(int id);
    Task<PizzaModel> EditarPizza(PizzaModel pizza, IFormFile? foto);
    Task<PizzaModel> RemoverPizza(int id);
    Task<List<PizzaModel>> GetPizzasFiltro(string? pesquisar);
}
