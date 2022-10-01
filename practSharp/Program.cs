// 6.1
// В строке заменить все символы-цифры на символ * и распечатать обновленную строку.

//string inString = "1d2d4jk467k6j7";

//string noNum = "";

//for (int i = 0; i < inString.Length; i++)
//{
//    if (inString[i] >= 48 && inString[i] <= 57)
//    {
//        noNum += '*';
//    }
//    else
//    {
//        noNum += inString[i];
//    }
//}

//Console.WriteLine(noNum);

//// ниже - авторское, вне задания , со звездочкой

//string noAlb = "";

//for (int i = 0; i < inString.Length; i++)
//{
//    if (inString[i] >= 'a' && inString[i] <= 'z')
//    {
//        noAlb += '*';
//    }
//    else
//    {
//        noAlb += inString[i];
//    }
//}

//Console.WriteLine(noAlb);


//--------------------------------------------------------------------------------------


//  6.2

// Проверить, является ли строка записью целого числа (все входящие символы являются цифрами). 
//Console.WriteLine("Введите:");
//string inUser = Console.ReadLine(); // добавить введние от юзера

//var count = 0;

//for (int i = 0; i < inUser.Length; i++)
//{
//    if (inUser[i] >= 48 && inUser[i] <= 57)
//    {
//        count++;
//    }
//}

//if (count == inUser.Length)
//{
//    Console.WriteLine("Строка записью целого числа. Все символы - цифры");
//}
//else
//{
//    Console.WriteLine("В строке не все символы являются цифрами");
//}


//--------------------------------------------------------------------------------------


//  6.3
// Проверить, является ли строка записью вещественного числа (все входящие символы,
// кроме одного, являются цифрами и один символ – «.»). 

//Console.WriteLine("Введите дробное число:");
//string sUser = Console.ReadLine();

//var count = 0;
//var point = 0;

//for (int i = 0; i < sUser.Length; i++)
//{
//    if (sUser[i] >= 48 && sUser[i] <= 57)
//    {
//        count++;
//    }
//    if (sUser[i] == 46 || sUser[i] == 44)
//    {
//        point++;
//    }
//}

//if (count == sUser.Length-1 && point == 1)
//{
//    Console.WriteLine("Строка является записью вещественного числа");
//}
//else
//{
//    Console.WriteLine("Не дробное число или лишний символ");
//}


//--------------------------------------------------------------------------------------


//  6.4
// Посчитать количество гласных букв в строке.

//Console.WriteLine("Введите слово на Русском:");
//string word = Console.ReadLine();

//var count = 0;

//for (int i = 0; i < word.Length; i++)
//{
//    if (word[i] == 'a' || word[i] == 'y' || word[i] == 'о' 
//        || word[i] == 'и' || word[i] == 'э' || word[i] == 'ы')
//    {
//        count++;
//    }
//}
//Console.WriteLine($"Количество гласных букв в слове = {count}");

//----

//Console.WriteLine("Введите слово in english:");
//string word = Console.ReadLine();
//var wordLower = word.ToLower();

//char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };

//var count = 0;

//foreach (var i in wordLower)
//{
//    foreach (var j in vowels)
//    {
//        if (i == j)
//        {
//            count++;
//        }
//    }
//}
//Console.WriteLine($"Количество гласных в этом слове = {count}");



//-------------------------------------------------------------------------------------- доделать посл условие

//  6.5
// Посчитать количество ошибок в предложении (правила: первая – заглавная,
// последняя – точка, после точек внутри строки стоит заглавная буква).

//string userStr = "Из под топата. Копыт пыль. Но полю. Не по полю.";

////Console.WriteLine("Введите предложение: (RUS)");
////string userStr = Console.ReadLine();

//var countError = 0;
//var lastSim = userStr[userStr.Length - 1];

//if (userStr[0] >= 'А' && userStr[0] <= 'Я')
//{
//    Console.WriteLine();
//}
//else if (userStr[0] >= 'а' && userStr[0] <= 'я')
//{
//    countError++;
//}

//if (lastSim != '.')
//{
//    countError++;
//}

//// должно быть " " и апер символ после каждой точки
//// иф элемент символа пробле итая + стринг итая - проверка на большую бувку
//// количество больших букву = количеству точек и пробелов
//var space = userStr[0];
//var srtingAfterSpace = userStr[0];

//for (int i = 0; i < userStr.Length; i++)
//{
//    if (i == ' ')
//    {
//        space++;
//        //srtingAfterSpace = userStr[i] + 1;
//    }
//}

//Console.WriteLine(space);
//Console.WriteLine(srtingAfterSpace); // delete
//Console.WriteLine(userStr);
//Console.WriteLine();
//Console.WriteLine($"Количество ошибок в тексте = {countError}");

////Console.WriteLine($"запрос пробелов: upper: {albUpper} , point {point}");


//-------------------------------------------------------------------------------------- 


//  6.6
// Посчитать сумму цифр в строке. 

//Console.WriteLine("Введите строку (буквы, цифры):");
//string numAndChar = Console.ReadLine();
//string nums = "";

//for (int i = 0; i < numAndChar.Length; i++)
//{
//    if (numAndChar[i] >= 48 && numAndChar[i] <= 57)
//    {
//        nums += numAndChar[i];
//    }
//}

//int sum = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    sum += Convert.ToInt32(nums[i].ToString()); 
//}

//Console.WriteLine(sum);


//--------------------------------------------------------------------------------------


//  6.7
// Найти максимальную цифру в строке.

//Console.WriteLine("Введите строку чисел:");
//string s = Console.ReadLine(); ;

//var max = 0;

//for (int i = 0; i < s.Length; i++)
//{
//    if (s[i] > max)
//    {
//        max = s[i];
//    }
//}

//var convertMax = Convert.ToChar(max);

//Console.WriteLine($"максимальная цифра в строке {convertMax}");


//--------------------------------------------------------------------------------------


//  6.8
// Распечатать таблицу кодов букв латинского алфавита (малые, потом заглавные).

//char star = 'A'; 
//char end = 'z';

//for (int i = end; i >= star; i--)
//{
//    if (i >= 65 && i <= 90)
//    {
//        Console.WriteLine($"символ: {Convert.ToChar(i)}, его код {i}");
//    }
//    if (i >= 97 && i <= 122)
//    {
//        Console.WriteLine($"символ: {Convert.ToChar(i)}, его код {i}");
//    }
//}


//--------------------------------------------------------------------------------------


// 6.9
// В строке заменить все малые буквы на заглавные, заглавные на малые.

//Console.WriteLine("Введите строку из заглавных и строчных букв:");
//string s = Console.ReadLine();
//string sConvert = "";

//for (int i = 0; i < s.Length; i++)
//{
//    if (s[i] >= 65 && s[i] <= 90) // if big
//    {
//        sConvert += s[i].ToString().ToLower(); 
//    }
//    if (s[i] >= 92 && s[i] <= 122) // if small
//    {
//        sConvert += s[i].ToString().ToUpper();
//    }
//    else
//    {
//        sConvert += s[i];
//    }
//}

//Console.WriteLine("Конвертированаая строка:");
//Console.WriteLine(sConvert);


//--------------------------------------------------------------------------------------


//  6.10
// Сравнить 2 строки, не используя стандартную функцию.

//string s1 = "Djinajka";
//string s2 = "Djina";

//var count = 0;

//if (s1.Length == s2.Length)
//{
//    for (int i = 0; i < s1.Length; i++)
//    {
//        if (s1[i] == s2[i])
//        {
//            count++;
//        }
//    }
//}

//if (count == s1.Length)
//{
//    Console.WriteLine("Строки равны");
//}
//else
//{
//    Console.WriteLine("Строки не равны");
//}


//--------------------------------------------------------------------------------------


// 6.11

// Посчитать баланс круглых скобок в тексте (количество закрывающихся равно количеству открывающихся,
// при этом следить, чтобы закрывающаяся скобка шла после открывающейся).

//string s = "((string)))";

//bool left = false; 
//bool right = false;

//var countLeft = 0;
//var countRight = 0;

//for (int i = 0; i < s.Length; i++)
//{
//    if (s[i] == '(')
//    {
//        countLeft++;
//    }
//    if (s[i] == ')')
//    {
//        countRight++;
//    }
//}
//Console.WriteLine();
//Console.WriteLine(s);
//Console.WriteLine();
//Console.WriteLine($"\nЛевых скобок {countLeft}, Правых скобок: {countRight}");
//Console.WriteLine();

//for (int i = 0; i < s.Length; i++)
//{
//    if (s[i] == '(')
//    {
//        left = true;
//    }
//    if (s[i] == ')')
//    {
//        right = true;
//    }
//}
//Console.WriteLine();
//if (left == true && right == true && countLeft == countRight)
//{
//    Console.WriteLine("закрывающаяся скобка идет после открывающейся, Количество скобок левых и правых равно");
//}
//else
//{
//    Console.WriteLine("закрывающаяся скобка НЕ идет после открывающейся, Количество скобок не равно");
//}


//--------------------------------------------------------------------------------------


//  6.12
// *Перевести число в двоичную систему счисления, используя для представления двоичного кода строку.

//string s = "9"; // 1001
//var sInt = Convert.ToInt16(s);
//var tmp = sInt;
//int lenght = 0;

//Console.WriteLine(s);

//while (sInt != 0)
//{
//    sInt /= 2;
//    lenght++;
//}

//sInt = tmp;

//int[] array = new int [lenght];

//for (int i = array.Length-1; i >= 0; i--)
//{
//    if (sInt % 2 == 0)
//    {
//        array[i] = 0;
//	}
//    else
//    {
//        array[i] = 1;
//    }
//    sInt /= 2;
//}
//Console.WriteLine("В двоичной системе счисления:");

//foreach (var i in array)
//{
//    Console.Write(i);
//}


//-------------------------------------------------------------------------------------- ДОДЕЛАТЬ
// ищет и удалаяте только один символ, остльные не видит


// 6.13
// *Удалить искомый символ.
//Console.WriteLine("Введите один любой символ:");
//char sUser = Convert.ToChar(Console.ReadLine());
//string sentens = "\nНа дворе трава, на траве дрова. Grass in the yard, firewood on the grass!";
//var count = 0;
//string delString = "";

//if (sUser >= 32 && sUser <= 255)
//{
//    Console.WriteLine($"{sUser} {code(sUser)}");

//    for (int i = 0; i < sentens.Length; i++)
//    {
//        if (sUser == sentens[i])
//        {
//           count++;
//        }
//        if (sUser != sentens[i])
//        {
//            delString += sentens[i];
//        }
//    }
//}

//Console.WriteLine(sentens);
//Console.WriteLine();

//if (count == 1)
//{
//    Console.WriteLine($"\nЕсть такая буква {sUser}");
//    Console.WriteLine($"\nКонвертированная строка \n{delString}");
//}
//else
//{
//    Console.WriteLine("\nНет такого символа");
//}


//-------------------------------------------------------------------------------------- ДОДЕЛАТЬ


// 6.14
// *Вставить перед заглавной буквой точку (кроме первой).

//string sentense = "Mother of god Mother of God";
//string newSent = "";

//int [] arrayBigAlfabet = new int [] { };

//for (int i = 0; i < sentense.Length; i++)
//{
//    if (sentense[i] >= 65 && sentense[i] <= 90)
//    {
//        Console.WriteLine(i);
//        arrayBigAlfabet += i;
//    }
    
//}
// если в массиве есть большие буквы , то условие что и-1 будет собираться в новой строке стока с точкой.