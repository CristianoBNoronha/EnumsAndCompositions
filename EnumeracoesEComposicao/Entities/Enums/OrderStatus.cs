

namespace EnumeracoesEComposicao.Entities.Enums
{
    class OrderStatus
    {
        enum Status : int
        {
            PendingPayment = 0,
            Processing = 1,
            Shiped = 2,
            Delivered = 3
        }
    }
}
