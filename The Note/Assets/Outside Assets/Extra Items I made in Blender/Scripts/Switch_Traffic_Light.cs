using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This class is going to be used to change the lights 
//of a traffic light in an automated manner so that it resembles the
//way it happens in real life(Red, Yellow, Green)

//TODO Look up "ATLTC" to mimic the control template used

public class Switch_Traffic_Light : MonoBehaviour
{
    //This will be the instance variable list used to store the lights in the game engine
    
    //Assume that the list will only capture 3 different types of light
    //and there won't be any more nor less for a traffic light
    [SerializeField]
    private Light [] light = new Light[3];

    // Start is called before the first frame update
    void Start()
    {
        //Anything in here will only be called once at the start of the game
    }

    // Update is called once per frame
    void Update()
    {
        //This will always be called
    }


    //Helper function if you want to use it
    private void setIntensity(Light e, int intensity)
    {
        //sets the intensity of light of 'e' to a set amount
        e.intensity = intensity;
    }
}
