using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hidden : MonoBehaviour
{  
public Material[] mat;
  Renderer rend;

  void Start()
  {
    rend=GetComponent<Renderer>();
    rend.sharedMaterial=mat[0];
     StartCoroutine (Blink());
  }
 IEnumerator Blink()
    {
     yield return new WaitForSeconds (7);
     rend.sharedMaterial=mat[0];
     GetComponent<BoxCollider>().enabled=true;
     StartCoroutine(Blink1());
    }
    IEnumerator Blink1()
    {
     yield return new WaitForSeconds (3);
     rend.sharedMaterial=mat[1];
     GetComponent<BoxCollider>().enabled=false;
     StartCoroutine(Blink());
    } 
}

