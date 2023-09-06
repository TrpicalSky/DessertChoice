using System;

class Program {
  static string[] choices = {"Rose water rice pudding","Tres Leches Cake", "Kulfi", "Bread Pudding", "Beignets "};
  public static void Main (string[] args) {
    bool choice = Dessert_Choice();

    if (choice) {
      Console.WriteLine("Awesome. I will grab you a dessert menu.");
      List_Desserts();
      Console.WriteLine("Type the number to get your dessert: ");
      int des = int.Parse(Console.ReadLine());
      Console.WriteLine($"Great choice I will go grab you {choices[des-1]}");
      
    } else {
      Console.WriteLine("No worries. I'll grab the check");
    }
  }

  public static bool Dessert_Choice() {
    Console.WriteLine("Would you like dessert?");
    string res = Console.ReadLine();
    if (res.ToLower() == "yes") {
      return true;
    } else {
      return false;
    }
  }

  public static void List_Desserts() {
    Console.WriteLine("The choices for desserts are as follows\n");
    for (int i = 0; i < choices.Length; i++) {
      Console.WriteLine($"{i+1}. {choices[i]}");
    }
    
  }
}
