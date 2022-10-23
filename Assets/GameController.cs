using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

    
public class ItemDef {
    public string itemName;
    public bool isFound;
    public ItemDef(string itemName, bool isFound){
        this.itemName = itemName;
        this.isFound = isFound;
    }
};

public class GameController : MonoBehaviour
{
    public bool r1LightON;
    public bool r2LightON;
    public bool r3LightON;

    enum ItemEnum {
        PictureFrame,
        Memo,
        Drawing,
        Duck,
        Doll,
        BankBook,
        Rope,
        Food,
        MedBottle,
        Underwear,
        ToiletPaper,
        Stick,
    };

    Dictionary<ItemEnum, ItemDef> items = new Dictionary<ItemEnum, ItemDef>(){
         {ItemEnum.PictureFrame, new ItemDef("PictureFrame", false)},
        {ItemEnum.Memo, new ItemDef("Memo", false)},
        {ItemEnum.Drawing, new ItemDef("Drawing", false)},
        {ItemEnum.Duck, new ItemDef("Duck", false)},
        {ItemEnum.Doll, new ItemDef("Doll", false)},
        {ItemEnum.BankBook, new ItemDef("BankBook", false)},
        {ItemEnum.Rope, new ItemDef("Rope", false)},
        {ItemEnum.Food, new ItemDef("Food", false)},
        {ItemEnum.MedBottle, new ItemDef("MedBottle", false)},
        {ItemEnum.Underwear, new ItemDef("Underwear", false)},
        {ItemEnum.ToiletPaper, new ItemDef("ToiletPaper", false)},
        {ItemEnum.Stick, new ItemDef("Stick", false)},
    };

    // Start is called before the first frame update
    void Start()
    {
        r1LightON = false;
        r2LightON = false;
        r3LightON = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ArePlayRoomItemsFound()) 
        {
            GameObject.Find("Room 1").GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = 1;
            r1LightON = true;
        }
        if (AreFactoryItemsFound()) 
        {
            GameObject.Find("Room 3").GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = 1;
            r3LightON = true;
        }
        if (AreBathRoomItemsFound()) 
        {
            GameObject.Find("Room 2").GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = 1;
            r2LightON = true;
        }
        if (r1LightON && r2LightON && r3LightON) 
        {
            SceneManager.LoadScene("EndingScene");
        }
    }

    Image getImageWithName(string name) {
        return GameObject.Find(name).GetComponent<Image>();
    }

    bool isImageVisible(ItemDef item) {
        bool result = (getImageWithName(item.itemName).color[3] == 1);
        
        // Debug.Log("isImageVisible()" +getImageWithName(item.itemName).color[3] + item.itemName + result);
        return result;
    }

    bool ArePlayRoomItemsFound() {
        return (isImageVisible(items[ItemEnum.PictureFrame]) &&
            isImageVisible(items[ItemEnum.Memo]) && 
            isImageVisible(items[ItemEnum.Drawing]) && 
            isImageVisible(items[ItemEnum.Duck]) && 
            isImageVisible(items[ItemEnum.Doll]));
    }

    bool AreFactoryItemsFound() {
        return (isImageVisible(items[ItemEnum.BankBook]) &&
            isImageVisible(items[ItemEnum.Rope]) && 
            isImageVisible(items[ItemEnum.Food]));
    }

    bool AreBathRoomItemsFound() {
        return (isImageVisible(items[ItemEnum.MedBottle]) &&
            isImageVisible(items[ItemEnum.Underwear]) && 
            isImageVisible(items[ItemEnum.ToiletPaper])&& 
            isImageVisible(items[ItemEnum.Stick]));
    }
}
