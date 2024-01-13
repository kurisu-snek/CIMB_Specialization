using System;

public class charpyramid
{
    public static void Main()
    {
        int levels = 5;
        char startLetter = 'a';

        for (int row = 1; row <= levels; row++)
        {
            // Print leading spaces for alignment
            for (int i = 1; i <= levels - row; i++)
            {
                Console.Write("  ");
            }

            // Print the characters for the current row
            for (char letter = startLetter; letter <= startLetter + row - 1; letter++)
            {
                Console.Write(letter + " ");
            }

            // Print the characters in reverse order
            for (int i = row - 2; i >= 0; i--)
            {
                Console.Write((char)(startLetter + i) + " ");
            }

            Console.WriteLine(); // Move to the next line
        }
    }
}
