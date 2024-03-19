// See https://aka.ms/new-console-template for more information

using System.Numerics;
using System.Threading.Channels;

Game play = new Game();

play.Start();

public class Game
{
    private bool IsGameOn;
    private int ChoosePlayer;


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
        IsGameOn = true;
        
        string[] XO = new string[9];
        
        for (int i = 0; i < XO.Length; i++)
        {
            XO[i] = " ";
        }
        Console.WriteLine("Let the game Begin!");

        for (int j = 0; j < 9; j++)
        {
            ChoosePlayer = j % 2;
            if (ChoosePlayer == 0)
            {
                Console.WriteLine("X's turn");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice >= 1 && choice <= 9 && XO[choice - 1] == " ")
                {
                    XO[choice - 1] = "X";
                    Console.WriteLine($" {XO[0]} | {XO[1]} | {XO[2]} ");
                    Console.WriteLine("---+---+---");
                    Console.WriteLine($" {XO[3]}   {XO[4]}  {XO[5]}  ");
                    Console.WriteLine("---+---+---");
                    Console.WriteLine($" {XO[6]} | {XO[7]} | {XO[8]} ");
                }
                else
                {
                    Console.WriteLine("Wrong move!");
                    j -= 1;
                }
            }
            else
            {
                Console.WriteLine("O's turn");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice >= 1 && choice <= 9 && XO[choice - 1] == " ")
                {
                    XO[choice - 1] = "O";
                    Console.WriteLine($" {XO[0]} | {XO[1]} | {XO[2]} ");
                    Console.WriteLine("---+---+---");
                    Console.WriteLine($" {XO[3]}   {XO[4]}  {XO[5]}  ");
                    Console.WriteLine("---+---+---");
                    Console.WriteLine($" {XO[6]} | {XO[7]} | {XO[8]} ");
                }
                else
                {
                    Console.WriteLine("Wrong move!");
                    j -= 1;
                }
            }
        }

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