using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scoreManger : MonoBehaviour
{
   public static int score;
   private Text youText;
   private void Awake()
   {
       youText=GetComponent<Text>();
   }
   private void Start()
   {
       score=0;
    }

   private void Update()
   {
       youText.text="Score :  "+score;
   }
}
