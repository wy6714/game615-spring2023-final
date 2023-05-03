using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField] private AudioSource bgm;
    [SerializeField] private GameObject creditPanel;
    void Start()
    {
        creditPanel.SetActive(false);
        bgm.Play();
    }

    
    void Update()
    {
        
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("PlayScene01");
    }

    public void CreditButton()
    {
        creditPanel.SetActive(true);
    }

    public void BackButton()
    {
        creditPanel.SetActive(false);
    }
}
