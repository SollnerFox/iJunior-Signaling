using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class HouseSignaling : MonoBehaviour
{
    [SerializeField] private AudioSource _signal;
    [SerializeField] private float _volumeAmplitudeSpeed;

    private void Start() 
    {
        _signal.volume = 0f;    
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.TryGetComponent<Rogue>(out Rogue rogue))
        {
            _signal.Play();
        }
        
    }

    private void OnTriggerStay(Collider other) 
    {
        if (other.TryGetComponent<Rogue>(out Rogue rogue))
        {
            _signal.volume = Mathf.PingPong(Time.time * _volumeAmplitudeSpeed, 1f);
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if (other.TryGetComponent<Rogue>(out Rogue rogue))
        {
            _signal.Stop();
        }   
    }
}
