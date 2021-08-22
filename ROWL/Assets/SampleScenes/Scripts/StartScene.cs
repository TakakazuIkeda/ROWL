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
        // �Q�[���{�҂̃V�[����
        SceneManager.LoadScene("ROWL_Field");
    }
}
