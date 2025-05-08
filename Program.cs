

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



///XMLドキュメントコメント
///プログラムには無視されるが、ドキュメント生成やツールチップに使われる特別なコメント
///コードに仕様説明を埋め込める
///IDEでマウスホバーすると説明が表示される
///XML形式でドキュメントファイル（.xml）として出力可能（→API仕様書として使える


// 練習問題3-5
int a = 15;
int b = 2;
float answer = (float)a / b;
Console.WriteLine(answer);


// 後置インクリメント演算子
//今の値を使ってから、あとで1増やす
int c = 2;
Console.WriteLine(c++);  // 出力：2（使ってから増える）
Console.WriteLine(c);    // 出力：3（1増えてる）

// 節目の表示
line();

// 練習問題3-6
int d = 10;
for (int i = 1; i <= 2; i++)
{
    d--;
}
Console.WriteLine(d);

d /= 4;
Console.WriteLine(d);

// 節目の表示
line();

int playerPosX = 10;
int enemyPosX = 10;
if (playerPosX == enemyPosX)
{
    Console.WriteLine("敵と遭遇");
}

// 節目の表示
line();

// 練習問題3-7
int num = 10;
if (num >= 3)
{
    Console.WriteLine("勝ち");
}

// 節目の表示
line();

int player1PosX = 2;
int player2PosX = 6;
if (player1PosX == 2)
{
    if (player2PosX == 6)
    {
        Console.WriteLine("仕掛け解除");
    }
}

// 節目の表示
line();

//int player1PosX = 2;
//int player2PosX = 6;
if (player1PosX == 2 && player2PosX == 6)
{
    Console.WriteLine("仕掛け解除");
}


// 節目の表示
line();

// 練習問題3-8
//int player1PosX = 2;
//int player2PosX = 6;
if (player1PosX == 1 || player2PosX == 4)
{
    Console.WriteLine("仕掛け解除");
}


// 節目の表示
line();

// 練習問題3-9
if ((player1PosX == 2 && player2PosX == 6) || (player1PosX == 6 && player2PosX == 2))
{
    Console.WriteLine("仕掛け解除");
}






// 節目の表示
static void line()
{
    Console.WriteLine("----------------------"); ;
}







