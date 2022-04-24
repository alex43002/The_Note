using System.Collections;
using UnityEngine;
public class FootSteps : MonoBehaviour
{

    //List of audioclips for several differentiating types of tags
    public CharacterController controller;
    public AudioClip[] concrete;
    public AudioClip[] wood;
    public AudioClip[] dirt;
    public AudioClip[] metal;
    public AudioClip[] glass;
    public AudioClip[] sand;
    public AudioClip[] snow;
    public AudioClip[] floor;
    public AudioClip[] grass;
    public AudioClip[] rug;

    //For playing sounds in intervals
    private bool step = true;
    float audioStepLengthWalk = 0.75f;
    float audioStepLengthRun = 0.25f;

    private static float MAX_SPEED = 6;
    private static float BARRIER_SPEED = 4;
    private static float WALK_SPEED = 1;

    //Method for the controller mesh to assess what the player touches and to play the corresponding sound given the right tag
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //WalkOnWood();
        if (controller.isGrounded && controller.velocity.magnitude < BARRIER_SPEED && controller.velocity.magnitude > WALK_SPEED && hit.gameObject.tag == "Untagged" && step == true)
        {
            WalkOnConcrete();
        }
        else if (controller.isGrounded && controller.velocity.magnitude > MAX_SPEED && hit.gameObject.tag == "Concrete" && step == true || controller.isGrounded && controller.velocity.magnitude > MAX_SPEED && hit.gameObject.tag == "Untagged" && step == true)
        {
            RunOnConcrete();
        }
        else if (controller.isGrounded && controller.velocity.magnitude < BARRIER_SPEED && controller.velocity.magnitude > WALK_SPEED && hit.gameObject.tag == "Untagged" && step == true)
        {
            WalkOnConcrete();
        }
        else if (controller.isGrounded && controller.velocity.magnitude > MAX_SPEED && hit.gameObject.tag == "Concrete" && step == true )
        {
            RunOnConcrete();
        }
        else if (//controller.isGrounded && 
            controller.velocity.magnitude < BARRIER_SPEED && controller.velocity.magnitude > WALK_SPEED && hit.gameObject.tag == "Wood" && step == true)
        {
            WalkOnWood();
        }
        else if (controller.isGrounded && controller.velocity.magnitude > MAX_SPEED && hit.gameObject.tag == "Wood" && step == true)
        {
            RunOnWood();
        }
        else if (controller.isGrounded && controller.velocity.magnitude < BARRIER_SPEED && controller.velocity.magnitude > WALK_SPEED && hit.gameObject.tag == "Dirt" && step == true)
        {
            WalkOnDirt();
        }
        else if (controller.isGrounded && controller.velocity.magnitude > MAX_SPEED && hit.gameObject.tag == "Dirt" && step == true)
        {
            RunOnDirt();
        }
        else if (controller.isGrounded && controller.velocity.magnitude < BARRIER_SPEED && controller.velocity.magnitude > WALK_SPEED && hit.gameObject.tag == "Metal" && step == true)
        {
            WalkOnMetal();
        }
        else if (controller.isGrounded && controller.velocity.magnitude > MAX_SPEED && hit.gameObject.tag == "Metal" && step == true)
        {
            RunOnMetal();
        }
        else if (controller.isGrounded && controller.velocity.magnitude < BARRIER_SPEED && controller.velocity.magnitude > WALK_SPEED && hit.gameObject.tag == "Glass" && step == true)
        {
            WalkOnGlass();
        }
        else if (controller.isGrounded && controller.velocity.magnitude > MAX_SPEED && hit.gameObject.tag == "Glass" && step == true)
        {
            RunOnGlass();
        }
        else if (controller.isGrounded && controller.velocity.magnitude < BARRIER_SPEED && controller.velocity.magnitude > WALK_SPEED && hit.gameObject.tag == "Sand" && step == true)
        {
            WalkOnSand();
        }
        else if (controller.isGrounded && controller.velocity.magnitude > MAX_SPEED && hit.gameObject.tag == "Sand" && step == true)
        {
            RunOnSand();
        }
        else if (controller.isGrounded && controller.velocity.magnitude < BARRIER_SPEED && controller.velocity.magnitude > WALK_SPEED && hit.gameObject.tag == "Snow" && step == true)
        {
            WalkOnSnow();
        }
        else if (controller.isGrounded && controller.velocity.magnitude > MAX_SPEED && hit.gameObject.tag == "Snow" && step == true)
        {
            RunOnSnow();
        }
        else if (controller.isGrounded && controller.velocity.magnitude < BARRIER_SPEED && controller.velocity.magnitude > WALK_SPEED && hit.gameObject.tag == "Floor" && step == true)
        {
            WalkOnFloor();
        }
        else if (controller.isGrounded && controller.velocity.magnitude > MAX_SPEED && hit.gameObject.tag == "Floor" && step == true)
        {
            RunOnFloor();
        }
        else if (controller.isGrounded && controller.velocity.magnitude < BARRIER_SPEED && controller.velocity.magnitude > WALK_SPEED && hit.gameObject.tag == "Grass" && step == true)
        {
            WalkOnGrass();
        }
        else if (controller.isGrounded && controller.velocity.magnitude > MAX_SPEED && hit.gameObject.tag == "Grass" && step == true)
        {
            RunOnGrass();
        }
        else if(//controller.isGrounded && 
            controller.velocity.magnitude < BARRIER_SPEED && controller.velocity.magnitude > WALK_SPEED && hit.gameObject.tag == "Rug" && step == true)
        {
            WalkOnRug();
        }
    }

    IEnumerator WaitForFootSteps(float stepsLength)
    {
        step = false;
        yield return new WaitForSeconds(stepsLength);
        step = true;
    }
    /////////////////////////////////// CONCRETE ////////////////////////////////////////
    void WalkOnConcrete()
    {
        GetComponent<AudioSource>().clip = concrete[Random.Range(0, concrete.Length)];
        GetComponent<AudioSource>().volume = 0.1f;
        GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForFootSteps(audioStepLengthWalk));

    }

    void RunOnConcrete()
    {

        GetComponent<AudioSource>().clip = concrete[Random.Range(0, concrete.Length)];
        GetComponent<AudioSource>().volume = 0.3f;
        GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForFootSteps(audioStepLengthWalk));

    }

    ////////////////////////////////// WOOD ///////////////////////////////////////////// 
    void WalkOnWood()
    {
        Debug.Log("Walk");
        GetComponent<AudioSource>().clip = wood[Random.Range(0, wood.Length)];
        GetComponent<AudioSource>().volume = 0.1f;
        GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForFootSteps(audioStepLengthWalk));

    }

    void RunOnWood()
    {
        Debug.Log("RUN");
        GetComponent<AudioSource>().clip = wood[Random.Range(0, wood.Length)];
        GetComponent<AudioSource>().volume = 0.3f;
        GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForFootSteps(audioStepLengthRun));

    }

    /////////////////////////////////// DIRT ////////////////////////////////////////////// 
    void WalkOnDirt()
    {

        GetComponent<AudioSource>().clip = dirt[Random.Range(0, dirt.Length)];
        GetComponent<AudioSource>().volume = 0.1f;
        GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForFootSteps(audioStepLengthWalk));

    }

    void RunOnDirt()
    {

        GetComponent<AudioSource>().clip = dirt[Random.Range(0, dirt.Length)];
        GetComponent<AudioSource>().volume = 0.3f;
        GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForFootSteps(audioStepLengthRun));

    }

    ////////////////////////////////// METAL /////////////////////////////////////////////// 
    void WalkOnMetal()
    {

        GetComponent<AudioSource>().clip = metal[Random.Range(0, metal.Length)];
        GetComponent<AudioSource>().volume = 0.1f;
        GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForFootSteps(audioStepLengthWalk));

    }

    void RunOnMetal()
    {

        GetComponent<AudioSource>().clip = metal[Random.Range(0, metal.Length)];
        GetComponent<AudioSource>().volume = 0.3f;
        GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForFootSteps(audioStepLengthRun));

    }

    ////////////////////////////////// GLASS /////////////////////////////////////////////// 
    void WalkOnGlass()
    {

        GetComponent<AudioSource>().clip = glass[Random.Range(0, glass.Length)];
        GetComponent<AudioSource>().volume = 0.1f;
        GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForFootSteps(audioStepLengthWalk));

    }

    void RunOnGlass()
    {

        GetComponent<AudioSource>().clip = glass[Random.Range(0, glass.Length)];
        GetComponent<AudioSource>().volume = 0.3f;
        GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForFootSteps(audioStepLengthRun));

    }

    ////////////////////////////////// SAND /////////////////////////////////////////////// 
    void WalkOnSand()
    {

        GetComponent<AudioSource>().clip = sand[Random.Range(0, sand.Length)];
        GetComponent<AudioSource>().volume = 0.1f;
        GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForFootSteps(audioStepLengthWalk));

    }

    void RunOnSand()
    {

        GetComponent<AudioSource>().clip = sand[Random.Range(0, sand.Length)];
        GetComponent<AudioSource>().volume = 0.3f;
        GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForFootSteps(audioStepLengthRun));

    }

    ////////////////////////////////// SNOW /////////////////////////////////////////////// 
    void WalkOnSnow()
    {

        GetComponent<AudioSource>().clip = snow[Random.Range(0, snow.Length)];
        GetComponent<AudioSource>().volume = 0.1f;
        GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForFootSteps(audioStepLengthWalk));

    }

    void RunOnSnow()
    {

        GetComponent<AudioSource>().clip = snow[Random.Range(0, snow.Length)];
        GetComponent<AudioSource>().volume = 0.3f;
        GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForFootSteps(audioStepLengthRun));

    }

    ////////////////////////////////// FLOOR /////////////////////////////////////////////// 
    void WalkOnFloor()
    {

        GetComponent<AudioSource>().clip = floor[Random.Range(0, floor.Length)];
        GetComponent<AudioSource>().volume = 0.1f;
        GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForFootSteps(audioStepLengthWalk));

    }

    void RunOnFloor()
    {

        GetComponent<AudioSource>().clip = floor[Random.Range(0, floor.Length)];
        GetComponent<AudioSource>().volume = 0.3f;
        GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForFootSteps(audioStepLengthRun));

    }

    ////////////////////////////////// GRASS /////////////////////////////////////////////// 
    void WalkOnGrass()
    {

        GetComponent<AudioSource>().clip = grass[Random.Range(0, grass.Length)];
        GetComponent<AudioSource>().volume = 0.1f;
        GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForFootSteps(audioStepLengthWalk));

    }

    void RunOnGrass()
    {

        GetComponent<AudioSource>().clip = grass[Random.Range(0, grass.Length)];
        GetComponent<AudioSource>().volume = 0.3f;
        GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForFootSteps(audioStepLengthRun));

    }

    void WalkOnRug()
    {

        GetComponent<AudioSource>().clip = rug[Random.Range(0, rug.Length)];
        GetComponent<AudioSource>().volume = 0.05f;
        GetComponent<AudioSource>().Play();
        StartCoroutine(WaitForFootSteps(audioStepLengthWalk));

    }
}