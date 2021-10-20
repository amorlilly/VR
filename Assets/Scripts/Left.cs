using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEngine;

public class Left : MonoBehaviour
{
    public GameObject pref;
    private Vector3 palmpos;

    // Start is called before the first frame update
    void Start()
    {
        palmpos=Vector3.zero;
    }

    public void Showobject()
    {
        var camera = CameraCache.Main.transform;
        var ray = new Ray(camera.position, camera.rotation * Vector3.forward);

        var obj = Instantiate(pref);
        
        obj.transform.position = palmpos;
        obj.transform.LookAt(camera);
        obj.transform.Rotate(new Vector3(0,180,0));
        
        Destroy(obj,2);
    }

    public void OnHandJointsUpdated(InputEventData<IDictionary<TrackedHandJoint, MixedRealityPose>> eventData)
    {
        MixedRealityPose pose;
        eventData.InputData.TryGetValue(TrackedHandJoint.Palm, out pose);

        if (pose != null)
        {
            palmpos = new Vector3(pose.Position.x, pose.Position.y, pose.Position.z);
        }
    }
}
