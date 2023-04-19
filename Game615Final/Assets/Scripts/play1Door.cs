using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class play1Door : MonoBehaviour
{
    public play1collectPinkTangram pinkScritpt;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite defaultSprite;
    [SerializeField] private Sprite openSprite;
    public TMP_Text wrongText;

    


    void Start()
    {
        wrongText.enabled = false;
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = defaultSprite;

        

    }

    void Update()
    {
        if (pinkScritpt.clickDoor)
        {
            
            
        }
    }

    public void WrongButton()
    {
        wrongText.enabled = true;
    }

    public void RightButton()
    {
        wrongText.enabled = false;
        
        spriteRenderer.sprite = openSprite;
        
    }
}
