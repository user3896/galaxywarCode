using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class next1 : MonoBehaviour
{
  public GameObject cam;
  public Transform cam1;

  public void nextbuton()
    {
    cam.transform.position=cam1.transform.position;
    }
}
