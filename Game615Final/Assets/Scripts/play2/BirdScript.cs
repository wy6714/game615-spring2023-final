using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{


    [SerializeField] private GameObject SquareTan;
    [SerializeField] private DialogueTrigger dialogueTrigger;

    [SerializeField] private Animator responseAni;
    //public bool collectBird = false;
    public string colldeSrting;

    private bool collectsquare;

    void Start()
    {

        SquareTan.SetActive(false);
        collectsquare = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(colldeSrting) && !collectsquare)
        {
            responseAni.SetBool("isTalk", true);

            dialogueTrigger.TriggerDialogue();
            //Destroy(collision.gameObject, 1.5f);
            collectsquare = true;


            Invoke("showupSquare", 3f);

        }
    }

    public void showupSquare()
    {
        SquareTan.SetActive(true);
        //collectBird = true;
    }

}
