using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LightOn() {
    }
}
