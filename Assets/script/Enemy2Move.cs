using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Move : MonoBehaviour
{
  //enemy_AI 2.0 movement
  public Transform startPos,pos1,pos2;
  public float speed;
  private Rigidbody rigid;
  private Vector3 nextPos;
  private float timer;
  private float enemyWait=1;
  public GameObject bullet;
  public Transform ps;
  //sound
  private AudioSource aud;
  //destroy
  public GameObject explosion;
  private void Awake()
  {
      rigid=GetComponent<Rigidbody>();
      aud=GetComponent<AudioSource>();
  }
  private void Start()
  {
    nextPos = startPos.position;
  }
  private void Update()
  {
     
    if(transform.position==pos1.position)
    {
      nextPos=pos2.position;
    }
    if(transform.position==pos2.position)
    {
        nextPos=pos1.position;
    }

    transform.position=Vector3.MoveTowards(transform.position,nextPos,speed*Time.deltaTime); 
       
     enemyAttack();   
  }

    void enemyAttack()
    {
       if(enemyWait>0)
       {
          enemyWait-=Time.deltaTime;
       }
       else
       {
           Instantiate(bullet,ps.transform.position,ps.transform.rotation*Quaternion.Euler(0,-180,0));
           aud.Play();
           enemyWait=1;
       }
       
    }

    private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag!="enemybullet")
      {
      Instantiate(explosion,transform.position,transform.rotation);
      scoreManger.score+=10;
      Destroy(other.gameObject);
      Destroy(this.gameObject);
      }
    }
}
