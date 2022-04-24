using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevel : MonoBehaviour
{
    public GameObject main;
    public GameObject [] ui;
    // Start is called before the first frame update
    void Start()
    {
        main.SetActive(true);
        foreach(GameObject e in ui)
            e.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startLevel()
    {
        SceneManager.LoadScene("TheMaze");
    }

    public void exitGame()
    {
        Application.Quit();
    }

}
