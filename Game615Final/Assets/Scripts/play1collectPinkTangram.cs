using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play1collectPinkTangram : MonoBehaviour
{
    private bool activeTangram = false;
    [SerializeField] private Animator TangramAnim;
    [SerializeField] private GameObject cursorObj;
    [SerializeField] private GameObject tangramObj;
    [SerializeField] private GameObject pointerObj;

    void Start()
    {
        
    }


    void Update()
    {
        //click carpet to move it
        if (!activeTangram && Functions.CheckDis(cursorObj, tangramObj, 0.5f) && Input.GetMouseButtonDown(0))
        {
            activeTangram = true;
        }
        //else if (activeTangram && Functions.CheckDis(cursorObj, tangramObj, 1f) && Input.GetMouseButtonDown(0))
        //{
        //    activeTangram = false;
        //}

        //determine the animation of carpet
        if (activeTangram)
        {
            TangramAnim.SetBool("iscollect",true);
            pointerObj.SetActive(false);
            //parallelogram.SetActive(true);
        }
        //else
        //{
        //    TangramAnim.SetBool("iscollect", false);
        //    //parallelogram.SetActive(false);
        //}
    }
}
