public enum PaymentTypes
{
    CREDIT_CARD,
    PIX,
    PAYPAL
}

public interface IPaymentHandler
{
    void ProccessPayment(float amount);
}

public class CreditCardPaymentHandler : IPaymentHandler
{
    public void ProccessPayment()
    {
        // LÓGICA PARA PROCESSAMENTO DE PAGAMENTO VIA CREDITCARD
    }
}

public class PixPaymentHandler : IPaymentHandler
{
    public void ProccessPayment()
    {
        // LÓGICA PARA PROCESSAMENTO DE PAGAMENTO VIA PIX
    }
}

public class PaypalPaymentHandler : IPaymentHandler
{
    public void ProccessPayment()
    {
        // LÓGICA PARA PROCESSAMENTO DE PAGAMENTO VIA PAYPAL
    }
}

public class Main
{
    public static void Main(string[] args)
    {
        // SIMULANDO INPUTS DO USUÁRIO
        PaymentTypes selectedPaymentType = PaymentTypes.CREDIT_CARD;
        float totalAmount = 580.50;

        var paymentHandler = null;

        switch (selectedPaymentType)
        {
            case PaymentTypes.CREDIT_CARD:
                paymentHandler = new CreditCardPaymentHandler();
            case PaymentTypes.PIX:
                paymentHandler = new PixPaymentHandler();
            case PaymentTypes.PAYPAL:
                paymentHandler = new PaypalPaymentHandler();
        }
        
        paymentHandler.ProccessPayment(totalAmount);
    }
}