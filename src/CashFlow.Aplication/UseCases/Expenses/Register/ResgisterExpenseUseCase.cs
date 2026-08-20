using CashFlow.Comunication.Requests;
using CashFlow.Comunication.Resposes;

namespace CashFlow.Aplication.UseCases.Expenses.Register;

public class ResgisterExpenseUseCase
{
    public ResponseRegisterExpenseJson Execute(RequestExpenseJson request)
    {
        return new ResponseRegisterExpenseJson();
    }
}
