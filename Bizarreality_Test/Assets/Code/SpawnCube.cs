using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    public GameObject cube;
   
    public void Spawn()
    {
        cube.SetActive(true);
        gameObject.SetActive(false);
    }
}
