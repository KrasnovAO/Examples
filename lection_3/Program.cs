// методы
// не возвращает и не принимает аргументы
//void Method1()
//{
//Console.WriteLine("Показываю метод");
//}
//Method1(); // вызываю метод


// не возвращает но принимают аргументы
//void Method2( string text )
//{
//    Console.WriteLine(text);
//}
//Method2("Привет");
//void Method21(int count, string text)
//{
//int i = 0;
//while (i < count)
//{
//Console.WriteLine(text);
//i++;
//}

//}
//Method21(count : 4, text :"Текст сообщения"); 


//что то возвращают но ничего не принимают
//int Method3()
//{
//  return DateTime.Now.Year;
//}
//Console.WriteLine(Method3());

// Что то принимают и что то возвращают

//string Method4(int count, string c)
//{
   // int i = 0;
    //string result = String.Empty;// пустая строка
   // while (i < count)
    //{
      //  result = result + c;
       // i++;
    //}
    //return result;
//}
//string res= Method4( 10 , "х");
//Console.WriteLine(res);

// цикл for
//string Method4(int count, string c)
//{
  //  string result = String.Empty;// пустая строка
    //for ( int i = 0; i< count; i++)
    //{
      //  result = result + c;
    //}
    //return result;
//}
//string res= Method4( 10 , "х");
//Console.WriteLine(res);

//цикл в цикле
//for ( int i = 2; i <= 10; i++)
//{
  //for ( int j = 2; j <= 10; j++)
    //{
      // Console.WriteLine($"{i}x{j}={i*j}");
    //}
     //Console.WriteLine();       
//}



 // string s = "qwerty"
 //             0123
 // s[3]=//r

 //string Replace(string text, char oldValue, char newValue)
 //{
   //string result = String.Empty;
   //int length = text.Length;
   //for ( int i = 0; i < length; i++)
   //{
     //if (text[i] == oldValue) result = result + $"{newValue}";
     //else result = result + $"{text[i]}";
   //}
   //return result;
 //}
 //string text = "— Я думаю, — сказал князь, улыбаясь, — что," 
  //          +"ежели бы вас послали вместо нашего милого" 
    //        +"Винценгероде, вы бы взяли приступом согласие "
      //      +"прусского короля. Вы так красноречивы. Вы" 
        //    +"дадите мне чаю?";
//string newText = Replace(text,' ','|');
//Console.WriteLine(newText);
//Console.WriteLine();

//newText = Replace(newText,'к','К');
//Console.WriteLine(newText);
//Console.WriteLine();

//newText = Replace(newText,'с','С');
//Console.WriteLine(newText);
//Console.WriteLine();

//алгоритм минимального, упорядочить массив от мин к макс

int[] arr = {1, 5, 4, 3, 2, 6, 7, 9, 1};
void Printarray(int[] array)
{
  int count = array.Length;
  for  ( int i = 0; i < count; i++)
  {
    Console.Write(" " + array[i]);
  
  }
  Console.WriteLine();
}

void SelectionSort(int[] array)
{
  for (int i = 0; i < array.Length - 1; i++)
  {
    int maxPosition = i;// приравниваем к первому элементу массива

    for (int j = i + 1; j < array.Length; j++)
    {
     if (array[j] > array[maxPosition]) maxPosition = j; // если 2 эл массива больше макс то в макс записываем этот элемент 
    }
    int temporary = array[i]; // временный элемент
    array[i] = array[maxPosition];// тот элемент который найдем
    array[maxPosition] = temporary;// в макс позицию ложим временный элемент
  }
}
Printarray(arr);
SelectionSort(arr);

Printarray(arr);


    

