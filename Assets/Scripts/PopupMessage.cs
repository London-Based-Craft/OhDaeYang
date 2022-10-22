 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;
 
 public class PopupMessage : MonoBehaviour {
    public GameObject ui;
    Picture picture;
    GameObject pictureController;

 
    // Use this for initialization
    void Start () {
        ui.SetActive(false);
        pictureController = GameObject.Find("PictureController");
        picture = pictureController.GetComponent<Picture> ();
    }
     
    // Update is called once per frame
    void Update () {
    }
 
    public void Open(string itemImageName, string message) {
        ui.SetActive(!ui.activeSelf);
 
        if (ui.activeSelf) {
            if(!string.IsNullOrEmpty(itemImageName)){
                var texture = TakeItem (itemImageName);
                RawImage rawImage = ui.gameObject.GetComponentInChildren<RawImage>();
                rawImage.texture = texture;
            }
            if (!string.IsNullOrEmpty (message)) {
                Text textObject = ui.gameObject.GetComponentInChildren<Text> ();
                textObject.text = message;
            }
            Time.timeScale = 0f;
        } 
    }
    
    public void Close() {
        ui.SetActive(!ui.activeSelf);
        if (!ui.activeSelf) {
            Time.timeScale = 1f;
        } 

        picture.Open();
     }

    //You need to have Folder Resources/Items
    public Texture TakeItem(string itemImageName) {
        var loadedItem = Resources.Load<Texture2D>("Items/"+itemImageName);
        return loadedItem;
    }
}
