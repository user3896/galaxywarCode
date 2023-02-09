using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowe : MonoBehaviour
{
    private float sayac=0;
    public float slowSpeed;
    public GameObject playerbullet;
private void Update()
{
    
    //herkes yavaşlıyo
    if(Input.GetKey(KeyCode.F))
    {
        sayac+=1;
        if(sayac%2!=0)
        {
          Time.timeScale=slowSpeed;
        }
        else
        {
            Time.timeScale=1;
        }
    }
}
}
