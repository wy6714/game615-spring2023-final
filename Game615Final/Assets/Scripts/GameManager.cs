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
    public void rotateWithMouse(GameObject block)

    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 TargetPos = new Vector2(mousePos.x - block.transform.position.x, mousePos.y - block.transform.position.y);
        block.transform.up = TargetPos;
    }

    public void posWithMouse(GameObject block)
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.z = 0f;
        block.transform.position = mousePos;
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

    public void FinishButton()
    {

    }
}
