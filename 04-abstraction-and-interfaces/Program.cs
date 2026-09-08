using System;

// ============================================================
//              OOP - ABSTRACTION USING ABSTRACT CLASS
// ============================================================
//
// Payment is used as a Base/Parent class for different
// payment methods such as Bkash and Mastercard.
//
// We do not create objects directly from the Payment class.
// It is used only as a common blueprint for child classes.
//
// ValidatePayment() and ProcessPayment() are made abstract
// because different payment methods may have different
// validation and processing logic.
//
// The child classes must provide their own implementation
// of these abstract methods.
//
// ============================================================


// Payment is an abstract Base/Parent class.
// It is used as a common blueprint for different payment methods.
public abstract class Payment
{
    // Common properties for all payment methods
    public int Amount { get; set; }
    public string TransactionId { get; set; }

    // Different payment methods may validate payments differently.
    // Therefore, no implementation is provided here.
    // Different payment methods have different validation logic.
    // Therefore, this method is declared as abstract.
    public abstract void ValidatePayment();

    // Different payment methods may process payments differently.
    // Therefore, no implementation is provided here.
    // Different payment methods have different processing logic.
    // Therefore, this method is declared as abstract.
    public abstract void ProcessPayment();

    // Common method that can be used by all child classes
    public void ShowInfo()
    {
        Console.WriteLine("Amount: {0}", Amount);
        Console.WriteLine("TransactionId: {0}", TransactionId);
    }
}

public class CreditCardPayment : Payment
{
    public string CardNumber { get; set; }

    public override void ValidatePayment()
    {
        Console.WriteLine("Validating Credit Card Payment");
    }

    public override void ProcessPayment()
    {
        Console.WriteLine("Processing Credit Card payment");
    }
}

public class BkashPayment : Payment
{
    public string MobileNumber { get; set; }

    public override void ValidatePayment()
    {
        Console.WriteLine("Validating Bkash Payment");
    }

    public override void ProcessPayment()
    {
        Console.WriteLine("Processing Bkash payment");
    }
}

class Program
{
    public static void Main()
    {
        // Base class reference is used to create objects of child classes.
        // This also demonstrates Runtime Polymorphism.
        Payment creditCardPayment = new CreditCardPayment
        {
            Amount = 100,
            TransactionId = "123456",
            CardNumber = "212156217251251"
        };
        creditCardPayment.ValidatePayment();
        creditCardPayment.ProcessPayment();
        creditCardPayment.ShowInfo();

        Payment bkashPayment = new BkashPayment
        {
            Amount = 200,
            TransactionId = "37238222362",
            MobileNumber = "01772554195"
        };
        bkashPayment.ValidatePayment();
        bkashPayment.ProcessPayment();
        bkashPayment.ShowInfo();

    }
}