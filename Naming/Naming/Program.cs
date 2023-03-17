// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");

//1. Kullandığınız isimler ANLAMLI olsun
int x = 0;
int i = 0;

int d = 150; //kullanıcının üye olmasından bu yana geçen toplam gün sayısı

int daysSinceUserCreated = 150;
int musteriKaydindanBuyanaGecenGunSayisi = 200;

//2. Kural: Kısaltma yok!
var hp = 0;
//İşletmedeki hp bilgisayarların sayısı
//Horse Power
//Hit Point

int healthPoint = 100;
//3. Objelere isim verirken class ismini kullan. Ancak başa ayrıştırıcı bir kelime ekle:
DataTable employeesDataTable = new DataTable();
Random randomNumberGenerator = new Random();

var emailList = new List<string>();
//4. Eğer koleksiyon tanımlıyorsanız; çoğul ekler (plural) kullanın.
List<string> emails = new List<string>();

int intNumber = 8;
string stringName = "Türkay";

//Ok Boomer!
//bool boolIsOk = false;

//5. Benzeşimlerden KAÇININ!
var o = 0;
var l = 1;
if (o == 1)
{

}



List<int[]> cells = new List<int[]>();

List<int[]> getFlaggedCellsOnGameBoard()
{
    List<int[]> flaggedCells = new List<int[]>();
    foreach (var item in flaggedCells)
    {
        if (item[0] == 4)
        {
            flaggedCells.Add(item);
        }
    }

    return flaggedCells;
}

