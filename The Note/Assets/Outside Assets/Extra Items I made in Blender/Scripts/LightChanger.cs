using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChanger : MonoBehaviour
{
    private Light light;

    [SerializeField]
    private bool ifPressed;

    // Start is called before the first frame update
    void Start()
    {
        ifPressed = false;
        
        light = GetComponent<Light>();
        light.intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(ifPressed && light.intensity < 5000)
        {
            light.intensity = light.intensity + 1000 * Time.deltaTime;
        }
        else if(!ifPressed && light.intensity > 0)
        {
            light.intensity = light.intensity - 1000 * Time.deltaTime;
        }
    }
}
