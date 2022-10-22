using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragCamera : MonoBehaviour
{
    [SerializeField] 
    private Camera cam;
    private Vector3 dragORigin;

    public float leftLimit;
    public float rightLimit;
    
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
            difference.y = 0;
            // print("origin"+ dragORigin + "newPosition " + cam.ScreenToWorldPoint(Input.mousePosition) + "=difference " + difference);
            // print("difference.x"+ difference.x + "difference.y " + difference.y);

            // Vector3 targetPos = new Vector3(cam.transform.position.x, cam.transform.position.y, this.transform.position.z);

            cam.transform.position += difference;
            cam.transform.position = new Vector3
            (
                Mathf.Clamp(cam.transform.position.x, leftLimit, rightLimit),
                cam.transform.position.y,
                cam.transform.position.z
            );
            // targetPos.x = Mathf.Clamp(targetPos.x, minCameraBoundary.x, maxCameraBoundary.x);
            // targetPos.y = Mathf.Clamp(targetPos.y, minCameraBoundary.y, maxCameraBoundary.y);
        }
    }
}