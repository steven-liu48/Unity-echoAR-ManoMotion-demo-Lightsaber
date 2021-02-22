using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactractable : MonoBehaviour
{
    [SerializeField]
    //InteractableCubeBehavior currentInteractableCube;
    CustomBehaviour currentObject;

    // Update is called once per frame
    void Update()
    {
        //FindWhichCubeShouldBetheCurrentInteractable();
        //DetectMouseClick();
        currentObject = GameObject.Find("Light Saber.png").GetComponent<CustomBehaviour>();
        if (currentObject != null)
        {
            DetectPositionChange();
        }
        //DetectHandGestureClick();
    }

    void DetectPositionChange()
    {
        HandInfo hand = ManomotionManager.Instance.Hand_infos[0].hand_info;
        GestureInfo gesture = hand.gesture_info;
        ManoGestureTrigger currentDetectedTriggerGestre = gesture.mano_gesture_trigger;
        BoundingBox box = hand.tracking_info.bounding_box;
        Vector3 top_left = box.top_left;
        float width = box.width;
        float height = box.height;
        Vector3 palm_center = hand.tracking_info.palm_center;
        //print(box.top_left);
        if (hand.gesture_info.mano_gesture_continuous == ManoGestureContinuous.CLOSED_HAND_GESTURE)
        {
            //currentObject.ChangePosition(top_left + Camera.main.transform.forward + new Vector3(-0.3f, -0.3f + height, 0.0f));
            currentObject.ChangePosition(palm_center + Camera.main.transform.forward + new Vector3(0.0f, 0.0f, 0.0f));
        }
    }

    //void DetectHandGestureClick()
    //{

    //    //All the information of the hand
    //    HandInfo detectedHand = ManomotionManager.Instance.Hand_infos[0].hand_info;

    //    //The click happens when I perform the Click Gesture : Open Pinch -> Closed Pinch -> Open Pinch 
    //    if (detectedHand.gesture_info.mano_gesture_trigger == ManoGestureTrigger.CLICK)
    //    {
    //        //Logic that should happen when I click
    //        if (currentInteractableCube)
    //        {
    //            currentInteractableCube.InteractWithCube();
    //        }
    //    }

    //}


    //void DetectMouseClick()
    //{

    //    //The click happens when I release the left mouse buttons
    //    if (Input.GetMouseButtonUp(0))
    //    {

    //        //Logic that should happen when I click.
    //        print("CLICKED");
    //        print(GameObject.Find("InteractableCube").gameObject.transform.position);
    //        if (currentInteractableCube)
    //        {
    //            currentInteractableCube.InteractWithCube();

    //        }

    //    }
    //}

    ////TODO Code Challenge: Use a smart & creative way to decide which object should be the currentInteractableCube.
    ////TODO email abraham@manomotion.com with your ideas and code snipets :) 
    //void FindWhichCubeShouldBetheCurrentInteractable()
    //{
    //    currentInteractableCube = GameObject.Find("InteractableCube").GetComponent<InteractableCubeBehavior>();
    //}
}

