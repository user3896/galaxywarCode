using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserplayer : MonoBehaviour
{
  RaycastHit info;
  public LayerMask enemy;
  public GameObject death_effect;
 void Update()
 {
     if(Physics.Raycast(transform.position,transform.forward,out info,Mathf.Infinity))
     {
         GetComponent<LineRenderer>().SetPosition(0,transform.position);
         GetComponent<LineRenderer>().SetPosition(1,info.point);
         if(Physics.Raycast(transform.position,transform.forward,out info,Mathf.Infinity,enemy))
         {
            Instantiate(death_effect,info.point,Quaternion.identity);
            Destroy(info.transform.gameObject);
           scoreManger.score += 10;
         }
     }
 }

}

