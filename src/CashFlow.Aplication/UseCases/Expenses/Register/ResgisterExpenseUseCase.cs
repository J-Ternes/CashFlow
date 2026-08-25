using CashFlow.Comunication.Enums;
using CashFlow.Comunication.Requests;
using CashFlow.Comunication.Resposes;
using CashFlow.Exception.ExceptionsBase;

namespace CashFlow.Aplication.UseCases.Expenses.Register;

public class ResgisterExpenseUseCase
{
    public ResponseRegisterExpenseJson Execute(RequestExpenseJson request)
    {
        Validate(request);
        return new ResponseRegisterExpenseJson();
    }


    private void Validate(RequestExpenseJson request)
    {
        var validator = new RegisterExpenseValidator();

        var result = validator.Validate(request);

        if (!result.IsValid)
        {
            var errorMessages = result.Errors.Select(x => x.ErrorMessage).ToList();

            throw new ErrorOnValidationException(errorMessages);
        }

     
    }
}
