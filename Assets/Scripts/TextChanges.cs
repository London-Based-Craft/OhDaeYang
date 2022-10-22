using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TextChanges : MonoBehaviour
{
    public TextMeshProUGUI ScriptTxt;
    string[] IntroScript = new string[] { ".....", "Where am I?", "Spider Man" };
    protected FileInfo theSourceFile = null;
    protected StreamReader reader = null;
    protected string text = " "; // assigned to allow first line to be read below
 
    void Start()
    {
        ScriptTxt = GetComponent<TextMeshProUGUI>();
        ScriptTxt.text = "";

        string type = Variables.scriptType.ToDescription();
        theSourceFile = new FileInfo (Application.dataPath + "/Resources/Scripts" + "/" + type);
        reader = theSourceFile.OpenText();
    }
    
    // Update is called once per frame
    void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (text != null) {
            text = reader.ReadLine();
            //Console.WriteLine(text);
            ScriptTxt.text = text;
           } else {
               // CoverImage.SetActive(false);
             SceneManager.LoadScene("MainScene");
           }
        }
    }
}
