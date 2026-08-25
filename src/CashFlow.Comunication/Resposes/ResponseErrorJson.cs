namespace CashFlow.Comunication.Resposes;

public class ResponseErrorJson
{
    public List<string> ErrorMessage { get; set; }

    public ResponseErrorJson(List<string> errorMessages)
    {
        ErrorMessage = errorMessages;
    }

    public ResponseErrorJson(string errorMessages)
    {
        ErrorMessage = new List<string> { errorMessages };
    }



}
