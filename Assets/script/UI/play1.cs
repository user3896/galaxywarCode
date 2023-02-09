using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class play1 : MonoBehaviour
{
    public void Play_btn()
    {
      SceneManager.LoadScene("select");
      PlayerPrefs.SetInt("selectPlayer",2);
    }
}
