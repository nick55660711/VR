using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManage : MonoBehaviour
{
    public void clean()
    {
        GameObject.Find("RawImage").GetComponent<RawImage>().enabled = false;
        GameObject.Find("TextUI").GetComponent<Text>().text = "";
    }




}
