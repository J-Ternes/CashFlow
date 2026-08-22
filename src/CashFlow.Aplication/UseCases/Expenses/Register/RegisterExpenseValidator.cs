using CashFlow.Comunication.Requests;
using FluentValidation;

namespace CashFlow.Aplication.UseCases.Expenses.Register;

public class RegisterExpenseValidator : AbstractValidator<RequestExpenseJson>
{
    public RegisterExpenseValidator()
    {
        RuleFor(expense => expense.Title).NotEmpty().WithMessage("Title is required");
        RuleFor(expense => expense.Amount).GreaterThan(0).WithMessage("Amount must be a positive number");
        RuleFor(expense => expense.Date).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Date cannot be in the future");
        RuleFor(expense => expense.PaymentType).IsInEnum().WithMessage("Invalid payment type");
    }
}
