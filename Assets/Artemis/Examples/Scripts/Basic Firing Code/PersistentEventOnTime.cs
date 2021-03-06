using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PersistentEventOnTime : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onFire;
    [Space]
    [SerializeField]
    [Range(0.1f, 3.0f)]
    private float timeBetweenFires = 3.0f;
    private float timer;
    void Start()
    {
        timer = 0;
    }

    void OnEnable()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < timeBetweenFires)
        {
            timer += Time.deltaTime;
            if(timer >= timeBetweenFires)
            {
                onFire?.Invoke();
                timer = 0;
            }
        }
    }

}
