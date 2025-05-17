

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// .NET 6 以降でトップレベル構文（Mainメソッドを書かない形式）を使っている場合、using CsStudy; が必要になる
using CsStudy;

// SampleRPGをインポート：【カプセル化（P112 ～ P146）】
using CsStudy.SampleRPG;

// KartGameをインポート：【継承（P147 ～ P168）】
using CsStudy.KartGame;
using System.Drawing;

///XMLドキュメントコメント
///プログラムには無視されるが、ドキュメント生成やツールチップに使われる特別なコメント
///コードに仕様説明を埋め込める
///IDEでマウスホバーすると説明が表示される
///XML形式でドキュメントファイル（.xml）として出力可能（→API仕様書として使える


// 基本問題のクラス(～P85)
//SuperBasic.Run();

// 基本問題のクラス(～P110)
//SuperBasic2.Run();

// 基本問題のクラス
//SuperBasic3.Run();

//---------------------------------------------------------------------------

// 【カプセル化（P112 ～ P146）】

// javaと違ってフィールドではなく実行文になるのでメソッド内に定義
//Player player1 = new Player();
//player1.name = "たかし";
//player1.hp = 100;


//Player player1 = new()
//{
//    name = "たかし",
//    hp = 100
//};

//Player player2 = new()
//{
//    name = "ひろし",
//    hp = 50
//};

//player1.Attack();
//player2.Defense();


// ↓ここから下が、現在のコードに対応


// Player player1 = new Player();の右のPlayerは省略できる
//Player player1 = new();
//Console.WriteLine(player1.name + "の体力は" + player1.hp);

//Player player1 = new("ひろし", 100);
//Console.WriteLine(player1.Name + "の体力は" + player1.Hp);

//int newHp = player1.Hp - 2000;
//player1.UpdateHp(newHp);
//Console.WriteLine(player1.Name + "の体力は" + player1.Hp);


//string newName = "大ピンチのひろし";
//player1.UpdateName(newName);
//Console.WriteLine(player1.Name + "の体力は" + player1.Hp);

//newName = "ひきこもりのひろし";
//player1.UpdateName(newName);
//Console.WriteLine(player1.Name + "の体力は" + player1.Hp);


//player1.Attack();

//Player player3 = new();
//Console.WriteLine(player3.Name + "の体力は" + player1.Hp);

//---------------------------------------------------------------------------





//---------------------------------------------------------------------------

// 【継承（P147 ～ P168）】

//SkyKart skyKart = new();
//TurboKart turboKart = new();

//skyKart.Force();
//skyKart.Flying();

//turboKart.Force();
//turboKart.Turbo();



// 親クラス（Kart）の配列を通して、実際の子クラスのメソッドを呼び出す


// 親クラス型の配列を作成し、子クラス（インスタンス）を代入、パターン1
//Kart[] karts = new Kart[2];
//karts[0] = new SkyKart();
//karts[1] = new TurboKart();

// 親クラス型の配列を作成し、子クラス（インスタンス）を代入、パターン2
// Kart[] karts = [new SkyKart(), new TurboKart()];


// 作成した配列から各インスタンスの該当メソッドを呼び出す
//foreach (Kart k in karts) 
//{
//    // 各子クラスのHornを呼び出す（ポリモーフィズム）
//    k.Horn();
//}

//---------------------------------------------------------------------------


// ストラクト
StructBasic a = new StructBasic { X = 1, Y = 2 };
StructBasic b = a; // aをコピー

b.X = 100;

Console.WriteLine($"a.X: {a.X}");
Console.WriteLine($"b.X: {b.X}");


// 節目の表示
LineBorder.Line();
// クラス
ClassBasic c = new ClassBasic { X = 1, Y = 2 };
ClassBasic d = c; // cの情報を共有

d.X = 100;

Console.WriteLine($"c.X: {c.X}");
Console.WriteLine($"d.X: {d.X}");


// 節目の表示
LineBorder.Line();
// デリゲート
DelegateBasic db = new DelegateBasic();
// デリゲートの取得
Cal method = db.GetDelegate();

int result = method(3, 4);
Console.WriteLine($"結果: {result}");


// 節目の表示
LineBorder.Line();
var obj = new DelegateBasic2();
int result2 = obj.Method3(2, 10);
Console.WriteLine($"戻ってきた値（最後の関数の戻り値）: {result2}");