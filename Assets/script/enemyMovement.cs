using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    //enemy movement 
    public GameObject bullet1;
    public Transform ps1;
    public float speed1;
    private Rigidbody rg2;
    private float enemyWait1=1f;
    //sound 
    private AudioSource Audio;
    //death
    public GameObject explosion1;

    void Awake()
    {
        rg2=GetComponent<Rigidbody>();
        Audio=GetComponent<AudioSource>();
    }

    void Update()
    {
        rg2.velocity = -transform.forward*speed1;
        enemyAttack1();
    }

    void enemyAttack1()
    {
       if(enemyWait1>0)
       {
          enemyWait1-=Time.deltaTime;
       }
       else
       {
           Instantiate(bullet1,ps1.transform.position,ps1.transform.rotation*Quaternion.Euler(0,-180,0));
           Audio.Play();
           enemyWait1=1;
       }
       
    }

    private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag=="playerbullet"||other.tag=="Player")
      {
      Instantiate(explosion1,transform.position,transform.rotation);
      scoreManger.score+=10;
      Destroy(other.gameObject);
      Destroy(this.gameObject);
      }
    }

}
