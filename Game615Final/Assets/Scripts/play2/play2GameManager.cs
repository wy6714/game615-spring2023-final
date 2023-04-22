using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play2GameManager : MonoBehaviour
{
    public Animator collectAni;


    void Start()
    {

    }
    private void OnMouseDown()
    {
        collectAni.SetBool("isCollect", true);
    }
}
