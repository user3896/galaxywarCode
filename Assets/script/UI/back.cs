using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour
{
   public GameObject cam;
   public GameObject camPos1;
   public void Back()
   {
    cam.transform.position=camPos1.transform.position;
   }
}
