﻿int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

// int a1 = 112125;         //Переписываем в массив
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 2311;
// int c2 = 33;
// int a3 = 15;
// int b3 = 23111;
// int c3 = 313;

int [] array = {112125, 21, 39, 12, 2311, 33, 15, 23111, 313};

// int max = Max  (Max (a1, b1, c1),  //Уходим от переменных к массиву
//                 Max (a2, b2, c2),
//                 Max (a3, b3, c3)
//                 );

//Console.WriteLine (max);

int max = Max (Max (array[0], array[1], array[2]),
               Max (array[3], array[4], array[5]),
               Max (array[6], array[7], array[8])
               );

Console.WriteLine (max);
