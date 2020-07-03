using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpenDoor : MonoBehaviour
{
    public bool isOpen;
    public bool isAct;

    public void Open()
    {
        if (!isOpen)
        {

            if (transform.eulerAngles.y < 89)
            {
                transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);
            }

            if (transform.eulerAngles.y > 89)
            {
                transform.eulerAngles = Vector3.up * 90;
                isOpen = true;
                isAct = false;
            }

        }

        else
        {
            if (transform.eulerAngles.y > 1 && isOpen)
            {
                transform.Rotate(new Vector3(0, -90, 0) * Time.deltaTime);
            }

            if ((transform.eulerAngles.y < 1 || transform.eulerAngles.y > 345) && isOpen)
            {
                transform.eulerAngles = Vector3.zero;
                isOpen = false;
                isAct = false;
            }
        }
    }
   

    public void trigger()
    {
        isAct = true;
    }
    
    private void Update()
    {  
        if (isAct)
        {
        Open();
        }
       
      
    }


}
