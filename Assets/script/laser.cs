using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    //enemy_AI 2.0 movement
  public Transform startPos,pos1,pos2;
  public float speed;
  private Rigidbody rigid;
  private Vector3 nextPos;
  private float timer;
  //destroy
  public GameObject explosion;
  private void Awake()
  {
      rigid=GetComponent<Rigidbody>();
  }
  private void Start()
  {
    nextPos = startPos.position;
  }
  private void Update()
  {

     //move
    if(transform.position==pos1.position)
    {
      nextPos=pos2.position;
    }
    if(transform.position==pos2.position)
    {
        nextPos=pos1.position;
    }

    transform.position=Vector3.MoveTowards(transform.position,nextPos,speed*Time.deltaTime); 
  }
   private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag=="playerbullet"||other.tag=="Player")
      {
      if(GameObject.Find("Sphere")!=null)
      {
      GameObject.Find("Sphere").GetComponent<LineRenderer>().enabled=false;
      }
      Instantiate(explosion,transform.position,transform.rotation);
      scoreManger.score+=10;
      Destroy(other.gameObject);
      Destroy(this.gameObject);
      }
    }
}
