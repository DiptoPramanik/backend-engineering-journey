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

/*
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
*/

/*
// ============================================================
//          INTERFACE, RUNTIME POLYMORPHISM & NOTIFICATION
//                        CONTEXT PATTERN
// ============================================================
//
// INotify defines the common operations for all notification types.
//
// EmailNotify, SMSNotify and PushNotify implement the INotify
// interface and provide their own implementation of Send(),
// Log() and Save().
//
// NotifyContext receives an INotify object through its constructor
// and uses it to process the notification.
//
// The same INotify interface can refer to different notification
// objects. This demonstrates Runtime Polymorphism.
//
// Different notification contexts are stored in a single list,
// and foreach is used to process all notifications uniformly.
//
// Main Concepts:
// 1. Interface
// 2. Interface Implementation
// 3. Runtime Polymorphism
// 4. Constructor Dependency Injection
// 5. List of Objects
// 6. foreach for Uniform Processing
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

public class PushNotify : INotify
{
    public string Token { get; set; }
    public void Send()
    {
        Console.WriteLine("Sending Push to " + Token);
    }
     public void Log()
    {
        Console.WriteLine("Logging Push to " + Token);
    }
     public void Save()
    {
        Console.WriteLine("Saving DB to " + Token);
    }
}

public class NotifyContext
{
    public INotify notify { get; set; }
    public NotifyContext(INotify notify)
    {
        this.notify = notify;
    }
    public void Process()
    {
        notify.Send();
        notify.Log();
        notify.Save();
    }
}

/*
class Program
{
    public static void Main()
    {
        // IList<NotifyContext> notifyContexts = new List<NotifyContext>
        // {
        //     new NotifyContext(new EmailNotify { Email = "test@example.com" }),
        //     new NotifyContext(new SMSNotify { Phone = "01772454194"})
        // };


        //------------------In a Easier Way-----------------
        IList<NotifyContext> notifyContexts = new List<NotifyContext>();
        //EmailNotify emailNotify = new EmailNotify
        INotify emailNotify = new EmailNotify
        {
            Email = "test@example.com"
        };

        //SMSNotify smsNotify = new SMSNotify
        INotify smsNotify = new SMSNotify
        {
            Phone = "01772454194"
        };

        // notifyContexts.Add(new NotifyContext(emailNotify));
        // notifyContexts.Add(new NotifyContext(smsNotify));

        //-----------In a Easier way-------------
        NotifyContext emailNotifyContext = new NotifyContext(emailNotify);
        NotifyContext smsNotifyContext = new NotifyContext(smsNotify);

        notifyContexts.Add(emailNotifyContext);
        notifyContexts.Add(smsNotifyContext);
        foreach(NotifyContext notifyContext in notifyContexts)
        {
            notifyContext.Process();
        }
    }
}
*/
// ============================================================
//              ANOTHER WAY TO IMPLEMENT MAIN()
// ============================================================
//
// 1. Create different notification objects using INotify.
// 2. Pass each notification object to NotifyContext.
// 3. Store all NotifyContext objects in a single list.
// 4. Use foreach to process all notifications.
//
// This approach makes the code clean and easy to manage.
//
// ============================================================
/*
class Program
{
    public static void Main()
    {

        INotify emailNotify = new EmailNotify
        {
            Email = "test@example.com"
        };

        INotify smsNotify = new SMSNotify
        {
            Phone = "01772454194"
        };

        INotify pushNotify = new PushNotify
        {
            Token = "734637488"
        };

        NotifyContext emailNotifyContext = new NotifyContext(emailNotify);
        NotifyContext smsNotifyContext = new NotifyContext(smsNotify);
        NotifyContext pushNotifyContext = new NotifyContext(pushNotify);

        // emailNotifyContext.Process();
        // smsNotifyContext.Process();
        IList<NotifyContext> notifyContexts = new List<NotifyContext>()
        {
            emailNotifyContext,
            smsNotifyContext,
            pushNotifyContext
        };

        foreach(var notifyContext in notifyContexts)
        {
            notifyContext.Process();
        }

    }
}
*/

/*
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

public class PushNotify : INotify
{
    public string Token { get; set; }
    public void Send()
    {
        Console.WriteLine("Sending Push to " + Token);
    }
     public void Log()
    {
        Console.WriteLine("Logging Push to " + Token);
    }
    // ============================================================
    //       INTERFACE SEGREGATION PRINCIPLE (ISP) VIOLATION
    // ============================================================
    //
    // If PushNotify does not need the Save() functionality,
    // forcing it to implement Save() violates the ISP.
    //
    // Bad Approach:
    // PushNotify is forced to implement an unnecessary method:
    //
    // public void Save() { }
    //
    // Even though PushNotify does not need to save data to the DB.
    //
    // ISP Principle:
    // A class should not be forced to depend on or implement
    // methods that it does not need.
    //
    // ============================================================
     public void Save(){}
}

public class NotifyContext
{
    public INotify notify { get; set; }
    public NotifyContext(INotify notify)
    {
        this.notify = notify;
    }
    public void Process()
    {
        notify.Send();
        notify.Log();
        notify.Save();
    }
}

class Program
{
    public static void Main()
    {

        INotify emailNotify = new EmailNotify
        {
            Email = "test@example.com"
        };

        INotify smsNotify = new SMSNotify
        {
            Phone = "01772454194"
        };

        INotify pushNotify = new PushNotify
        {
            Token = "734637488"
        };

        NotifyContext emailNotifyContext = new NotifyContext(emailNotify);
        NotifyContext smsNotifyContext = new NotifyContext(smsNotify);
        NotifyContext pushNotifyContext = new NotifyContext(pushNotify);

        IList<NotifyContext> notifyContexts = new List<NotifyContext>()
        {
            emailNotifyContext,
            smsNotifyContext,
            pushNotifyContext
        };

        foreach(var notifyContext in notifyContexts)
        {
            notifyContext.Process();
        }

    }
}
*/

// ============================================================
//          INTERFACE SEGREGATION PRINCIPLE (ISP)
// ============================================================
//
// Instead of using one large INotify interface, we split it
// into smaller and more specific interfaces:
//
// ISend → Responsible only for sending notifications.
// ILog  → Responsible only for logging notifications.
// ISave → Responsible only for saving notifications to the DB.
//
// EmailNotify and SMSNotify need all three functionalities,
// so they implement ISend, ILog and ISave.
//
// PushNotify does not need DB saving, so it implements only
// ISend and ILog.
//
// This follows the Interface Segregation Principle (ISP):
//
// "A class should not be forced to implement methods that
//  it does not need."
//
// ============================================================

using System;
using System.Collections.Generic;

public interface ISend
{
    public void Send();
}

public interface ILog
{
    public void Log();
}

public interface ISave
{
    public void Save();
}

public class EmailNotify : ISend, ILog, ISave
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

public class SMSNotify : ISend, ILog, ISave
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

public class PushNotify : ISend, ILog
{
    public string Token { get; set; }
    public void Send()
    {
        Console.WriteLine("Sending Push to " + Token);
    }
     public void Log()
    {
        Console.WriteLine("Logging Push to " + Token);
    }

}

// NotifyContext receives separate interfaces instead of one
// large interface.
//
// This allows different notification types to provide only
// the functionalities they actually support.
//
// ISave can be null when the notification does not require
// database saving, such as PushNotify.
public class NotifyContext
{
    public ISend send { get; set; }
    public ILog log { get; set; }
    public ISave save { get; set; }
    public NotifyContext(ISend send, ILog log, ISave save)
    {
        this.send = send;
        this.log = log;
        this.save = save;
    }
    public void Process()
    {
        send.Send();
        log.Log();
        if(save!=null)
        {
            save.Save();
        }
    }
}

class Program
{
    public static void Main()
    {
        NotifyContext notifyContextEmail = new NotifyContext
        (
            new EmailNotify {Email = "test@example.com"},
            new EmailNotify {Email = "test@example.com"},
            new EmailNotify {Email = "test@example.com"}
        );

        NotifyContext notifyContextSMS = new NotifyContext
        (
            new SMSNotify {Phone = "01772454194"},
            new SMSNotify {Phone = "01772454194"},
            new SMSNotify {Phone = "01772454194"}
        );

        NotifyContext notifyContextPush = new NotifyContext
        (
            new PushNotify {Token = "38737374397"},
            new PushNotify {Token = "38737374397"},
            null
        );

        notifyContextEmail.Process();
        notifyContextSMS.Process();
        notifyContextPush.Process();
    }
}


