using UnityEngine;
using System.Collections;

// 自動で消える
public class DestroyTimeout : MonoBehaviour
{
    public float timer = 15.0f;
    void Start()
    {
        Destroy(gameObject, timer);
    }
}
