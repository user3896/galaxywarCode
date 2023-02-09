using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    //destroy
  public GameObject gameoverText;
  public GameObject gameoverImage;
  public GameObject restart;
  public GameObject main_menu;
  void Update()
  {
    if(GameObject.FindGameObjectWithTag("Player")==null)
    {
      gameoverImage.SetActive(true);
      gameoverText.SetActive(true);
      main_menu.SetActive(true);
      restart.SetActive(true);
    }
  }
}
