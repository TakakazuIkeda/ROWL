using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI DescriptionText;
    private void Awake()
    {
        this.gameObject.SetActive(false);
    }

    public void DisplayDialogue(string message)
    {
        this.gameObject.SetActive(true);
        DescriptionText.text = message;
    }

        // 自動で消える
    public class DestroyTimeout : MonoBehaviour
    {
        public float timer = 60.0f;
        void Start()
        {
            Destroy(gameObject, timer);
        }
    }

}

