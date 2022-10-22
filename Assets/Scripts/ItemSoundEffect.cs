using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSoundEffect : MonoBehaviour, IPointerEnterHandler
{
    AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Debug.Log("The cursor entered the selectable UI element.");
        source.Play();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
