using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour
{
public Transform[] enemySpawner;
public GameObject enemy;
public int wait;

void Start()
{
    InvokeRepeating("Spawnenemy",3,wait);
}
 void Spawnenemy()
 {
     if(GameObject.FindWithTag("Player")==null)
     {
      return;
     }
     int index=Random.Range(0,enemySpawner.Length);
     if(enemy.gameObject.tag=="laserenemy")
     {
      Instantiate(enemy,enemySpawner[index].position,enemySpawner[index].rotation*Quaternion.Euler(0,180,0));
     }
     else
     {
       Instantiate(enemy,enemySpawner[index].position,enemySpawner[index].rotation);
     }
     
 }
}
