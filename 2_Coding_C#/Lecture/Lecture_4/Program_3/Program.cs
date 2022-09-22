﻿/*   0 0 0 1 1 0 0 0 0 0 1 1 0 0 0
     0 0 1 0 0 1 0 0 0 1 0 0 1 0 0
     0 1 0 0 0 0 1 0 1 0 0 0 0 1 0
     1 0 0 0 0 0 0 1 0 0 0 0 0 0 1
     1 0 0 0 0 0 0 0 0 0 0 0 0 0 1
     1 0 0 0 0 0 0 0 0 0 0 0 0 0 1
     0 1 0 0 0 0 0 0 0 0 0 0 0 1 0
     0 0 1 0 0 0 0 0 0 0 0 0 1 0 0
     0 0 0 1 0 0 0 0 0 0 0 1 0 0 0
     0 0 0 0 1 0 0 0 0 0 1 0 0 0 0
     0 0 0 0 0 1 0 0 0 1 0 0 0 0 0
     0 0 0 0 0 0 1 0 1 0 0 0 0 0 0
     0 0 0 0 0 0 0 1 0 0 0 0 0 0 0

    Для закрвшивания области

            | x-1,y |
      x,y-1 |  x,y  | x,y+1
            | x+1,y |
*/

int [,] love = new int [,]
{
     {0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0},
     {0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0},
     {0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0},
     {1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1},
     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
     {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
     {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
     {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
     {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
     {0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0},
     {0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0},
     {0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0},
};

void PrintImage (int [,] image)                           
{
    for (int i = 0; i < image.GetLength(0); i++)    
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image [i,j] == 0) Console.Write (" ");  
            else Console.Write ("*");  
        }
        Console.WriteLine();                       
    }
}

PrintImage (love);


void FillImage (int [,] matrix, int x, int y)                // метод закрашивает картинку (указать первую точку с которой будет закрашиваться)  
{
    if (matrix [x, y] == 0)
    {
        matrix [x, y] = 1;
        FillImage (matrix, x-1, y);                          // рекурсия - метод вызывает сам себя
        FillImage (matrix, x, y-1);
        FillImage (matrix, x+1, y); 
        FillImage (matrix, x, y+1);                             
    }
}

FillImage (love, 6, 6);
PrintImage (love);