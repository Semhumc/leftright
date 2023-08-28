using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finsh : MonoBehaviour
{
    
    void Update()
    {
         if (transform.position.y <= -15f)
        {
            SceneManager.LoadScene(2);
        }
    }
}
