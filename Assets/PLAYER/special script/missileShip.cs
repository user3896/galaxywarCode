using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileShip : MonoBehaviour
{
    //missile
  public GameObject missile;
  public Transform misssile_pos;
  private float missile_wait;
  private bool missile_fire=false;
  private float missile_down=0;

//missile
void Update()
{
if(Input.GetMouseButtonDown(1))
      {
        missile_fire=true; 
      }
      if(missile_fire)
      {
       if(missile_down>=0)
       {
        missile_down-=Time.deltaTime;
       }
       else
       {
         missile_shot();
         missile_down=1;
         missile_fire=false;
       }
   } 
}
private void missile_shot()
    {
     Instantiate(missile,misssile_pos.position,misssile_pos.rotation*Quaternion.Euler(0,180,0));
    }
}

