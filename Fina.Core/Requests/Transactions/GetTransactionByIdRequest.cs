using MyFinances.Core.Requests;

namespace MyFinances.Core.Requests.Transactions;

public class GetTransactionByIdRequest : Request
{
    public long Id { get; set; }
}