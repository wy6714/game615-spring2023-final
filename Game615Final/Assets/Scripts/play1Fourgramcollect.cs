using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play1Fourgramcollect : MonoBehaviour
{
    public bool play1activefourTangram = false;
    [SerializeField] private Animator TangramAnim;
    [SerializeField] private GameObject cursorObj;
    [SerializeField] private GameObject tangramObj;
    


    void Update()
    {
        //click carpet to move it
        if (!play1activefourTangram && Functions.CheckDis(cursorObj, tangramObj, 0.5f) && Input.GetMouseButtonDown(0))
        {
            play1activefourTangram = true;
        }
      

        //determine the animation of carpet
        if (play1activefourTangram)
        {
            TangramAnim.SetBool("iscollect", true);
         
        }

    }
}
