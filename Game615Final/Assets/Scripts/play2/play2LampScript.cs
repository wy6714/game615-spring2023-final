using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class play2LampScript : MonoBehaviour
{
    private bool on = false;
    private bool pictureOn = false;
    public Button picturebutton;
    [SerializeField] private Animator LampPictureAni;
    [SerializeField] private Sprite buttonOffSprite;
    [SerializeField] private Sprite buttonOnSprite;

    [SerializeField] private Sprite offSprite;
    [SerializeField] private Sprite onSprite;

    [SerializeField] private SpriteRenderer spriteRenderer;

    public GameObject Tangram5Obj;
    //public bool collectPurple = false; // for final check transit to tangram




    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        Tangram5Obj.SetActive(false);
    }


    void Update()
    {
        if (on && pictureOn)
        {
            Tangram5Obj.SetActive(true);
            //collectPurple = true;
        }
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

    public void pictureButton()
    {
        if (!pictureOn)
        {
            picturebutton.image.sprite = buttonOnSprite;
            pictureOn = true;
            LampPictureAni.SetBool("isMove", true);
        }
        else
        {
            picturebutton.image.sprite = buttonOffSprite;
            pictureOn = false;
            LampPictureAni.SetBool("isMove", false);
        }
    }


}
