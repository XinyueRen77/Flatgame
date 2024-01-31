using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(0.05f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += new Vector3(-0.05f, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0, 0.05f, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, -0.05f, 0);
        }
    }
}