using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Console.WriteLine("Insert secret message: ");
      string msg = Console.ReadLine();
      msg = msg.ToLower();
      char[] secretMessage = msg.ToCharArray();
     
      string encrypted = Encrypt(secretMessage, 3);
      Console.WriteLine(encrypted);

      string decrypted = Decrypt(encrypted.ToCharArray(),3);
      Console.WriteLine(decrypted);
    }


    static string Encrypt(char[] secretMessage, int key) 
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      char[] encryptedMessage = new char[secretMessage.Length];
      for (int i = 0; i < secretMessage.Length; i++){
        if (Char.IsLetter(secretMessage[i]))       {
        char letter = secretMessage[i];
        int position = Array.IndexOf(alphabet, letter);
       int add_three = (position + key) % 26;
       char newChar = alphabet[add_three];
       encryptedMessage[i]=newChar;
      }}
      return String.Join("",encryptedMessage);
      
    }


      static string Decrypt(char[] secretMessage, int key) 
      {
    
        char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

        char[] decryptedMessage = new char[secretMessage.Length];
        for (int i = 0; i < secretMessage.Length; i++){
          if (Char.IsLetter(secretMessage[i]))       {
          char letter = secretMessage[i];
          int position = Array.IndexOf(alphabet, letter);

         int decrease_three = (position - key) % 26;
         char newChar = alphabet[decrease_three];
         decryptedMessage[i]=newChar;
        }}
        return String.Join("",decryptedMessage);
       
    }


  }
}
