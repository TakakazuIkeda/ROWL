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

        // é©ìÆÇ≈è¡Ç¶ÇÈ
    public class DestroyTimeout : MonoBehaviour
    {
        public float timer = 60.0f;
        void Start()
        {
            Destroy(gameObject, timer);
        }
    }

}

