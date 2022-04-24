using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    [SerializeField]
    private string selectableTag = "Selectable";
    [SerializeField]
    private Material highlightedMaterial;
    [SerializeField]
    private Material previousMaterial;

    private Transform _selection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        //Resets the material
        if(_selection != null)
        {
            _selection.GetComponent<Renderer>().material = previousMaterial;
            _selection = null;
        }
        //Instantiates an object of type Ray that records the center point of the screen and what it interacts with
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
        RaycastHit raycastHit;

        //Once an object is hit and the tag is selectable it goes in
        if(Physics.Raycast(ray, out raycastHit, 3f) 
            && raycastHit.transform.CompareTag(selectableTag) 
            && raycastHit.transform.GetComponent<Renderer>() != null)
        {
            previousMaterial = raycastHit.transform.GetComponent<Renderer>().material;
            //Sets the selection for the material
            changeMaterial(raycastHit.transform.GetComponent<Renderer>());
            _selection = raycastHit.transform;
        }

    }

    private void changeMaterial(Renderer renderer)
    {
        renderer.material = highlightedMaterial;
        //throw new NotImplementedException();
    }

}
