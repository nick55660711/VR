using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public GameObject Camera;
    public Transform GunPoint;


    public void shoot()
    {
        GameObject BulletAll;
        BulletAll = Instantiate(bullet, GunPoint.position, GunPoint.rotation);
        BulletAll.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
        BulletAll.GetComponent<Rigidbody>().AddForce(transform.up * 70, ForceMode.Force);
        Destroy(BulletAll, 5);
    }
    private void Update()
    {
        if (Input.GetKeyDown("t"))
        {

            GameObject BulletAll;
            BulletAll = Instantiate(bullet, GunPoint.position, GunPoint.rotation);
            BulletAll.GetComponent<Rigidbody>().AddForce(transform.forward*2000 );
            BulletAll.GetComponent<Rigidbody>().AddForce(transform.up*70 ,ForceMode.Force);
            
            
        }
    }






}
