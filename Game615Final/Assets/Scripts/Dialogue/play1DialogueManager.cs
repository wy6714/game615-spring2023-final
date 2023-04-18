using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class play1DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    private Queue<string> sentences;
    public Animator textBoxAni;
    public Animator textPanelAni;
   

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        //load UI
        textBoxAni.SetBool("isOpen", true);
        textPanelAni.SetBool("isOpen", true);

        Debug.Log("Start Conversation With: " + dialogue.name);

        //clear previous sentences
        sentences.Clear();

        //put sentences array elements in queue
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        //show sentences
        DisplayNextSentence();

        
       
    }

    //show sentences method
    public void DisplayNextSentence()
    {
        //check if there has next sentence
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();//sentence will be each dequeue elements

        //StopAllCoroutines();//in case there are other animation are showing
        //StartCoroutine(TypeSentence(sentence));
        Debug.Log(sentence);

        //diaplay each queue sentence on the text
        dialogueText.text = sentence;
        
    }

    ////show sentence letter by letter
    //IEnumerator TypeSentence(string sentence)
    //{
    //    dialogueText.text = "";
    //    foreach(char letter in sentence.ToCharArray())
    //    {
    //        dialogueText.text += letter;
    //        yield return null;//call each frame
    //    }
    //}

    void EndDialogue()
    {
        Debug.Log("conversation end");
        textBoxAni.SetBool("isOpen", false);
        textPanelAni.SetBool("isOpen", false);
    }

}
