using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Switch : MonoBehaviour
{
    //Variable to keep all of the lights
    [SerializeField]
    Light []light;

    //Switch statement shown as public field for testing
    [SerializeField]
    bool ifPressed;


    //Static fields for easier debugging
    private static int LOW_BATTERY_MODE = 1000;

    private static int HIGH_BATTERY_MODE = 5000;

    private static int INCREMENTER = 1000;

    // Start is called before the first frame update
    void Start()
    {
        //Initializes the switch to the 'off' position and keeps lights at low intensity
        ifPressed = false;
        foreach(Light e in light)
        {
            e.intensity = LOW_BATTERY_MODE;
        }

    }

    // Update is called once per frame
    void Update()
    {
        //Updates all of the lights in the switch list depending on the mode(on or off)
        foreach(Light e in light)
        {
            if(ifPressed && e.intensity < HIGH_BATTERY_MODE)
            {
                e.intensity = e.intensity + INCREMENTER * Time.deltaTime;
            }
            else if(!ifPressed && e.intensity > LOW_BATTERY_MODE)
            {
                e.intensity = e.intensity - INCREMENTER * Time.deltaTime;
            }
            else if(e.intensity < LOW_BATTERY_MODE)
            {
                e.intensity = LOW_BATTERY_MODE;
            }
        }
    }
}
