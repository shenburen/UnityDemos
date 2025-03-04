using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Flamethrower : MonoBehaviour
{
    public VisualEffect flamethrower;

    void Start()
    {
        flamethrower.Stop();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            flamethrower.Play();
        }

        if (Input.GetMouseButtonUp(0))
        {
            flamethrower.Stop();
        }
    }
}
