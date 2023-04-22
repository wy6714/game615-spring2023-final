using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdNetScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Functions fc;
    private bool selected;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (selected)
        {
            fc.posWithMouse(gameObject);
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
