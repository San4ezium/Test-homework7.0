// See https://aka.ms/new-console-template for more information
char c1 = '1', c2 = '2', c3 = '3';
char c4 = '4', c5 = '5', c6 = '6';
char c7 = '7', c8 = '8', c9 = '9';
char player = 'X';

for (int move = 0; move < 9; move++)
{
    Console.Clear();
    Console.WriteLine(
        $" {c1} | {c2} | {c3}\n" +
        "---+---+---\n" +
        $" {c4} | {c5} | {c6}\n" +
        "---+---+---\n" +
        $" {c7} | {c8} | {c9}"
    );

    Console.Write("Player " + player + ", select a cell (1-9): ");
    string input = Console.ReadLine();
    int cell;
    if (!int.TryParse(input, out cell) || cell < 1 || cell > 9)
    {
        Console.WriteLine(" Invalid number. Enter...");
        Console.ReadLine();
        move--;
        continue;
    }

    bool ok = false;
    if (cell == 1 && c1 != 'X' && c1 != 'O') { c1 = player; ok = true; }
    else if (cell == 2 && c2 != 'X' && c2 != 'O') { c2 = player; ok = true; }
    else if (cell == 3 && c3 != 'X' && c3 != 'O') { c3 = player; ok = true; }
    else if (cell == 4 && c4 != 'X' && c4 != 'O') { c4 = player; ok = true; }
    else if (cell == 5 && c5 != 'X' && c5 != 'O') { c5 = player; ok = true; }
    else if (cell == 6 && c6 != 'X' && c6 != 'O') { c6 = player; ok = true; }
    else if (cell == 7 && c7 != 'X' && c7 != 'O') { c7 = player; ok = true; }
    else if (cell == 8 && c8 != 'X' && c8 != 'O') { c8 = player; ok = true; }
    else if (cell == 9 && c9 != 'X' && c9 != 'O') { c9 = player; ok = true; }

    if (!ok)
    {
        Console.WriteLine("⛔ Busy. Enter...");
        Console.ReadLine();
        move--;
        continue;
    }

    bool win =
        (c1 == player && c2 == player && c3 == player) ||
        (c4 == player && c5 == player && c6 == player) ||
        (c7 == player && c8 == player && c9 == player) ||
        (c1 == player && c4 == player && c7 == player) ||
        (c2 == player && c5 == player && c8 == player) ||
        (c3 == player && c6 == player && c9 == player) ||
        (c1 == player && c5 == player && c9 == player) ||
        (c3 == player && c5 == player && c7 == player);

    if (win)
    {
        Console.Clear();
        Console.WriteLine(
            $" {c1} | {c2} | {c3}\n" +
            "---+---+---\n" +
            $" {c4} | {c5} | {c6}\n" +
            "---+---+---\n" +
            $" {c7} | {c8} | {c9}"
        );
        Console.WriteLine(" Victory: player " + player);
        Console.ReadLine();
        return 1;
    }

    player = (player == 'X') ? 'O' : 'X';
}

Console.Clear();
Console.WriteLine(
    $" {c1} | {c2} | {c3}\n" +
    "---+---+---\n" +
    $" {c4} | {c5} | {c6}\n" +
    "---+---+---\n" +
    $" {c7} | {c8} | {c9}"
);
Console.WriteLine(" Draw!");
Console.ReadLine();
return 0;