using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnDisappear : MonoBehaviour
{
    void OnBecameInvisible() {
      Destroy(gameObject);
    }
}
