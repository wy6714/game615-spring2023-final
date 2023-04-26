using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitToTangramScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int collectnum = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(collectnum > 2)
        {
            Invoke("gotoTangramScene", 1f);
        }

    }

    public void gotoTangramScene()
    {
        SceneManager.LoadScene("Tangram01");
    }
}
