using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_UI : MonoBehaviour
{

    [SerializeField]
    private Slider Player_Health;

    [SerializeField]
    private Slider Player_Stamina;

    // Start is called before the first frame update
    void Start()
    {
        Player_Health.maxValue = 100;
        Player_Health.value = 100;

        Player_Stamina.maxValue = 50;
        Player_Stamina.value = 50;
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
