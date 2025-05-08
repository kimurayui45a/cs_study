

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//変数の宣言
//using System.Reflection.Metadata.Ecma335;
using System.Linq;


///XMLドキュメントコメント
///プログラムには無視されるが、ドキュメント生成やツールチップに使われる特別なコメント
///コードに仕様説明を埋め込める
///IDEでマウスホバーすると説明が表示される
///XML形式でドキュメントファイル（.xml）として出力可能（→API仕様書として使える


int money;      // 所持金
string name;    // 所持金

money = 5000;
name = "きたむら";

Console.WriteLine(money);
Console.WriteLine(name);


//int sum = 0;

//sum = 1 + 2 + 3 + 4 + 5;
//Console.WriteLine(sum);

// for文
//int sum = 0;

//for (int i = 1; i <= 5; i++)
//{
//    sum += i;
//}
//Console.WriteLine(sum);

//int i = 1;
//while (i <= 5)
//{
//    sum += i;
//    i++;
//}
//Console.WriteLine(sum);


//int[] numbers = { 1, 2, 3, 4, 5, 6 };
////int sum = 0;
//foreach (int num in numbers)
//{
//    sum += num;
//}
//Console.WriteLine("合計は: " + sum);

int sum1 = 30 % 7;
Console.WriteLine(sum1);




//int sum = Enumerable.Range(1, 5).Sum();
//Console.WriteLine("合計は: " + sum);


int n = 5;
int sum = n * (n + 1) / 2;
Console.WriteLine("合計は: " + sum);
