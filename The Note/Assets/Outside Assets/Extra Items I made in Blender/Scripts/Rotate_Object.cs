using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Object : MonoBehaviour
{
    // Instance variable to attach the game object to in-game using the inspector tab
    [SerializeField]
    private GameObject toRotate;

    //Public variables
    public float x, y, z;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(toRotate.ToString());

        //Initializing variables
        x = 3;
        y = 3;
        z = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //Changes the position of the game object
        //toRotate.transform.position += new Vector3(0.75f, 0.0f, 0.0f) * Time.deltaTime;
        transform.Rotate(x, y, z , Space.Self);
    }
}
