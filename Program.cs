

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// .NET 6 以降でトップレベル構文（Mainメソッドを書かない形式）を使っている場合、using CsStudy; が必要になる
using CsStudy;

// SampleRPGをインポート：【カプセル化（P112 ～ P146）】
using CsStudy.SampleRPG;

// KartGameをインポート：【継承（P147 ～ P168）】
using CsStudy.KartGame;

///XMLドキュメントコメント
///プログラムには無視されるが、ドキュメント生成やツールチップに使われる特別なコメント
///コードに仕様説明を埋め込める
///IDEでマウスホバーすると説明が表示される
///XML形式でドキュメントファイル（.xml）として出力可能（→API仕様書として使える


// 基本問題のクラス(～P85)
//SuperBasic.Run();

// 基本問題のクラス(～P110)
//SuperBasic2.Run();



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
// 「親クラス型の配列を作成
//Kart[] karts = new Kart[2];
Kart[] karts = [new SkyKart(), new TurboKart()];


// 派生クラスのインスタンスを基本クラスの変数に代入
//karts[0] = new SkyKart();
//karts[1] = new TurboKart();

foreach (Kart k in karts) 
{
    // 各子クラスのHornを呼び出す（ポリモーフィズム）
    k.Horn();
}

