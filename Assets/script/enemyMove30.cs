using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove30 : MonoBehaviour
{
  
  //laser fire
  public GameObject death;
  private RaycastHit hit;
  public LayerMask player;
  private float val=0;
  public GameObject sphere;
    void Start()
    {
     StartCoroutine (Blink());
    }
    void Update()
    {
      laser_shot();
    }
    IEnumerator Blink()
    {
     yield return new WaitForSeconds (3);
     sphere.SetActive(true);
     val=1;     
     laser_shot();
     StartCoroutine(Blink1());
    }
        IEnumerator Blink1()
    {
     yield return new WaitForSeconds (1);
     val=0;
     sphere.SetActive(false);
     StartCoroutine(Blink());
    } 
    
  void laser_shot()
  {
    
     if(Physics.Raycast(sphere.transform.position,sphere.transform.forward,out hit,Mathf.Infinity))
     {
       sphere.GetComponent<LineRenderer>().enabled=true;
       sphere.GetComponent<LineRenderer>().SetPosition(1,hit.point);
       sphere.GetComponent<LineRenderer>().SetPosition(0,transform.position);
       if(Physics.Raycast(sphere.transform.position,sphere.transform.forward,out hit,Mathf.Infinity,player)&&val==1)
       {
         Instantiate(death,hit.point,Quaternion.identity);
         Destroy(GameObject.FindGameObjectWithTag("Player"));
       }
     }
  
    }
  

}

