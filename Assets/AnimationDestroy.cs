using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDestroy : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2f);
    }
}
