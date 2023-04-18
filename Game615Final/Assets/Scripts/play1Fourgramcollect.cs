using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play1Fourgramcollect : MonoBehaviour
{
    private bool activeTangram = false;
    [SerializeField] private Animator TangramAnim;
    [SerializeField] private GameObject cursorObj;
    [SerializeField] private GameObject tangramObj;
    


    void Update()
    {
        //click carpet to move it
        if (!activeTangram && Functions.CheckDis(cursorObj, tangramObj, 0.5f) && Input.GetMouseButtonDown(0))
        {
            activeTangram = true;
        }
      

        //determine the animation of carpet
        if (activeTangram)
        {
            TangramAnim.SetBool("iscollect", true);
            
            
        }
      
    }
}
