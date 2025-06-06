using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartController : MonoBehaviour
{
   
    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }


}
