// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)


Console.Write("Введите размер масива ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число ");
int max = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

void AddMass(int minN, int maxN, int[] arrNew){

    Random ran = new Random();
    for(int i = 0; i < arrNew.Length; i++){
        arrNew[i] = ran.Next(minN, maxN);
    }
}

void PrintMass(int[] arrPrint){
    for(int i = 0; i<arrPrint.Length; i++){
        Console.Write($"{arrPrint[i]} ");
    }
}

void Reserv(int[] arrRes){

    int nNew = arrRes.Length;
    int[] arrResTemp = new int[nNew];

    for (int i = 0; i < arrRes.Length; i++){
        arrResTemp[nNew - 1 - i] = arrRes[i];
    }

    for(int j = 0; j < arrRes.Length; j++){
        arrRes[j] = arrResTemp[j];
    }
}

AddMass(min, max, arr);
PrintMass(arr);
Console.WriteLine();
Reserv(arr);
PrintMass(arr);