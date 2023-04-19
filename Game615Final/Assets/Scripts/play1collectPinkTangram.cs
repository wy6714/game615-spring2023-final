using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play1collectPinkTangram : MonoBehaviour
{
    public play1Fourgramcollect play1fourgram;
    public bool Play1activePinkTangram = false;
    private bool collectPink = false; //check for door, if pink collected
    [SerializeField] private Animator TangramAnim;
    [SerializeField] private GameObject cursorObj;
    [SerializeField] private GameObject tangramObj;
    [SerializeField] private GameObject pointerObj;
    [SerializeField] private GameObject DoorPointerObj;
    [SerializeField] private DialogueTrigger dialogueTrigger;
    //[SerializeField] private GameObject pinkTangramDialogue;

    //click door to solve puzzle
    [SerializeField] private GameObject doorObj;
    void Start()
    {
        DoorPointerObj.SetActive(false);
        //pinkTangramDialogue.SetActive(false);
    }

    void Update()
    {
        //click carpet to move it
        if (!Play1activePinkTangram && Functions.CheckDis(cursorObj, tangramObj, 0.5f) && Input.GetMouseButtonDown(0))
        {
            Play1activePinkTangram = true;
        }
    

        //determine the animation of carpet
        if (Play1activePinkTangram)
        {
            TangramAnim.SetBool("iscollect",true);
            pointerObj.SetActive(false);
            dialogueTrigger.TriggerDialogue();
            collectPink = true;
            Play1activePinkTangram = false;
            //set active dialogue game obejct
            //pinkTangramDialogue.SetActive(true);

        }


       

        //if collect both pink and four, show door
        if(play1fourgram.collectFour && collectPink)
        {
            DoorPointerObj.SetActive(true);
            
            //if collect pink and four, and click door -> show puzzle
            if(Functions.CheckDis(cursorObj,doorObj, 2f) && Input.GetMouseButtonDown(0))
            {

            }
        }

       
    }

}
