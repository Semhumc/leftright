using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollusionController : MonoBehaviour
{
   [SerializeField] private GroundDataTransmitter groundDataTransmitter;
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Score.score++;
            groundDataTransmitter.SetGroundRigidbodyValues();
        }
    }
    
    
    }
