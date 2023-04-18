using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play1StartText : MonoBehaviour
{
    [SerializeField] private DialogueTrigger dialogueTrigger;
    //[SerializeField] private play1DialogueManager dialogueManager;
   
    // Start is called before the first frame update
    void Start()
    {
        dialogueTrigger.TriggerDialogue();
    }

    
}
