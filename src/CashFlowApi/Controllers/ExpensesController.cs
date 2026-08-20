using CashFlow.Aplication.UseCases.Expenses.Register;
using CashFlow.Comunication.Requests;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestExpenseJson request)
    {
        var useCase = new ResgisterExpenseUseCase();

        var reponse = useCase.Execute(request);

        return Created(string.Empty, reponse);
    }
}
