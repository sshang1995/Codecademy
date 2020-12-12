using System;

namespace DatingProfile
{ 
  class Profile
  {
    private string name;
    private int age;
    public int Age
    {
      get{return age;}
      set{
        if (Age > 18) {
        this.age = Age;
      }
    }
    }
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;
    
    public Profile(string name, int age, string city ="n/a", string country="n/a", string pronouns="they/them")
    {
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
      this.hobbies = new string[0];

    }

   

    public string ViewProfile()
    {
      string bio = $"name:{name}\n age:{age}\n city:{city}\n country:{country}\n pronouns:{pronouns}\n hobbies: \n";
      if (hobbies.Length > 0)
      {
        foreach (string hobby in hobbies)
        {
        bio += $"-{hobby} \n";
        }
      }
      
      return bio;
    }

    public void SetHobbies(string[] hobbies){
      this.hobbies = hobbies;

    }

  }
}
