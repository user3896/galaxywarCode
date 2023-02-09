using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Quit : MonoBehaviour
{
  public void Quit_btn()
  {
      #if UNITY_EDITOR
      UnityEditor.EditorApplication.isPlaying=false;
      #else 
      Application.Quit();
      #endif
  }
}
