using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprintenemy : MonoBehaviour
{
    //enemy movement 
    public GameObject bullet;
    public Transform ps;
    public float speed;
    private Rigidbody rg3;
    private float enemyWait1=1f;
    //sound 
    private AudioSource Audio;
    //death
    public GameObject explosion;

    void Awake()
    {
        rg3=GetComponent<Rigidbody>();
        Audio=GetComponent<AudioSource>();
    }

    void Update()
    {
        rg3.velocity = -transform.forward*speed;
        enemyAttack();
       transform.Rotate(new Vector3(0f, 0f, 1f));
    }

    void enemyAttack()
    {
       if(enemyWait1>0)
       {
          enemyWait1-=Time.deltaTime;
       }
       else
       {
           Instantiate(bullet,ps.transform.position,ps.transform.rotation*Quaternion.Euler(0,-180,0));
           Audio.Play();
           enemyWait1=1;
       }
       
    }

    private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag=="playerbullet"||other.tag=="Player")
      {
      Instantiate(explosion,transform.position,transform.rotation);
      scoreManger.score+=10;
      Destroy(other.gameObject);
      Destroy(this.gameObject);
      }
    }



   
}   
   
    

