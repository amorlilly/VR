using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColliderTrigger : MonoBehaviour
{
    public string TargetName = "";

    public UnityEvent Event = new UnityEvent();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (TargetName != "")
        {
            if (!other.name.Equals(TargetName))
                return;
        }

        Event.Invoke();
    }


}
