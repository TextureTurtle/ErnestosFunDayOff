using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeDoor : MonoBehaviour
{
    public Transform target;
    public float OpenDoor = 8;

    // Code Storage Strings

    public string Code1A = "Blasphemy";
    public string Code2A = "Sand";
    public string Code3A = "Freddy";
    public string Code4A = "Stinkadoold";
    public string Code5A = "Scooter";

    // Code Player's Answer Strings

    public static string Code1;
    public static string Code2;
    public static string Code3;
    public static string Code4;
    public static string Code5;

    //Code BOOL

    public bool Code1BOOL;
    public bool Code2BOOL;
    public bool Code3BOOL;
    public bool Code4BOOL;
    public bool Code5BOOL;

    //Code Light

    public Light L1;
    public Light L2;
    public Light L3;
    public Light L4;
    public Light L5;

    // Start is called before the first frame update
    void OpenTime()
    {
        target.localPosition = new Vector3(Mathf.Lerp(target.localPosition.x, -10f, 0.01f), 0f, 0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Code1 == Code1A)
        {
            Code1BOOL = true;
            L1.color = Color.green;
        }
        else
        {
            Code1BOOL = false;
            L1.color = Color.red;
        };
        if (Code2 == Code2A)
        {
            Code2BOOL = true;
            L2.color = Color.green;
        }
        else
        {
            Code2BOOL = false;
            L2.color = Color.red;
        };
        if (Code3 == Code3A)
        {
            Code3BOOL = true;
            L3.color = Color.green;
        }
        else
        {
            Code3BOOL = false;
            L3.color = Color.red;
        };
        if (Code4 == Code4A)
        {
            Code4BOOL = true;
            L4.color = Color.green;
        }
        else
        {
            Code4BOOL = false;
            L4.color = Color.red;
        };
        if (Code5 == Code5A)
        {
            Code5BOOL = true;
            L5.color = Color.green;
        }
        else
        {
            Code5BOOL = false;
            L5.color = Color.red;
        };

        // Final door
        if (Code1BOOL == true && Code2BOOL == true && Code3BOOL == true && Code4BOOL == true && Code5BOOL == true)
        {
            OpenTime();
        }

    }
}
