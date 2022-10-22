using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public AudioClip playBGM;
    public GameObject CoverImage;
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickStartButton(){
        // CoverImage.SetActive(false);
        SceneManager.LoadScene("MainScene");
        // GetComponent<AudioSource>().clip = playBGM;
        // GetComponent<AudioSource>().Play();
    }
    
}
