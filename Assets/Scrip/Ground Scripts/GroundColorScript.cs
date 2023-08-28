using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColorScript : MonoBehaviour
{
    [SerializeField] private Material groundMaterial;
    [SerializeField] private Color[] colors;
    private int colorIndex = 0;
    [SerializeField] private float lerpValue;
    [SerializeField] private float time;
    private float currentTime;

    // Update is called once per frame
    void Update()
    {
       SetColorChangeTime(); 
       SmoothColorChange();
    }

    private void SetColorChangeTime()
    {
        if(currentTime <= 0)
        {
            CheckColorIndexValue();
            currentTime = time;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }

    private void CheckColorIndexValue()
    {
        colorIndex++;
        if(colorIndex >= colors.Length)
        {
            colorIndex = 0;
        }
    }

    private void SmoothColorChange()
    {
        groundMaterial.color =Color.Lerp(groundMaterial.color, colors[colorIndex],lerpValue * Time.deltaTime);
    }

     private void OnDestroy() 
    {
        groundMaterial.color = colors[0];
    }
}
