using MyFinances.Core.Requests;

namespace MyFinances.Core.Requests.Transactions;

public class DeleteTransactionRequest : Request
{
    public long Id { get; set; }
}