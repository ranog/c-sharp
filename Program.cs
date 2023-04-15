void Dividir(int num1, int num2){
    try{
        var result = num1 / num2;
        Console.WriteLine(result);
    }
    catch(NotImplementedException ex){
        Console.WriteLine($"Não é possivel efetuar a divisão: {ex.Message}");
    }
    catch(DivideByZeroException ex){
        Console.WriteLine($"Não é possivel efetuar a divisão: {ex.Message}");
    }
}

Dividir(5, 0);
