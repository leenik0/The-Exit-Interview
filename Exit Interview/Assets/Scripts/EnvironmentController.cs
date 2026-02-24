using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

public class EnvironmentController : MonoBehaviour
{
    [SerializeField] private Light mainLight;
    [SerializeField] private Volume postProcessVolume;
    [SerializeField] private GameObject[] phase2Objects;
    [SerializeField] private GameObject[] phase3Objects;
    [SerializeField] private FlickeringLight flickeringLight;

    private Coroutine flickerCoroutine;

    private void Awake()
    {
        if (!flickeringLight)
            flickeringLight = mainLight.GetComponent<FlickeringLight>();
    }
    
    public void TransitionToPhase(int phase)
    {
        // if (flickerCoroutine != null)
        // {
        //     StopCoroutine(flickerCoroutine);
        //     flickerCoroutine = null;
        // }

        // switch (phase)
        // {
        //     case 2:
        //         foreach (var obj in phase2Objects) obj.SetActive(true);
        //         flickerCoroutine = StartCoroutine(FlickerLights());
        //         break;
        //     case 3:
        //         foreach (var obj in phase3Objects) obj.SetActive(true);
        //         flickerCoroutine = StartCoroutine(FlickerLights());
        //         break;
        // }
    }

    private IEnumerator FlickerLights()
    {
        while (true)
        {
            flickeringLight.Flicker();
            yield return null;
        }
    }

    private void SpawnExtraChairs() { /* ... */ }
}