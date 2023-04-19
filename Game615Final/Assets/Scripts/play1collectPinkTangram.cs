using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play1collectPinkTangram : MonoBehaviour
{
    public play1Fourgramcollect play1fourgram;
    public bool Play1activePinkTangram = false;
    private bool showtext = false;
    //private bool dialogueTriggered = false;
    [SerializeField] private Animator TangramAnim;
    [SerializeField] private GameObject cursorObj;
    [SerializeField] private GameObject tangramObj;
    [SerializeField] private GameObject pointerObj;
    [SerializeField] private GameObject DoorPointerObj;
    [SerializeField] private DialogueTrigger dialogueTrigger;
    void Start()
    {
        DoorPointerObj.SetActive(false);
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
            
            showtext = true;
            //parallelogram.SetActive(true);
            
        }

        if (showtext)
        {
            dialogueTrigger.TriggerDialogue();
            showtext = false;
        }

        //if collect both pink and four, show door
        if(play1fourgram.play1activefourTangram && Play1activePinkTangram)
        {
            DoorPointerObj.SetActive(true);
        }

       
    }

}
