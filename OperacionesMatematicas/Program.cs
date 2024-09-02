{
    
    { 
    int num1;
    int num2;
    int resSuma;
    int resResta;
    int resMulti;
    int resDiv;
    Console.WriteLine("Ingrese el primer numero");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero");
    num2 = Convert.ToInt32(Console.ReadLine());
    resSuma = num1 + num2;
    resResta = num1 - num2;
    resMulti = num1 * num2;
    resDiv = num1 / num2;
    Console.WriteLine("Suma: " + resSuma);
    Console.WriteLine("Resta: " + resResta);
    Console.WriteLine("Multiplicacion: " + resMulti);
    Console.WriteLine("Division: " + resDiv);
    Console.WriteLine();
}
}
