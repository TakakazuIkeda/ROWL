using UnityEngine;
using System.Collections;

// �����ŏ�����
public class DestroyTimeout : MonoBehaviour
{
    public float timer = 15.0f;
    void Start()
    {
        Destroy(gameObject, timer);
    }
}
