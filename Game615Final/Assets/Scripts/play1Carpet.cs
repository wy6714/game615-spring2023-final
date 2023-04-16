using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play1Carpet : MonoBehaviour
{
    
    private bool activeCarpet = false;
    [SerializeField]private Animator carpetAnim;
    [SerializeField] private GameObject cursorObj;
    [SerializeField] private GameObject carpetObj;

    void Start()
    {
        
    }


    void Update()
    {
        //click carpet to move it
        if (!activeCarpet && Functions.CheckDis(cursorObj,carpetObj,1f) && Input.GetMouseButtonDown(0))
        {
            activeCarpet = true;
        }else if(activeCarpet && Functions.CheckDis(cursorObj, carpetObj, 1f) && Input.GetMouseButtonDown(0))
        {
            activeCarpet = false;
        }

        //determine the animation of carpet
        if (activeCarpet)
        {
            carpetAnim.SetTrigger("carpetUp");
        }
        else
        {
            carpetAnim.SetTrigger("carpetBack");
        }
        
    }

}
