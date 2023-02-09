using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class play4 : MonoBehaviour
{
  public void Play_button()
  {
    SceneManager.LoadScene("select");
    PlayerPrefs.SetInt("selectPlayer",4);
  }
}
