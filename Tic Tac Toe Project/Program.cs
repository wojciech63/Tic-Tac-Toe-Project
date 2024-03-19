// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;

Game play = new Game();

play.Start();

public class Game
{
    private bool IsGameOn;
    
    public void Start()
    {
        Console.WriteLine("Welcome in Tic Tac Toe!");
        Line();
        Console.WriteLine("What would you like to do?");
        Line();
        Console.WriteLine("1. Start new game");
        Line();
        Console.WriteLine("2. About author");
        Line();
        Console.WriteLine("3. Exit");
        int firstchoice = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        switch (firstchoice)
        {
            case 1:
                NewGame();
                Console.Clear();
                break;
            case 2:
                AboutMe();
                Console.Clear();
                break;
            case 3:
                Exit();
                break;
            default:
                Console.WriteLine("Wrong choice. Please input valid number.");
                break;
        }
    }

    private void Line()
    {
        Console.WriteLine("-----------------------");
    }

    private void NewGame()
    {
        string[] XO = new string[9];
        for (int i = 0; i < XO.Length; i++)
        {
            XO[i] = " ";
        }
        IsGameOn = true;
        Console.WriteLine("Let the game Begin!");
        Board();
    }

    private void Board()
    {
        Console.WriteLine("   |   |   ");
        Console.WriteLine("---+---+---");
        Console.WriteLine("           ");
        Console.WriteLine("---+---+---");
        Console.WriteLine("   |   |   ");
    }

    private void AboutMe()
    {

    }

    private void Exit()
    {
        IsGameOn = false;
    }
}