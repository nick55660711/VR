using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

   public void Move()
    {
        GetComponent<Rigidbody>().AddForce(4, 4, 0);


    }



}
