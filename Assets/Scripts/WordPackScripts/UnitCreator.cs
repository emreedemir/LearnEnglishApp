using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;

public class UnitCreator : MonoBehaviour
{
    Pack pack;

    Unit[] unitPack =
    {
        new Unit("Go","Gitmek"),
        new Unit("Come","Gelmek"),
        new Unit("Wake","Uyanmak"),
        new Unit("Sleep","Uyumak"),
        new Unit("Walk","Yürümek"),
        new Unit("Hold","Tutmak"),
        new Unit("Swim","Yüzmek"),
        new Unit("Pull","Çekmek"),
        new Unit("Push","İtmek"),
        new Unit("Paint","Çizmek"),
        new Unit("Arrive","Varmak"),
        new Unit("Belive","İnanmak"),
        new Unit("Bite","Isırmak"),
        new Unit("Buy","Satın Almak"),
        new Unit("Call","Aramak"),
        new Unit("Catch","Yakalamak"),
        new Unit("Decide","Karak Vermek"),
        new Unit("Die","Ölmek"),
        new Unit("Dig","Kazmak"),
        new Unit("Draw","Çizmek"),
        new Unit("Dream","Rüya Görmek"),
        new Unit("Eat","Yemek"),
        new Unit("Explain","Açıklamak"),
        new Unit("Feed","Beslemek"),
        new Unit("Fall","Düşmek"),
        new Unit("Make","Yapmak"),
        new Unit("Mention","Bahsetmek"),
        new Unit("Move","Hareket Etmek"),
        new Unit("Open","Açmak"),
        new Unit("Order","Emir Vermek"),
        new Unit("Pick","Seçmek"),
        new Unit("Put","Koymak"),
        new Unit("Quit","Bırakmak"),
        new Unit("Read","Okumak"),
        new Unit("Refuse","Reddetmek"),
        new Unit("Remember","Hatırlamak"),
        new Unit("Run","Koşmak"),
        new Unit("Sell","Satmak"),
        new Unit("Shake","Sallamak"),
        new Unit("Show","Göstermek"),
        new Unit("Speak","Konuşmak"),
        new Unit("Teach","Ögretmek"),
        new Unit("Tell","Söylemek"),
        new Unit("Want","İstemek"),
        new Unit("Work","Çalışmak"),
        new Unit("Wish","Dilemek"),
        new Unit("Write","Yazmak")
    };

    private void Start()
    {
       // CreataPack();
    }
    public void CreataPack()
    {

        pack = new Pack();

        pack.id = 1;

        pack.packName = "En Kullanışlı 50 Fiil";

        pack.packDescription = "Günlük hayatda ve metinlerde mutlaka karşına çıkacak fiiler";

        pack.units = unitPack.ToList();

        string packJsonString = JsonUtility.ToJson(pack,true);

        string filePath = "Assets/Resources/WordPacks/" + pack.id +".json";

        File.WriteAllText(filePath,packJsonString);

        /*
        IEnumerable<string> lengt = ((IEnumerable)packJsonString).Cast<string>().Count();
        File.WriteAllLines(filePath);
        */
    }
}
