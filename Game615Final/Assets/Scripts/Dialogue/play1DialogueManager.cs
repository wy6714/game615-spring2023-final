using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class play1DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    private Queue<string> sentences;
   

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
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
        Debug.Log(sentence);

        //diaplay each queue sentence on the text
        dialogueText.text = sentence;
        
    }

    void EndDialogue()
    {
        Debug.Log("conversation end");
    }

}
