using UnityEngine;
using UnityEngine.Playables;

public class TriggerTimeline : MonoBehaviour
{

    public PlayableDirector PlayableDirector;
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {

            PlayableDirector.Play();
            

            
            
        }
    }
}