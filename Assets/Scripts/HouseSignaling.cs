using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class HouseSignaling : MonoBehaviour
{
    [SerializeField] private AudioSource _signal;

    private void Start() 
    {
        _signal.volume = 0f;    
    }

    private void OnTriggerStay(Collider other) 
    {
        if (other.TryGetComponent<Rogue>(out Rogue rogue))
        {
            _signal.Play();
            _signal.volume = Mathf.PingPong(1f, 0.00005f);
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
