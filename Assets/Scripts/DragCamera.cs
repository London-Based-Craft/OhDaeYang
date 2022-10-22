using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragCamera : MonoBehaviour
{
    [SerializeField] 
    private Camera cam;
    private Vector3 dragORigin;
    

   private void Update ()
    {
        PanCamera();
    }

    private void PanCamera(){
        if(Input.GetMouseButtonDown(0)){
            dragORigin = cam.ScreenToWorldPoint(Input.mousePosition);
        }
        if(Input.GetMouseButton(0)){
            Vector3 difference = dragORigin - cam.ScreenToWorldPoint(Input.mousePosition);

            print("origin"+ dragORigin + "newPosition " + cam.ScreenToWorldPoint(Input.mousePosition) + "=difference " + difference);

            cam.transform.position += difference;
        }
    }

 
}