using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScript : MonoBehaviour
{
    public Functions fc;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite cursorSprite;
    [SerializeField] private Sprite checkSprite;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        fc.posWithMouse(gameObject);
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
      
        if (collision.gameObject.CompareTag("item"))
        {
            spriteRenderer.sprite = checkSprite;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("item"))
        {
            spriteRenderer.sprite = cursorSprite;
        }
    }
}
