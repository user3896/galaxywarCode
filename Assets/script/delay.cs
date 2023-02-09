using UnityEngine;
using System.Collections;

public class delay : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(AdimAdımIsinla(1,new Vector3(0,1,1)));
    }
      IEnumerator AdimAdımIsinla (int adim, Vector3 yon) {
        for (int i = 0; i < adim; i++) {
            transform.position += yon;
            yield return new WaitForSeconds (5f);
        }
    }
}