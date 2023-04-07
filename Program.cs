var i = 1;

while (i <= 10)
{
    var j = 1;
    while (j <= 10)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
        j++;
    }

    i++;
}