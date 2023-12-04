// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.

Console.Write("Введите размер масива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

void AddMass(int[] arrNew){

    Random ran = new Random();
    for(int i = 0; i < arrNew.Length; i++){
        arrNew[i] = ran.Next(100, 999);
    }
}

void PrintMass(int[] arrPrint){
    for(int i = 0; i<arrPrint.Length; i++){
        Console.Write($"{arrPrint[i]} ");
    }
}

void Result(int[] arrRes){
    
    int collect = 0;
    foreach (int item in arrRes)
    {
        if(item % 2 ==0) collect++;
    }
    Console.WriteLine(collect);
}


AddMass(arr);
PrintMass(arr);
Console.WriteLine();
Result(arr);