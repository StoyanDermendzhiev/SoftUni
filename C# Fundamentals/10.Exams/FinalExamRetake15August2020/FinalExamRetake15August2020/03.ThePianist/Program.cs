using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ThePianist
{
    class Piece
    {
        public Piece(string composer, string key)
        {
            Composer = composer;
            Key = key;
        }

        public string Composer { get; set; }
        public string Key { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());

            Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] inputPiece = Console.ReadLine().Split("|");

                string pieceName = inputPiece[0];
                string composer = inputPiece[1];
                string key = inputPiece[2];

                Piece piece = new Piece(composer, key);

                pieces.Add(pieceName, piece);
            }

            string inputCommand = Console.ReadLine();

            while (inputCommand != "Stop")
            {
                string[] command = inputCommand.Split("|");

                string currentCommand = command[0];
                string pieceName = command[1];

                if (currentCommand == "Add")
                {
                    string composer = command[2];
                    string key = command[3];

                    if (pieces.ContainsKey(pieceName))
                    {
                        Console.WriteLine($"{pieceName} is already in the collection!");
                    }
                    else
                    {
                        Piece piece = new Piece(composer, key);
                        pieces.Add(pieceName, piece);

                        Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
                    }
                }
                else if (currentCommand == "Remove")
                {
                    if (pieces.ContainsKey(pieceName))
                    {
                        pieces.Remove(pieceName);

                        Console.WriteLine($"Successfully removed {pieceName}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }
                else if (currentCommand == "ChangeKey")
                {
                    string newKey = command[2];

                    if (pieces.ContainsKey(pieceName))
                    {
                        pieces[pieceName].Key = newKey;

                        Console.WriteLine($"Changed the key of {pieceName} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }

                inputCommand = Console.ReadLine();
            }

            foreach (var piece in pieces.OrderBy(x=>x.Key)
                                        .ThenBy(x=>x.Value.Composer))
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.Composer}, Key: {piece.Value.Key}");
            }
        }
    }
}
