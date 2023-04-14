using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangramScript : MonoBehaviour
{
    public GameManager gm;
    public bool selected;
    
    [SerializeField] private GameObject TangramObj;

    private void Update()
    {
        if (selected && !gm.rotated)
        {
            gm.posWithMouse(gameObject);
            transform.localScale = new Vector3(6f, 6f, 6f);
          
        }

        if (selected && gm.rotated)
        {
            gm.rotateWithMouse(gameObject);
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
