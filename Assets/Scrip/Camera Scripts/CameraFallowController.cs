 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFallowController : MonoBehaviour
{
    [SerializeField] private Transform ballTransform;
    [SerializeField] private float lerpValue;
    private Vector3 offset;
    private Vector3 newPosition;
    void Start()
    {
        offset = transform.position - ballTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        SettCameraSmoothFollow();
    }

    private void SettCameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position,ballTransform.position + offset, lerpValue * Time.deltaTime);
        transform.position= newPosition;
    }
}
