using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private bool dialogueStart;
    [SerializeField] private GameObject SquareTan;
    [SerializeField] private DialogueTrigger dialogueTrigger;

    private bool collectsquare;

    void Start()
    {
        dialogueStart = false;
        SquareTan.SetActive(false);
        collectsquare = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("birdNet") && !collectsquare)
        {
            dialogueStart = true;
            dialogueTrigger.TriggerDialogue();

            dialogueStart = false;

            //Destroy(collision.gameObject, 1.5f);
            collectsquare = true;


            Invoke("showupSquare", 3f);

        }
    }

    public void showupSquare()
    {
        SquareTan.SetActive(true);
    }

}
