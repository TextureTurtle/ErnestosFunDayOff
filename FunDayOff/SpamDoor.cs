using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpamDoor : MonoBehaviour
{
    public Transform target;
    public Text text;
    public int NumberTarget = 100;
    public int CycleCount = 0;
    public int FinalNumber = 0;
    public static bool IsOn = false;
    public bool PreviousBool = false;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (IsOn != PreviousBool)
        {
            PreviousBool = IsOn;

            CycleCount++;

            FinalNumber = Mathf.Clamp((NumberTarget - CycleCount), 0, NumberTarget);

            text.text = "" + FinalNumber;

            if (FinalNumber == 0)
            {
                text.color = Color.green;
            }
        }

        target.localPosition = new Vector3(0.0f, Mathf.Lerp(target.localPosition.y, Mathf.Clamp((CycleCount), 0, NumberTarget)/ (NumberTarget/4), 0.01f), 0.0f);
    }
}
