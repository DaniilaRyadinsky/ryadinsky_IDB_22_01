using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject CUBE;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Button_click()
    {
        if (CUBE.activeSelf)
        {
            CUBE.SetActive(false);
            Debug.Log("annigilation");
        }

        else
        {
            CUBE.SetActive(true);
            Debug.Log("reincarnation");
        }
            
       
    }
}
