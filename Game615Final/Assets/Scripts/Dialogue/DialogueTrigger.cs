using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    //public play1DialogueManager dm;

    public void TriggerDialogue()
    {
        FindObjectOfType<play1DialogueManager>().StartDialogue(dialogue);
        //dm.StartDialogue(dialogue);
    }
}
