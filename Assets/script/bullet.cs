using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private float lifeTime=5f;
    private Rigidbody rg1;
    public float bulletSpeed;
   void Awake()
   {
      rg1=GetComponent<Rigidbody>();
   }

   void Update()
   {
       rg1.velocity=transform.forward*bulletSpeed;

       lifeTime-=Time.deltaTime;
       if(lifeTime<=0)
       {
           lifeTime=5;
           Destroy(this.gameObject);
       }
   }
}
