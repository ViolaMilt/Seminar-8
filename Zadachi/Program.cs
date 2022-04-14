/*Задайте двумерный массив. Напишите программу,
 которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

int[,]newMas= {
    {9,6,3,1},
    {5,8,0,6},
    {7,3,4,1},
};

void ArraySorting()
{   int buff;
    for (int i =0;i< newMas.GetLength(0);i++)
    { 
        for (int k = 0; k< newMas.GetLength(1);k++)
        {
      
      
           for ( int j = 0; j < newMas.GetLength(1)-1;j++)
      {

         if (newMas[i,j] > newMas[i,j+1])
         {
             buff = newMas[i,j];
             newMas[i,j] =  newMas[i,j+1];
             newMas[i,j+1] = buff;
         }
      }
      }

    }
}

void PrintArray()
{
    string stroka;
for ( int i = 0; i<newMas.GetLength(0); i++)
  { stroka = "";
    for ( int j = 0; j < newMas.GetLength(1); j++)
    { 
        stroka = stroka + newMas[i,j];
      

    }
     Console.WriteLine (stroka);
  }
}

ArraySorting();
PrintArray();
 

 /* Задача 56: Задайте прямоугольный двумерный массив.
  Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

  int[,]newMassiv= {    
    {0,6,3,1},
    {5,8,1,6},
    {7,3,4,1},
};//Задаем массив

void FindMinRow ()
{
    int sum = 0; //Вводим переменную sum
    int[] arr = new int [newMassiv.GetLength(0)];//задаем массив arr,длина которого равна количеству строк двумерного массива newMas
    for (int i = 0; i< newMassiv.GetLength(0);i++)//перебираем массив newMas построчно(поэтажно)

    {  for (int j = 0; j< newMassiv.GetLength(1);j++) //пока ходим поэтажно, "заходим в каждую квартиру" = столбец
        {
           sum = sum + newMassiv[i,j];

        }
        arr[i] = sum;
        sum = 0;
    }
    int min = arr[0];
    int minIndex = 0;
    for (int z = 1; z<arr.Length;z++)
    {
        if (arr[z]<min)
        {
            min = arr[z];
            minIndex = z;

        }
         
    }
    Console.WriteLine(minIndex);
}

FindMinRow ();

/*Задача 58: Задайте две матрицы.
 Напишите программу, которая будет находить произведение двух матриц.*/

 

 int[,]massiv= {    
    {0,6,3},
    {5,8,1},
    {7,3,4},
};//Задаем массив 1

int[,]matrica= {    
    {1,6,3},
    {5,3,1},
    {7,3,1},

};//Задаем массив 2

Proizvedenie();

/*Умножаем каждую строку первой матицы
 на каждый столбец второй матрицы,затем складываем эти произведения*/
 

 void Proizvedenie ()
 {
     int[,]arrayItog = new int [massiv.GetLength(0),matrica.GetLength(1)];
     int sum = 0;
   for (int i = 0; i<massiv.GetLength(0);i++)
   {
     for (int m = 0; m<matrica.GetLength(1);m++)
     {
        for (int j = 0; j<massiv.GetLength(1);j++)
         {
          for (int k = 0; k<matrica.GetLength(0);k++)
           {
               sum = sum + massiv[i,j] * matrica [k,m];
               j= j+1;
               
           }

        arrayItog[i,m] = sum;
        sum = 0;
            
            
         }
        
      }
     
     }
        string stroka;
            for ( int n = 0; n<arrayItog.GetLength(0); n++)
              { stroka = "";
                for ( int z = 0; z < arrayItog.GetLength(1); z++)
                  { 
                    stroka = stroka + arrayItog[n,z];
    
                  }
                   Console.WriteLine (stroka);
              }

     
    }
  
  
  /*Задача 60 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
   которая построчно выведет элементы и их индексы.*/

    int m = 3;
   int n = 3;
   int z = 3;
   int [,,] trehArray = new int [m,n,z];

  

   void FillArray()
   {
        int r = 10;
      

       for (int i = 0; i< m; i++)
       {
           for ( int j = 0; j<n; j++)
           {
               for ( int k = 0; k<z; k++)
               {
                  trehArray [i,j,k] = r++;
               }
           }
       }
   }

   FillArray();
   

void PrintArray1()
         {
          string stroka;
         
            for ( int n = 0; n<trehArray.GetLength(0); n++)
              { stroka = "  ";
                for ( int z = 0; z < trehArray.GetLength(1); z++)
                  { 
                      for ( int q = 0; q < trehArray.GetLength(2); q++)
                      {
                        stroka = stroka + trehArray[n,z,q] + "(" + n + z + q + ")" + "  ";

                      } 
                  }  
                  Console.WriteLine( );  
                  Console.WriteLine(stroka);
                        
                  
              }
}
  PrintArray1();


//Задача 62: Заполните спирально массив 4 на 4 числами от 1 до 16.
int a = 4;
int b = 4;
int [,] spiralArray = new int [a,b];//задаем массив
void FillArray1() //заполняем его по часовой стрелке
   {
        int r = 10;
      

       for (int x = 0; x<b; x++)
       {
          spiralArray [0,x] =r;
           r++;
       }
       for (int y = 1; y<a; y++)
       {
          spiralArray [y,a-1] =r;
           r++;
       }
        for (int x = b-2; x>=0; x--)
       {
          spiralArray [a-1,x] =r;
           r++;
       }
        for (int y= a-2; y>0; y--)//?????
       {
          spiralArray [y,0] =r;
           r++;
       }
       //Указываем коодинаты точки, с которой начнем дальше заполнять

       int c = 1;
       int d = 1;

       //Инициализированный массив автоматически заполняется 0, поэтому мы можем написать следующий цикл

       //Движемся вправо

       while (spiralArray[c,d+1] == 0)
       {
          spiralArray [c,d] =r;
           r++;
           d++;
       }
       //движемся вниз

       while (spiralArray[c+1,d] == 0)
       {
          spiralArray [c,d] =r;
           r++;
           c++;

       }

       //движемся влево

       while (spiralArray[c-1,d] == 0)
       {
          spiralArray [c,d] =r;
           r++;
           c--;
       }

       //движемся вверх
       while (spiralArray[c,d-1] == 0)
       {
          spiralArray [c,d] =r;
           r++;
           d--;
       }
       //Заполняем последнюю незаполненную ячейку в центре

       for ( int x=0; x<b; x++)
       {
          for (int y = 0; y<a;y++)
          {
           if(spiralArray[x,y] ==0)
           {
             spiralArray[x,y] = r;
           }
          }
       }
   }

   FillArray1();

   void PrintArray2()
         {
          string stroka;
         
            for ( int n = 0; n<spiralArray.GetLength(0); n++)
              { stroka = "  ";
                for ( int z = 0; z < spiralArray.GetLength(1); z++)
                 
                      {
                        stroka = stroka + spiralArray[n,z] + "  ";
                       }  
                  Console.WriteLine( );  
                  Console.WriteLine(stroka);
              }
         }

         PrintArray2();

