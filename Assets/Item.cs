using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    PopupMessage popupMessage;
    GameObject popupController; 

    // Start is called before the first frame update
    void Start()
    {   
        popupController = GameObject.Find("PopupController");
        popupMessage = popupController.GetComponent<PopupMessage> ();
    }

    // Update is called once per frame
    void Update()
    {   
    }

    public void OnClick() {
        popupMessage.Open("NameOfTexture","This is some text");
    }
}
