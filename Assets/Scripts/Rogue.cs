using UnityEngine;

public class Rogue : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _movementMagnitude;

    // Update is called once per frame
    private void Update()
    {
        var xCoord = Mathf.Sin(Time.time * _speed) * _movementMagnitude ;
        transform.position = new Vector3 (xCoord, 0.5f, 0f);
    }
}
