using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioClip playBGM;
    public GameObject CoverImage;

    void Awake()
    {
        // DontDestoryOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickStartButton(){
        CoverImage.SetActive(false);
        GetComponent<AudioSource>().clip = playBGM;
        GetComponent<AudioSource>().Play();
        // Application.LoadLevel("1_play");
    }
    
}
