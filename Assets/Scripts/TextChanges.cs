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
    protected TextAsset theSourceFile = null;
    protected TextReader txtReader = null;
    protected string[] textByLine;

    protected string text = " "; // assigned to allow first line to be read below
 
    void Start()
    {
        ScriptTxt = GetComponent<TextMeshProUGUI>();
        ScriptTxt.text = "";

        string type = Variables.scriptType.ToDescription();
        theSourceFile = Resources.Load("Scripts/" + type) as TextAsset;//new FileInfo (Application.dataPath + "/Resources/Scripts" + "/" + type);
        string str = theSourceFile.text;
        txtReader =  new StringReader(str);

    }
    
    // Update is called once per frame
    void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (text != null) {
            text = txtReader.ReadLine();
            //Console.WriteLine(text);
            ScriptTxt.text = text;
           } else {
               // CoverImage.SetActive(false);
             SceneManager.LoadScene("MainScene");
           }
        }
    }
}
