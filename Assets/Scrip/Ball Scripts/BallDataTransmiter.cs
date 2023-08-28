using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDataTransmiter : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] private BallınputController ballInputController;


   public Vector3 GetBallDirection()
   {
    return ballInputController.ballDirection;
   }
}
