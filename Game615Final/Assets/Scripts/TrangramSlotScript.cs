using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrangramSlotScript : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite defaultSprite;
    [SerializeField] private Sprite clickSprite;
    [SerializeField] private Sprite hoverSprite;
    [SerializeField] private GameObject TangramGObj;
    public GameManager gm;
    
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter()
    {
        spriteRenderer.sprite = hoverSprite;
    }

    private void OnMouseExit()
    {
        spriteRenderer.sprite = defaultSprite;
    }

    


}
