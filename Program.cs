// list oluşturma
List<int> sayiListesi = new List<int>();
sayiListesi.Add(10);
sayiListesi.Add(45);
sayiListesi.Add(22);
sayiListesi.Add(16);
sayiListesi.Add(33);
sayiListesi.Sort();
Console.WriteLine(sayiListesi);

List<string> renkListesi = new List<string>();
renkListesi.Add("mavi");
renkListesi.Add("kahverengi");
renkListesi.Add("kırmızı");
renkListesi.Add("sarı");



// count   listenin eleman sayısını söyler 
Console.WriteLine(renkListesi.Count);
Console.WriteLine(sayiListesi.Count);

//list.forEach kullanımı

sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
renkListesi.ForEach(renk=> Console.WriteLine(renk));


//liste içerisinde arama 

if(sayiListesi.Contains(33))
{
Console.WriteLine("sayı listesi içerisinde 33 bulunuyor");
}
else 
Console.WriteLine("say listesi içersinde bulunmuyor");

// diziyi List'e çevirme

string[] hayvanlar = {"kedi","köpek","kuş"};

List<String> hayvanListesi = new List<string>(hayvanlar);

// list nasıl temizlenir 
hayvanListesi.Clear();
d



