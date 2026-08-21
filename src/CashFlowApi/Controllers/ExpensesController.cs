using CashFlow.Aplication.UseCases.Expenses.Register;
using CashFlow.Comunication.Requests;
using CashFlow.Comunication.Resposes;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestExpenseJson request)
    {
        try
        {
            var useCase = new ResgisterExpenseUseCase();

            var reponse = useCase.Execute(request);

            return Created(string.Empty, reponse);

        }
        catch (ArgumentException ex)
        {
            var errorResponse = new ResponseErrorJson
            {
                ErrorMessage = ex.Message
            };
            

            return BadRequest(errorResponse);
        }
        catch  
        {
            var errorResponse = new ResponseErrorJson
            {
                ErrorMessage = "unknown error"
            };


            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }
}
