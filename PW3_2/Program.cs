namespace PW3_2
{
    internal class Program
    {
        public class SmsMessage
        {
            private const int MaxSMSLength = 250;
            private const int MaxTaxedLength = 65;
            private const decimal BasePrice = 1.5m;
            private const decimal TaxPrice = 0.5m;

            private string messageText;
            private decimal price;

            public SmsMessage(string messageText)
            {
                MessageText = messageText;
                Price = CalculatePrice(messageText);
            }

            public string MessageText
            {
                get { return messageText; }
                set { messageText = value.Substring(0, Math.Min(value.Length, MaxSMSLength)); }
            }

            public decimal Price
            {
                get { return price; }
                set { price = value; }
            }

            public static SmsMessage CreateFromUserInput()
            {
                Console.WriteLine("Введите текст сообщения:");
                string messageText = Console.ReadLine();
                return new SmsMessage(messageText);
            }

            private static decimal CalculatePrice(string messageText)
            {
                int length = Math.Min(messageText.Length, MaxSMSLength);
                decimal price = BasePrice;

                if (length > MaxTaxedLength)
                {
                    int taxedLength = length - MaxTaxedLength;
                    price += taxedLength * TaxPrice;
                }

                return price;
            }
            public void ReturnValues()
            {
                Console.WriteLine(Price);
                Console.WriteLine(messageText);
            }
        }
        static void Main(string[] args)
        {
            SmsMessage otkritka = new SmsMessage("toster");
            otkritka.ReturnValues();

            SmsMessage bigmessage = new SmsMessage("Very big sms message idk what i need to write here but i write smth interesting but not here because here big nothing meaning text");
            bigmessage.ReturnValues();
        }
    }
}