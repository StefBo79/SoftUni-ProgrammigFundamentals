using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> piecesComposer = new Dictionary<string, string>();  
            Dictionary<string, string> piecesKey = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                string piece = input[0];
                string composer = input[1];
                string key = input[2];

                piecesComposer.Add(piece, composer);
                piecesKey.Add(piece, key);                
            }

            string[] command = Console.ReadLine().Split("|");
            while (command[0] != "Stop")
            {
                
                string action = command[0];

                if (action == "Add")
                {
                    string piece = command[1];
                    string composer = command[2];
                    string key = command[3];

                    if (piecesComposer.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        piecesComposer.Add(piece, composer);
                        piecesKey.Add(piece, key);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                }

                if (action == "Remove")
                {
                    string piece = command[1];

                    if (piecesComposer.ContainsKey(piece))
                    {
                        piecesComposer.Remove(piece);
                        piecesKey.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

                if (action == "ChangeKey")
                {
                    string piece = command[1];
                    string newKey = command[2];

                    if (piecesKey.ContainsKey(piece))
                    {
                        piecesKey[piece] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }


                command = Console.ReadLine().Split("|");
            }

            piecesComposer = piecesComposer
                .OrderByDescending(d => d.Value)
                .ThenBy(c => c.Key)
                .ToDictionary(d => d.Key, d => d.Value);

            foreach (var piece in piecesComposer.OrderBy(p => p.Key).ThenBy(p => p.Value))
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value}, Key: {piecesKey[piece.Key]}");         
            }
        }
    }
}