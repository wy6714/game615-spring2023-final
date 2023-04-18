using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play1DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        //clear previous sentences
        sentences.Clear();

        //put sentences array elements in queue
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        //show sentences
        DisplayNextSentence();

        //load UI
       
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
        
    }

    void EndDialogue()
    {
        Debug.Log("conversation end");
    }

}
