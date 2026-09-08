/*
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
            MobileNumber = "01772454194"
        };
        bkashPayment.ValidatePayment();
        bkashPayment.ProcessPayment();
        bkashPayment.ShowInfo();

    }
}
*/

/*
// ============================================================
//          OOP - ABSTRACTION USING INTERFACE
// ============================================================
//
// An interface defines a set of methods that implementing
// classes must provide.
//
// Payment interface defines:
// 1. PaymentProcess()
// 2. ShowInfo()
//
// CreditCardPayment and BkashPayment implement the Payment
// interface and provide their own implementations.
//
// ============================================================
using System;

public interface Payment
{
    public void PaymentProcess();
    public void ShowInfo();
}

public class CreditCardPayment : Payment
{
    public void PaymentProcess()
    {
        Console.WriteLine("Payment by Credit Card");
    }

    public void ShowInfo()
    {
        Console.WriteLine("Credit Card Payment Info");
    }
}

public class BkashPayment : Payment
{
    public void PaymentProcess()
    {
        Console.WriteLine("Payment by Bkash");
    }

    public void ShowInfo()
    {
        Console.WriteLine("Bkash Payment Info");
    }
}

class Program
{
    public static void Main()
    {
        Payment payment = new CreditCardPayment();
        payment.PaymentProcess();
        payment.ShowInfo();

        Payment payment2 = new BkashPayment();
        payment2.PaymentProcess();
        payment2.ShowInfo();
    }
}
*/


// ============================================================
//       OOP - INTERFACE & RUNTIME POLYMORPHISM
// ============================================================
//
// INotify defines common methods:
// Send(), Log(), Save()
//
// EmailNotify and SMSNotify implement the INotify interface
// and provide their own implementations.
//
// The same interface reference can refer to different
// implementing class objects.
//
// This demonstrates:
// 1. Abstraction using Interface
// 2. Interface Implementation
// 3. Runtime Polymorphism
//
// ============================================================
using System;
using System.Collections.Generic;

public interface INotify
{
    public void Send();
    public void Log();
    public void Save();
}

public class EmailNotify : INotify
{
    public string Email { get; set; }
    public void Send()
    {
        Console.WriteLine("Sending Email to " + Email);
    }
     public void Log()
    {
        Console.WriteLine("Logging Email to " + Email);
    }
     public void Save()
    {
        Console.WriteLine("Saving DB to " + Email);
    }
}

public class SMSNotify : INotify
{
    public string Phone { get; set; }
    public void Send()
    {
        Console.WriteLine("Sending SMS to " + Phone);
    }
     public void Log()
    {
        Console.WriteLine("Logging SMS to " + Phone);
    }
     public void Save()
    {
        Console.WriteLine("Saving DB to " + Phone);
    }
}


class Program
{
    public static void Main()
    {
        // INotify emailNotify = new EmailNotify{ Email = "test@example.com" };
        // emailNotify.Send();

        // INotify smsNotify = new SMSNotify { Phone = "01772454194"};
        // smsNotify.Send();

        // ============================================================
        //                   IMPROVED APPROACH
        // ============================================================
        //
        // Instead of creating and handling each notification object
        // separately, we can store all notification objects in a list
        // using the common interface type.
        //
        // This makes the code cleaner, shorter, and easier to maintain.
        //
        // ============================================================

        IList<INotify> notifies = new List<INotify>
        {
            new EmailNotify { Email = "test@example.com" },
            new SMSNotify { Phone = "01772454194"}
        };

        foreach(var notify in notifies)
        {
            notify.Send();
            notify.Log();
            notify.Save();
        }
        
    }
}

