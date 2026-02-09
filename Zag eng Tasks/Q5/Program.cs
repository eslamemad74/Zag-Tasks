namespace Q5
{
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {

        }
    }
    class PaymentTimeoutException : Exception
    {
       public PaymentTimeoutException(string message) : base(message)
       {

       }
    }

     internal class Program
     {
        static void Main(string[] args)
        {
           try
           {
                    
              MakePayment(100, 150);
           }
           catch (InsufficientBalanceException ex)
           {
              Console.WriteLine("Balance Error: " + ex.Message);
           }
           catch (PaymentTimeoutException ex)
           {
              Console.WriteLine("Timeout Error: " + ex.Message);
           }
           catch (Exception ex)
           {
              Console.WriteLine("General Error: " + ex.Message);
           }
           finally
           {
              Console.WriteLine("Payment process finished");
           }
        }

         static void MakePayment(int balance, int amount)
         {
            if (balance < amount)
            {
              throw new InsufficientBalanceException("Not enough balance");
            }

            bool timeout = true;

            if (timeout)
            {
                throw new PaymentTimeoutException("Payment took too long");
            }

            Console.WriteLine("Payment successful");
         }
     }
}
  