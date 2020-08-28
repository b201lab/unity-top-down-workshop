using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnDestroy : MonoBehaviour
{
    public GameObject prefab;

    void OnDestroy() {
      if (prefab != null) {
        Instantiate(prefab);
      }
    }
}
