using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile : MonoBehaviour
{
    public float speed;
    private Rigidbody rg;
    private Transform enemy;
    public GameObject enemyobj;
  void Start()
  {
    rg=GetComponent<Rigidbody>();
    enemy=GameObject.FindGameObjectWithTag("Enemy").transform;
    
  }
  void Update ()
  {
    if(enemy!=null)
    {
    transform.LookAt(enemy.position);
    }
    rg.velocity=transform.forward*speed;
    
  }
  private void OnTriggerEnter(Collider other)
    {
      if(other.tag=="Enemy"||other.tag=="laserenemy")
      {
       Destroy(this.gameObject);
      }
    }
}
