using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableCubeBehavior : MonoBehaviour
{
    bool shouldSpin;
    bool isHighlighted;

    //Feel free to choose your own colors
    public Color idleColor = Color.grey;
    public Color isHighliughtedColor = Color.green;
    MeshRenderer cubeMeshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        cubeMeshRenderer = this.GetComponent<MeshRenderer>();
        shouldSpin = true;
        isHighlighted = false;
        UpdateColor();
    }

    private void FixedUpdate()
    {
        SpinBehavior();
    }


    /// <summary>
    /// Basic behavior of the SpiningCube 
    /// </summary>
    void SpinBehavior()
    {
        if (shouldSpin)
        {
            this.transform.Rotate(0, 1, 0);

        }
    }


    /// <summary>
    /// Updates the cubes material color according to the status (isActivated or Not)
    /// </summary>
    private void UpdateColor()
    {
        if (isHighlighted)
        {
            cubeMeshRenderer.material.color = isHighliughtedColor;
        }
        else
        {
            cubeMeshRenderer.material.color = idleColor;
        }
    }

    /// <summary>
    /// Toggles the cubes activation value (isActive or Not)
    /// </summary>
    private void ToggleHighlight()
    {
        isHighlighted = !isHighlighted;
    }

    public void ChangePosition(Vector3 new_position)
    {
        print(new_position);
        this.transform.position = new_position;
    }

    /// <summary>
    /// The code logic of the interaction. In our example, Toggle the status and update the visuals.
    /// </summary>
    public void InteractWithCube()
    {
        print("INTERACTING");
        ToggleHighlight();
        UpdateColor();
    }
}

