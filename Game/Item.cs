//Player walks around a room with multiple objects that they can interact with in order to try to exit.
//Example game: Zork

using System;
using System.Collections.Generic;


namespace TextGame.Game {
//   class Game
//   {
//       //TBA should have all player actions might need to move inventory class into here?
//   }

  class Item
  {
      public string Spoon {get; set;} //Add maybe 5 Items EX. Key?
      public string Hammer {get; set;}
    
      public Item(string spoon, string hammer)
      {     
      Spoon = spoon;
      Hammer = hammer;
      }
      public string GetHammer()
      {
          return Hammer;
      }
      public void SetHammer(string newHammer)
      {
          Hammer = newHammer;
      }
      public string GetSpoon()
      {
          return Spoon;
      }
      public void SetSpoon(string newSpoon)
      {
          Spoon = newSpoon;
      }
    //   public string GetItem()
    //   {
          
    //   }

      
    public static List<string> AddItem() //Possibly change to interact?
    {
        List<string> ItemList = new List<string>();
        string pickUp = Console.ReadLine();//Check if you can rely on simply waiting or if you need a writeline before
        if (pickUp.ToLower() == "pick up")
        {
            Console.WriteLine("Would you like to add item to inventory? (Y/N)");
            string itemResponse = Console.ReadLine();
            if (itemResponse.ToLower() == "y")
            {
                Console.WriteLine("Item was added to inventory");
                ItemList.Add(itemResponse);
                return ItemList;

                // Item newItem = new Item();
            }
            else if (itemResponse.ToLower() == "n")
            {
                Console.WriteLine("Item was NOT added to inventory");
                return ItemList;
            }
            else
            {
            Console.WriteLine("Please enter a valid Response EX. 'y' or 'n'");
            return ItemList;
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid Command");
            return ItemList;
        }
    }
    public void OpenInventory()
    {
        string inventoryCheck = Console.ReadLine();
        if (inventoryCheck.ToLower() == "open inventory")
        {
            Console.WriteLine("These items are currently in your inventory:");// this looks like the wrong instance of inventory 
        }
    }
  }
  
}