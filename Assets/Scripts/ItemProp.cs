using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemProp : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string imageName;
    public string message;
    public int imageWidth;
    public int imageHeight;
    public Material material;

    UnityEngine.Events.UnityAction buttonCallback;
    Button button;
    Image image;
    
    PopupMessage popupMessage;
    GameObject popupController;

    AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        image = this.gameObject.GetComponent<Image>();
        image.color = new Color32(255,255,255,1);
        button = this.gameObject.GetComponent<Button>();
        popupController = GameObject.Find("PopupController");
        popupMessage = popupController.GetComponent<PopupMessage> ();
        source = GetComponent<AudioSource>();
        AddItemCallback();
    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        source.Play();
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        source.Pause();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void AddItemCallback()
    {
        // Remove the last added callback
        if( buttonCallback != null )
            button.onClick.RemoveListener( buttonCallback );
    
        // Define new callback
        buttonCallback = () => OnClick_ShowPopup();
        // Add callback to button
        button.onClick.AddListener( buttonCallback );
    }

    void OnClick_ShowPopup()
    {
        popupMessage.Open(imageName, message, imageWidth, imageHeight);
        
        image.material = material;
        image.color = new Color32(255,255,255,255);
    }
}
