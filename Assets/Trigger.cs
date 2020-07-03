using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{




    public void gun ( float a)
    {
        transform.Rotate(a, 0, 0);
    }
}