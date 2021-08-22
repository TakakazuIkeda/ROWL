using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{

    private void Start()
    {
        SoundManager.Instance.PlayBGMSound("VSQSE_0666_forest");
        CooperationJudge.Instance.CooperationInit();
    }

    public void StartGame()
    {
        // ゲーム本編のシーン名
        SceneManager.LoadScene("ROWL_Field");
    }
}
