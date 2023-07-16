using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WordBridge : MonoBehaviour
{
    public Transform target;
    public static string Words = " ";
    public Text Text;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Words != null)
        {
            Text.text = Words;
        }
        else
        {
            Text.text = " ";
        }

        target.localScale = new Vector3(1f, 1f, Words.Length);
    }
}
