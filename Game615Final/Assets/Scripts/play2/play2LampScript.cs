using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play2LampScript : MonoBehaviour
{
    private bool on = false;

    [SerializeField] private Sprite offSprite;
    [SerializeField] private Sprite onSprite;

    [SerializeField] private SpriteRenderer spriteRenderer;



    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
    }


    void Update()
    {

    }
    private void OnMouseDown()
    {
        if (!on)
        {
            on = true;
            spriteRenderer.sprite = onSprite;
        }
        else
        {
            on = false;
            spriteRenderer.sprite = offSprite;
        }

    }


}
