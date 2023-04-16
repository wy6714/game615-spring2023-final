using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishButton1 : MonoBehaviour
{
    [SerializeField] private GameObject b1;//block1
    [SerializeField] private GameObject t1;//target1

    [SerializeField] private GameObject b2;
    [SerializeField] private GameObject t2;

    [SerializeField] private GameObject b3;
    [SerializeField] private GameObject t3;

    public void FinishButton()
    {
        bool checkObj1 = GameManager.CheckDis(b1, t1);
        bool checkObj2 = GameManager.CheckDis(b2, t2);
        bool checkObj3 = GameManager.CheckDis(b3, t3);

        if (checkObj1 && checkObj2 && checkObj3)
        {
            Debug.Log("yes!");// replace it with transfer to playscene2
        }
    }
}
