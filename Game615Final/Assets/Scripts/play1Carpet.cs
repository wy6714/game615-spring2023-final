using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play1Carpet : MonoBehaviour
{
  
    private bool activeCarpet = false;
    private Animator carpetAnim;

    void Start()
    {
        
    }


    void Update()
    {
        //click carpet to move it
        if (!activeCarpet && Input.GetMouseButtonDown(0))
        {
            activeCarpet = true;
        }else if(activeCarpet && Input.GetMouseButtonDown(0))
        {
            activeCarpet = false;
        }

        //determine the animation of carpet
        if (activeCarpet)
        {

        }
    }

    

}
