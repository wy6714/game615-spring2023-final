using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class play1Door : MonoBehaviour
{
    public play1collectPinkTangram pinkScritpt;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite defaultSprite;
    [SerializeField] private Sprite openSprite;
    public TMP_Text wrongText;
    public GameObject smallTangram;
    public Animator smallTangramAni;

    [SerializeField] AudioSource doorOpenAudio;

    


    void Start()
    {
        smallTangram.SetActive(false);
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

        smallTangram.SetActive(true);

        smallTangramAni.SetBool("isCollect", true);
        doorOpenAudio.Play();
        Invoke("goScene2", 1.5f);
        
    }

    public void goScene2()
    {
        SceneManager.LoadScene("PlayScene2");
    }
}
