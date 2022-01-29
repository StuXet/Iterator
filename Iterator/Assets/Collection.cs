using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    [Header("Gizmo Ray")]
    [Range(0f, 10f)]
    public float range = 5;

    private void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Vector3 direction = transform.TransformDirection(Vector3.forward) * range;
        Gizmos.DrawRay(transform.position, direction);
    }
}
