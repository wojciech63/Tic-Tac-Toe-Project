// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Numerics;
using System.Threading.Channels;

Game play = new Game();

play.Start();

public class Game
{
    private bool IsGameOn;
    private int ChoosePlayer;
    private string[] XO = new string[9];
    private int scoreO;
    private int scoreX;

    public void Start()
    {
        Console.WriteLine("Welcome in Tic Tac Toe!");
        Console.WriteLine("What would you like to do?");
        Line();
        Console.WriteLine("1. Start new game");
        Line();
        Console.WriteLine("2. About author");
        Line();
        Console.WriteLine("3. Scoreboard");
        Line();
        Console.WriteLine("4. Exit");
        Line();
        Console.WriteLine();
        Console.WriteLine("What's your choice?");
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
                Scoreboard();
                Console.Clear();
                break;
            case 4:
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

    private void NewGame()  // Tic Tac Toe game
    {
        IsGameOn = true;
        for (int i = 0; i < XO.Length; i++) 
        {
            XO[i] = " ";
        }
        Console.WriteLine("Let the game Begin!");

        for (int j = 0; j < 9; j++)
        {
            ChoosePlayer = j % 2; // Condition that switches turns between X and O
            if (ChoosePlayer == 0)
            {
                Console.Clear();
                Board();
                Console.WriteLine("X's turn");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice >= 1 && choice <= 9 && XO[choice - 1] == " ")
                {
                    XO[choice - 1] = "X";
                }
                else
                {
                    Console.WriteLine("Wrong move!");
                    j -= 1;
                }
                if (XO[0] == "X" && XO[0] == XO[1] && XO[1] == XO[2] && XO[0] != " " && XO[1] != " " && XO[2] != " ")  // Winning Conditions
                {
                    Xwon();
                }
                else if (XO[3] == "X" && XO[3] == XO[4] && XO[4] == XO[5] && XO[3] != " " && XO[4] != " " && XO[5] != " ")
                {
                    Xwon();
                }
                else if (XO[6] == "X" && XO[6] == XO[7] && XO[7] == XO[8] && XO[6] != " " && XO[7] != " " && XO[8] != " ")
                {
                    Xwon();
                }
                else if (XO[0] == "X" && XO[0] == XO[3] && XO[3] == XO[6] && XO[0] != " " && XO[3] != " " && XO[6] != " ")
                {
                    Xwon();
                }
                else if (XO[1] == "X" && XO[1] == XO[4] && XO[4] == XO[7] && XO[1] != " " && XO[4] != " " && XO[7] != " ")
                {
                    Xwon();
                }
                else if (XO[2] == "X" && XO[2] == XO[5] && XO[5] == XO[8] && XO[2] != " " && XO[5] != " " && XO[8] != " ")
                {
                    Xwon();
                }
                else if (XO[0] == "X" && XO[0] == XO[4] && XO[4] == XO[8] && XO[0] != " " && XO[4] != " " && XO[8] != " ")
                {
                    Xwon();
                }
                else if (XO[2] == "X" && XO[2] == XO[4] && XO[4] == XO[6] && XO[2] != " " && XO[4] != " " && XO[6] != " ")
                {
                    Xwon();
                }
            }
            else
            {
                Console.Clear();
                Board();                
                Console.WriteLine("O's turn");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice >= 1 && choice <= 9 && XO[choice - 1] == " ")
                {
                    XO[choice - 1] = "O";
                }
                else
                {
                    Console.WriteLine("Wrong move!");
                    j -= 1;
                }
                if (XO[0] == "O" && XO[0] == XO[1] && XO[1] == XO[2] && XO[0] != " " && XO[1] != " " && XO[2] != " ")  // Winning Conditions
                {
                    Owon();
                }
                else if (XO[3] == "O" && XO[3] == XO[4] && XO[4] == XO[5] && XO[3] != " " && XO[4] != " " && XO[5] != " ")
                {
                    Owon();
                }
                else if (XO[6] == "O" && XO[6] == XO[7] && XO[7] == XO[8] && XO[6] != " " && XO[7] != " " && XO[8] != " ")
                {
                    Owon();
                }
                else if (XO[0] == "O" && XO[0] == XO[3] && XO[3] == XO[6] && XO[0] != " " && XO[3] != " " && XO[6] != " ")
                {
                    Owon();
                }
                else if (XO[1] == "O" && XO[1] == XO[4] && XO[4] == XO[7] && XO[1] != " " && XO[4] != " " && XO[7] != " ")
                {
                    Owon();
                }
                else if (XO[2] == "O" && XO[2] == XO[5] && XO[5] == XO[8] && XO[2] != " " && XO[5] != " " && XO[8] != " ")
                {
                    Owon();
                }
                else if (XO[0] == "O" && XO[0] == XO[4] && XO[4] == XO[8] && XO[0] != " " && XO[4] != " " && XO[8] != " ")
                {
                    Owon();
                }
                else if (XO[2] == "O" && XO[2] == XO[4] && XO[4] == XO[6] && XO[2] != " " && XO[4] != " " && XO[6] != " ")
                {
                    Owon();
                }
            }
        }

    }
    private void Board()
    {
        Console.WriteLine($" {XO[0]} | {XO[1]} | {XO[2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {XO[3]}   {XO[4]}  {XO[5]}  ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {XO[6]} | {XO[7]} | {XO[8]} ");
    }

    private void AboutMe()
    {
        Console.WriteLine("Author is Wojciech Dąbrowski, 1st year CS Student");
        Console.WriteLine("Click any button to continue");
        Console.ReadLine();
        Console.Clear();
        Start();
    }

    private void Exit()
    {
        Environment.Exit(0);
    }

    private void Xwon()
    {
        Console.Clear();
        Board();
        Console.WriteLine("X Won!");
        Console.ReadLine();
        scoreX += 1;
        Console.Clear();
        Start();
    }
    
    private void Owon()
    {
        Console.Clear();
        Board();
        Console.WriteLine("X Won!");
        Console.ReadLine();
        scoreO += 1;
        Console.Clear();
        Start();
    }

    private void Scoreboard()
    {
        Console.Clear();
        Console.WriteLine($"Score X: {scoreX}");
        Console.WriteLine($"Score O: {scoreO}");
        Console.WriteLine("Press any button to continue");
        Console.ReadLine();
        Console.Clear();
        Start();
    }
}