using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultScene : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene("StartScene");
    }
}
