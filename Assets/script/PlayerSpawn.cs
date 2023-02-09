using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    //selectPlayer
  public GameObject player1;
  public GameObject player2;
  public GameObject player3;
  public GameObject player4;
  public GameObject player5;
  public GameObject spawn;

  void Start()
  {
      if(PlayerPrefs.GetInt("selectPlayer",1)==1)
      {
        Instantiate(player1,spawn.transform.position,spawn.transform.rotation*Quaternion.Euler(0,180,0));
      }
      else if(PlayerPrefs.GetInt("selectPlayer",2)==2)
      {
          Instantiate(player2,spawn.transform.position,spawn.transform.rotation);
      }
      else if(PlayerPrefs.GetInt("selectPlayer",3)==3)
      {
        Instantiate(player3,spawn.transform.position,spawn.transform.rotation);
      }
      else if(PlayerPrefs.GetInt("selectPlayer",4)==4)
      {
        Instantiate(player4,spawn.transform.position,spawn.transform.rotation);
      }
      else if(PlayerPrefs.GetInt("selectPlayer",5)==5)
      {
        Instantiate(player5,spawn.transform.position,spawn.transform.rotation);
      }
  }
}
