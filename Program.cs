using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile sam = new Profile("Same Drakkila", 30, "New York");
       string[] hobbies = new string[] {"listening to audiobooks and podcasts",
 "playing rec sports like bowling and kickball",
 "writing a speculative fiction novel",
 "reading advice columns"};
       sam.SetHobbies(hobbies);
      Console.WriteLine(sam.ViewProfile());
      

    }
  }
}
