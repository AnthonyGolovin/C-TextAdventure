using System;
using System.Collections.Generic;
using TextGame.Game;

namespace TextGame {

  public class Program
  {
      public static void Main()
      {
          List<Item> ItemList = new List<Item>();
          Item newItem = new Item();
            Item.AddItem();
            newItem.OpenInventory();
          Console.WriteLine(""); //Tutorial Explanation LONGGGGGGGGGGGG
          Console.WriteLine("Would you like to begin your adventure?");
            string gameStart = Console.ReadLine();
          if (gameStart.ToLower() == "y")
          {
              
              Console.WriteLine("You start in room with a door and a hammer on the ground");//EXPOSITION
              Item.AddItem();
              bool playing = true;
              while (playing)
                    {
                    //Call a method here called somethhing Like "game" filled with all of 
                    //the other methods that contain player actions
                    
                    }
          }
          else if (gameStart == "n")
          {
                return;                   
          }
          else
          {
            Console.WriteLine("Please enter a valid answer EX.(y/n)");
            Main();
          }

        //   string startGame = Console.ReadLine(); //EXPOSITION

      }
  }
}