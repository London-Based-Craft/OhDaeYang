using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string imageName;
    public string message;

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

    public void OnClick()
    {
        popupMessage.Open(imageName, message);
    }
}
