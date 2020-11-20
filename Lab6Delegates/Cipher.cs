using System;
namespace Lab6Delegates
{
    delegate string CipherText(string message);

    public class Cipher
    {
        public string PlainText { get; set; }

        public Cipher()
        {
        }

        public string ShiftUpCharacters(string message)
        {
            PlainText = message;
            string shiftedUpMessaged = "";
            int index = PlainText.Length - 1;
            int indexCounter = index;

            shiftedUpMessaged += PlainText[index];

            while (indexCounter > 0)
            {
                shiftedUpMessaged += PlainText[index - indexCounter];
                indexCounter--;
            }

            return shiftedUpMessaged;
        }

        public void ReverseMessage(string message)
        {
            CipherText del = ShiftUpCharacters;
            char[] reversedMsg = del(message).ToCharArray();
            Array.Reverse(reversedMsg);
            Console.WriteLine(reversedMsg);
        }


        static void Main(string[] args)
        {
            Cipher cp = new Cipher();
            cp.ReverseMessage("Test");
        }
    }
}
