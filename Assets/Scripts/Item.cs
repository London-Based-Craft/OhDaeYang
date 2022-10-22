using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New_Item", menuName = "Item")]
public class Item : ScriptableObject
{
    public string title;
    public string mesage;
    public Sprite image;

    [TextArea(3,5)]
    public string description;
}
