using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public float speed;
    private Transform vec;
    private Vector3 nextPos;
    public GameObject mesh;
 private void Update()
 {
    if(GameObject.FindWithTag("Player")!=null)
    {
    nextPos=new Vector3(GameObject.FindWithTag("Player").transform.position.x,6,-32.9f);
    transform.position=Vector3.MoveTowards(transform.position,nextPos,speed*Time.deltaTime);
    }
     
 }
}
