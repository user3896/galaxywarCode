using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next : MonoBehaviour
{
   public GameObject cam;
   public GameObject camPos1;
   public void Next()
   {
    cam.transform.position=camPos1.transform.position;
   }
}
