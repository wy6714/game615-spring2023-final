using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play1Door : MonoBehaviour
{
    [SerializeField] private DialogueTrigger dialogueTrigger;
    void Start()
    {
        dialogueTrigger.TriggerDialogue();
    }
}
