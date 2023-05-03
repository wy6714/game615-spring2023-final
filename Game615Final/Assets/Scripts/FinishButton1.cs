using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishButton1 : MonoBehaviour
{
    //big triangle
    private bool checkBigTriangle;
    [SerializeField] private GameObject b1;//block1 green
    [SerializeField] private GameObject b12; // pink
    [SerializeField] private GameObject d1;//destination
    [SerializeField] private GameObject d12;

    //parallelogram
    [SerializeField] private GameObject b2;
    [SerializeField] private GameObject d2;

    //square
    [SerializeField] private GameObject b3;
    [SerializeField] private GameObject d3;

    //small triangle
    private bool checkSmalltriangle;
    [SerializeField] private GameObject b4;
    [SerializeField] private GameObject b42;
    [SerializeField] private GameObject d4;
    [SerializeField] private GameObject d42;

    //Middle Triange
    [SerializeField] private GameObject b5;
    [SerializeField] private GameObject d5;

    public void FinishButton()
    {
        //check big triangle
        bool checkObj11 = Functions.CheckDis(b1, d1,0.2f);
        bool checkObj12 = Functions.CheckDis(b1, d12, 0.2f);
        bool checkObj21 = Functions.CheckDis(b12, d1, 0.2f);
        bool checkObj22 = Functions.CheckDis(b12, d12, 0.2f);


        if ((checkObj11 && checkObj22) || (checkObj12 && checkObj21))
        {
            checkBigTriangle = true;
        }

        //check parallelogram
        bool checkParallelogram = Functions.CheckDis(b2, d2, 0.2f);

        //check square
        bool checkSquare = Functions.CheckDis(b3, d3, 0.2f);

        //check middle triangle
        bool checkObj41 = Functions.CheckDis(b4, d4, 0.2f);
        bool checkObj42 = Functions.CheckDis(b4, d42, 0.2f);
        bool checkObj24 = Functions.CheckDis(b42, d4, 0.2f);
        bool checkObj422 = Functions.CheckDis(b42, d42, 0.2f);

        if ((checkObj41 && checkObj422) || (checkObj42 && checkObj24))
        {
            checkSmalltriangle = true;
        }

        //check middle triangle
        bool checkMiddleTriangle = Functions.CheckDis(b5, d5, 0.2f);

        if(checkBigTriangle && checkParallelogram && checkSquare && checkSmalltriangle && checkMiddleTriangle)
        {
            Debug.Log("yes");
            SceneManager.LoadScene("menu");
        }



        //bool checkObj2 = Functions.CheckDis(b2, t2, 0.2f);
        //bool checkObj3 = Functions.CheckDis(b3, t3, 0.2f);

        //if (checkObj1 && checkObj2 && checkObj3)
        //{
        //    Debug.Log("yes!");// replace it with transfer to playscene2
        //}
    }
}
