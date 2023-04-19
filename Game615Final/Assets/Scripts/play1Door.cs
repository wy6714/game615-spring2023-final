using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class play1Door : MonoBehaviour
{
    //[SerializeField] private DialogueTrigger dialogueTrigger;
    //void Start()
    //{
    //    dialogueTrigger.TriggerDialogue();
    //}
    public TMP_Text wrongText;
    void Start()
    {
        wrongText.enabled = false;
    }

    public void WrongButton()
    {
        wrongText.enabled = true;
    }

    public void RightButton()
    {
        wrongText.enabled = false;
    }
}
