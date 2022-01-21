using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

   [SerializeField] private Transform _char;

    private void Update()
    {
        transform.position = new Vector3(_char.position.x, _char.position.y, transform.position.z);
    }
}
