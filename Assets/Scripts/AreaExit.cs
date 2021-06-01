using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
    // change into another scene
    public string areaToLoad;

    public string areaTransitionName;

    public AreaEntrance theEntrance;


    // Start is called before the first frame update
    void Start()
    {
        theEntrance.transitionName = areaTransitionName;


    }


    // Update is called once per frame
    void Update()
    {
  

    }


    // if some object enter the trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        // other.tag means: if something attach to an object
        // if the object is Player, then load new Scene
        if(other.tag == "Player")
        {
            // load new scene
            SceneManager.LoadScene(areaToLoad);

            PlayerController.instance.areaTransitionName = areaTransitionName;
        }



    }
}
