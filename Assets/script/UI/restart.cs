using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class restart : MonoBehaviour
{
  public void Restart()
  {
    Time.timeScale=1;
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
}
