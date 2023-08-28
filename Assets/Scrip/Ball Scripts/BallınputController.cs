using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallınputController : MonoBehaviour
{
    public Vector3 ballDirection;
    AudioSource audioSource;
    void Start()
    {
       ballDirection = Vector3.left; 
       
    }

    // Update is called once per frame
    void Update()
    {
        audioSource = GetComponent<AudioSource>();
        HandleBallInputs();
    }

    private void HandleBallInputs()
    {
        if(Input.GetMouseButtonDown(0))
        {
           

            ChangeBallDirection();
        }
    }

    private void ChangeBallDirection()
    {
        if(ballDirection.x == -1)
        {
            ballDirection = Vector3.forward;
        }
        else
        {
            ballDirection = Vector3.left;
        }
    }
}
