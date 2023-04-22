using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private bool dialogueStart;
    [SerializeField] private DialogueTrigger dialogueTrigger;

    void Start()
    {
        dialogueStart = false;
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("birdNet"))
        {
            dialogueStart = true;
            dialogueTrigger.TriggerDialogue();

            dialogueStart = false;

            Destroy(collision.gameObject, 1.5f);


        }
    }

}
