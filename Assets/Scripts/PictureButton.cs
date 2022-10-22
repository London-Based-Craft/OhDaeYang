using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureButton : MonoBehaviour
{
    Picture picture;
    GameObject pictureController; 

    // Start is called before the first frame update
    void Start()
    {   
        pictureController = GameObject.Find("PictureController");
        picture = pictureController.GetComponent<Picture> ();
    }

    // Update is called once per frame
    void Update()
    {   
    }

    public void OnClick() {
        picture.Open();
    }
}
