using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangramScript : MonoBehaviour
{
    public GameManager gm;
    public bool selected;

    private void Update()
    {
        if (selected)
        {
            gm.posWithMouse(gameObject);
            transform.localScale = new Vector3(6f, 6f, 6f);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            selected = true;
        }
    }

    private void OnMouseUp()
    {
        selected = false;
    }
}
