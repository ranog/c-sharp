var i = 1;
while (i <= 10)
{
    var j = 1;
    while (j <= 10)
    {
        if (j == 7 || j == 8 || j == 9)
        {
            j++;
            //continue;
            break;
        }
        Console.WriteLine($"{i} * {j} = {i * j}");
        j++;
    }
    i++;
}