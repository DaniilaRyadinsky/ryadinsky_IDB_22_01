using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class lesson2 : MonoBehaviour
{
    public float speed = 10f;
    public GameObject cube;
    public GameObject cam;
    public GameObject bcam;
    public int c = 6;
    public Text x;
    void Start()
    {
        bcam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 5 * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 5 * speed * Time.deltaTime);
        }

        if (c <= 0)
        {
            cam.SetActive(false);
            bcam.SetActive(true);
            x.text = "game over";
        }
        else x.text = c.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        c--;
    }
    public void heal()
    {
        c = 6;
    }
}
