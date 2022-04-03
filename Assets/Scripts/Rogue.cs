using UnityEngine;

public class Rogue : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    [SerializeField] private float _movementLength = 15f;

    // Update is called once per frame
    private void Update()
    {
        var xCoord = Mathf.PingPong(_speed * Time.time, _movementLength);
        transform.position = new Vector3 (xCoord, transform.position.y, transform.position.z);
    }
}
