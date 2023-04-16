using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{

    public void rotateWithMouse(GameObject block)

    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 TargetPos = new Vector2(mousePos.x - block.transform.position.x, mousePos.y - block.transform.position.y);
        block.transform.up = TargetPos;
    }

    public void posWithMouse(GameObject block)
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.z = 0f;
        block.transform.position = mousePos;
    }
    public static bool CheckDis(GameObject gobj1, GameObject gobj2,float dis)
    {
        Vector2 gobj1Pos = gobj1.transform.position;
        Vector2 gobj2Pos = gobj2.transform.position;

        float distance = Vector2.Distance(gobj1Pos, gobj2Pos);

        if (distance < dis)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}