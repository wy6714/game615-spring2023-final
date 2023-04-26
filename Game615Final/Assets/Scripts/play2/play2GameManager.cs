using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play2GameManager : MonoBehaviour
{
    public Animator collectAni;
    [SerializeField] private TransitToTangramScript transitSceneScript;
    [SerializeField] private GameObject slotTangram;


    void Start()
    {
        slotTangram.SetActive(false);
    }
    private void OnMouseDown()
    {
        collectAni.SetBool("isCollect", true);
        transitSceneScript.collectnum += 1;
        Invoke("showInSlot", 0.2f);
    }

    public void showInSlot()
    {
        slotTangram.SetActive(true);
        gameObject.SetActive(false);
    }
}
