using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public AudioSource moveSound; // Reference to the AudioSource component

    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        moveSound = GetComponent<AudioSource>();
    }

    public void Update()
    {
        bool isMoving = false;

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            isMoving = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
            isMoving = true;
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
            isMoving = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
            isMoving = true;
        }

        // Play the move sound if a movement key is pressed and the sound is not already playing
        if (isMoving && !moveSound.isPlaying)
        {
            moveSound.Play();
        }

        // Stop the move sound if no movement key is pressed
        if (!isMoving && moveSound.isPlaying)
        {
            moveSound.Stop();
        }
    }
}
