using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Play : MonoBehaviour
{
    public void Play_btn()
    {
      SceneManager.LoadScene("select");
      PlayerPrefs.SetInt("selectPlayer",1);
    }
}
