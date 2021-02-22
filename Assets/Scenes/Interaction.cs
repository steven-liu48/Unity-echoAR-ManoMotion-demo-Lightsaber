using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject itemPrefab;

    // Start is called before the first frame update
    void Start()
    {
        print("Start!!!");
    }

    // Update is called once per frame
    void Update()
    {
        HandInfo hand = ManomotionManager.Instance.hand_infos[0].hand_info;
        GestureInfo gesture = hand.gesture_info;
        ManoGestureTrigger currentDetectedTriggerGestre = gesture.mano_gesture_trigger;
        BoundingBox box = hand.tracking_info.bounding_box;
        Vector3 top_left = box.top_left;
        float width = box.width;
        float height = box.height;

        //Vector3 positionToMove = Camera.main.transform.position + (Camera.main.transform.forward * 2);
        Vector3 positionToMove = top_left;
        itemPrefab.transform.position = positionToMove;
    }
}
