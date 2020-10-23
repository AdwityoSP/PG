using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    public float kecepatan = 2f;
    public float loncat = 1200f;
    private Transform mytransform;
    
    // Use this for initialization
    void Start()
    {
        this.mytransform = transform;
    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * 1f;

        mytransform.position += new Vector3(x, 0, 0);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            mytransform.GetComponent<Rigidbody2D>().AddForce(mytransform.up * loncat);
            Debug.Log("Lompat");
            GetComponent<AudioSource>().Play();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Kiri");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Kanan");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Jongkok");
        }


    }
}