using System;
using System.Collections.Generic;

public class Program
{
  public static void Main()
  {
    Game game = new Game();
    game.Output();
  }
}

class Game
{
  // Computer starts at 50 since its between 1-100
  private int _guess;
  private int _count;
  private int _max;

  public Game()
  {
    _count = 0;
    _guess = 0;
    _max = 100;
  }

  private int Guess()
  {
    Console.WriteLine("My guess is: "+_guess);
    Console.WriteLine("Higher(0)/Lower(1)/Correct(2)");
    return int.Parse(Console.ReadLine());
  }

  public void Output()
  {
    bool guessing = true;
    int type = -1;
    while(guessing)
    {
      type = Guess();
      if(type == 0)
      {
        _guess +=  _max/(2+_count);
        _count++;
      }
      else if(type == 1)
      {
        _count++;
      }
      else if(type == 2)
      {
        Console.WriteLine("Correct Answer is: "+_guess);
        guessing = false;
      }
      else
      {
        //Error
      }
      if(_guess > 100 || _guess < 0)
      {
        Console.WriteLine("Guess out of bounds");
        guessing = false;
      }
    }
  }

}
