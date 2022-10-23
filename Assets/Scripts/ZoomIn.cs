using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomIn : MonoBehaviour
{
    public GameObject report;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
      report.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(0))
        {
           click();
        }
    }
    
    public void click()
    {
        RectTransform rectTran = gameObject.GetComponent<RectTransform>();
        // GameObject obj = GameObject.Find("report");
        // Vector3 position = obj.transform.localPosition;
        if (count == 0) {
            // rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 991);
            // rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 1305);
            // position.x =394;
            // position.y = 501;
            // obj.transform.localPosition = position;
            count++;
        } else if( count == 1 ){
            report.SetActive(true);
        }
        
        // else
        // {
        //     rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 470);
        //     rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 300);
        //     position.x = -580;
        //     position.y = 10;
        //     obj.transform.localPosition = position;
        //     IDCardChk = false;
        // }
    }
}
