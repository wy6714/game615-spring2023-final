using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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
}
