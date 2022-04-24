using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker_Light : MonoBehaviour
{

    [SerializeField]
    private Light [] toFlicker;

    private static int MAX = 9000;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Light e in toFlicker)
        {
            e.intensity = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Light e in toFlicker)  
        {
            int n = Random.Range(5000, MAX);
            e.intensity += n * Time.deltaTime;
            if(e.intensity > MAX)
            {
                e.intensity = 0;
            }
        }
    }
}
