using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomAmbiente : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
