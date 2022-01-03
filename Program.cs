
using System;

namespace StudyApp1
{
    public class TicTacToe
    {
        readonly char[][] fieldArray =
                { new char[]{ '0', '1', '2'},
                  new char[]{ '3', '4', '5' },
                  new char[]{ '6', '7', '8'} };
        private void PrintField()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(fieldArray[i][j] + "|");
                }
                Console.WriteLine();
            }
        }
        private void MakeMove()
        {
            Console.WriteLine("\nChoose the number of field cell");
            char fieldCellNumber = Program.ReadChar();
            Console.WriteLine("Choose the symbol 'X' or 'O'");
            char fieldCellSymbol = Program.ReadChar();
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (fieldArray[i][j] == fieldCellNumber)
                        fieldArray[i][j] = fieldCellSymbol;
                }
            }
        }
        private bool IsOver()
        {
            if (fieldArray[0][0] == fieldArray[0][1] && fieldArray[0][1] == fieldArray[0][2] ||
                fieldArray[1][0] == fieldArray[1][1] && fieldArray[1][1] == fieldArray[1][2] ||
                fieldArray[2][0] == fieldArray[2][1] && fieldArray[2][1] == fieldArray[2][2] ||
                fieldArray[0][0] == fieldArray[1][0] && fieldArray[1][0] == fieldArray[2][0] ||
                fieldArray[0][1] == fieldArray[1][1] && fieldArray[1][1] == fieldArray[2][1] ||
                fieldArray[0][2] == fieldArray[1][2] && fieldArray[1][2] == fieldArray[2][2] ||
                fieldArray[0][0] == fieldArray[1][1] && fieldArray[1][1] == fieldArray[2][2] ||
                fieldArray[0][2] == fieldArray[1][1] && fieldArray[1][1] == fieldArray[2][0])
                    return true;
            else return false;
        }
        public void Play()
        {
            while (this.IsOver() == false)
            {
                PrintField();
                MakeMove();
            }
            Console.WriteLine("Game Over!");
            PrintField();
            Console.Read();
        }
    }
    class Program
    {
        static void Main()
        {
            var game = new TicTacToe();
            game.Play();
        }
        public static char ReadChar()
        {
            char value;
            try
            {
                value = char.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("You has not written a correct symbol");
                return ReadChar();
            }
            return value;
        }
    } 
}
