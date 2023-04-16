using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class GameManager : MonoBehaviour
{
    public bool rotated;
    [SerializeField] private TMP_Text statueText;
    private Color32 rotatingColor = new Color32(173, 72, 59, 255);
    private Color32 movingColor = new Color32(59, 113, 44, 255);

   
    private void Update()
    {
        if (!rotated)
        {
            statueText.text = "Moving";
            statueText.color = movingColor;
        }
        else
        {
            statueText.text = "Rotating";
            statueText.color = rotatingColor;
            
        }
    }
    

    public void RotateButton()
    {
        if (rotated)
        {
            rotated = false;
        }
        else
        {
            rotated = true;
        }
      
    }

    

    public void instructionClose() //tangram scene1 instruction close button
    {
        GameObject instcurtion = GameObject.Find("Instruction");
        instcurtion.SetActive(false);
    }
}
