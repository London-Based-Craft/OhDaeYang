using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picture : MonoBehaviour
{
    public GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        ui.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        HideIfClickedOutside();
    }

    private void HideIfClickedOutside() {
        if (Input.GetMouseButton(0) && ui.activeSelf &&
            !RectTransformUtility.RectangleContainsScreenPoint(
                ui.GetComponent<RectTransform>(),
                Input.mousePosition,
                Camera.main)) {
            ui.SetActive(false);
        }
    }

    public void Open(){
        ui.SetActive(true);
    }
}
