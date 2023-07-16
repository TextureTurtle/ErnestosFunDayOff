using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FunElevator : MonoBehaviour
{
    public Transform target;
    public int Maxheight = 8;
    public float RealSlider = 0;
    public static float SliderValue = 0;


    // BRO I HAVE NO FUCKING CLUE WHAT I AM DOING!!!!!!!!!!!!!
    void FixedUpdate()
    {
        RealSlider = Mathf.Clamp((SliderValue / 10), 0, 8);

        target.localPosition = new Vector3(0.0f, Mathf.Lerp(target.localPosition.y, RealSlider, 0.01f), 0.0f);

    }
}
