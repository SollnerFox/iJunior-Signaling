using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SpawnedCube : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Destroy());
    }

    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
    }
}
