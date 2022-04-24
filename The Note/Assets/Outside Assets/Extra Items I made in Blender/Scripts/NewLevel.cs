using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewLevel : MonoBehaviour
{

    //private Collision Item;
    // Start is called before the first frame update
    void Start()
    {
        //Item = GetComponent<Collision>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape"))
        {
            Debug.Log("This debug is in NewLevel script and is used for application Quit");
            Application.Quit();
        }
    }

    //You can use a different method to call the body code instead
    private void OnControllerColliderHit(ControllerColliderHit other)
    {
        
        Debug.Log("It touched ");
        //Checks if tag is what you wanna touch to transport to new scene
        if (other.gameObject.tag == "New Level")
        {
            Debug.Log("In");
            //The scenes literal string name. It can be an index if that makes it easier
            SceneManager.LoadScene("Main Game");
        }
    }

}
