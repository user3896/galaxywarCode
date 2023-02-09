using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class play5 : MonoBehaviour
{
    public void Play_butn()
    {
        SceneManager.LoadScene("select");
        PlayerPrefs.SetInt("selectPlayer",5);
    }
}
