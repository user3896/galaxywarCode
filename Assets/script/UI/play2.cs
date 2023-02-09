using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class play2 : MonoBehaviour
{
   public void play_btn()
   {
      SceneManager.LoadScene("select");
      PlayerPrefs.SetInt("selectPlayer",3);
   }
}
