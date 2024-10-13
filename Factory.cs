public enum PaymentTypes
{
    CREDIT_CARD,
    PIX,
    PAYPAL
}

public class PaymentFactory
{
    public static IPaymentHandler GetPaymentMethod(PaymentTypes paymentType)
    {
        switch (paymentType)
        {
            case PaymentTypes.CREDIT_CARD:
                return new CreditCardPaymentHandler();
            case PaymentTypes.PAYPAL:
                return new PaypalPaymentHandler();
            case PaymentTypes.PIX:
                return new PixPaymentHandler();
        }
    }
}

public interface IPaymentHandler
{
    public void ProccessPayment(float amount);
}

public class CreditCardPaymentHandler : IPaymentHandler
{
    public void ProccessPayment(float amount)
    {
        // Credit card payment actions
    }
}

public class PaypalPaymentHandler : IPaymentHandler
{
    public void ProccessPayment(float amount)
    {
        // Paypal payment handler
    }
}

public class PixPaymentHandler : IPaymentHandler
{
    public void ProccessPayment(float amount)
    {
        // Pix payment handler
    }
}

// Classe principal
public class Main
{
    public static void Main(string[] args)
    {
        PaymentTypes selectedPaymentType = PaymentTypes.CREDIT_CARD;
        float totalAmount = 580.50;

        IPaymentHandler paymentHandler = PaymentFactory.GetPaymentMethod(selectedPaymentType);
        paymentHandler.ProccessPayment(amount);
    }
}