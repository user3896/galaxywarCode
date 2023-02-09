using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player3 : MonoBehaviour
{


  //bullet fire
  private bool fire=false;
  private float sayac=0;
  private float coolDown=0.4f;
  public GameObject bullet;
  public Transform spawnPos;
  public Transform spawnPos1;
  //player move
  public float rot;
  public float minX,minZ,maxX,maxZ;
  private Vector3 playerMove;
  public float speed;
  private Rigidbody rg;
  //fire sound
  public AudioClip fireSound;
  //death
  public GameObject explosion;
  public GameObject gameoverText;
  public GameObject gameoverImage;
  public GameObject restart;
  public GameObject main_menu;
   void Start()
   {
     //burda public yapıp içine rigidbody sürükleme ile aynı olayı yaptı
     rg= GetComponent<Rigidbody>();
   }
    private void Update()
    {
    
      //player move
      float h = Input.GetAxisRaw("Horizontal");
      float v = Input.GetAxisRaw("Vertical");

      playerMove.Set(h,0,v);
      //bullet fire
      if(Input.GetMouseButtonDown(0))
      {
        sayac+=1;
        fire=true;
      }
      if(fire)
      {
        if(coolDown>0)
        {
          coolDown-=Time.deltaTime;
        }
        else
        {
          shot();
          coolDown=0.4f;
          fire=false;
        }
      }

      
       
  

      playerMove=playerMove * speed * Time.deltaTime;

      rg.MovePosition(transform.position+playerMove);
      rg.position=new Vector3(Mathf.Clamp(rg.position.x,minX,maxX),0,Mathf.Clamp(rg.position.z,minZ,maxZ));
      //rg.rotation=Quaternion.Euler(0,0,-transform.position.x*rot);
    } 

    private  void shot()
    {
        Instantiate(bullet,spawnPos.position,spawnPos.rotation);
        Instantiate(bullet,spawnPos1.position,spawnPos1.rotation);          
        GetComponent<AudioSource>().PlayOneShot(fireSound);
        coolDown=0.4f;
    }

    private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag!="playerbullet"&&other.gameObject.tag!="Player")
      {
      Instantiate(explosion,transform.position,transform.rotation);
      gameoverImage.SetActive(true);
      gameoverText.SetActive(true);
      main_menu.SetActive(true);
      restart.SetActive(true);
      Destroy(other.gameObject);
      Destroy(this.gameObject);
      }
    }

 

}
 