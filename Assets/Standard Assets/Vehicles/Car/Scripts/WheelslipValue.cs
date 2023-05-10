using UnityEngine;

public class WheelslipValue : MonoBehaviour
{
    WheelCollider WheelC;
    
    public float RoadForwardStiffness = 3f;
    public float TerraintForwardStiffness = 0.6f;
    public float RoadSidewaysStiffness = 1.1f;
    public float TerrainSidewaysStiffness = 0.2f;
    
    private bool Changed = false;

    private void Start()
    {
        WheelC = GetComponent<WheelCollider>();
    }

    private void Update()
    {
        if(SaveScript.OnTheRoad)
        {
            if(!Changed)
            {
                Changed = true;
                WheelFrictionCurve fFriction = WheelC.forwardFriction;
                fFriction.stiffness = RoadForwardStiffness;
                WheelC.forwardFriction = fFriction;

                WheelFrictionCurve sFriction = WheelC.sidewaysFriction;
                sFriction.stiffness = RoadSidewaysStiffness;
                WheelC.sidewaysFriction = sFriction;
            } 
        }

        if(SaveScript.OnTheTerrain)
        {
            if(Changed)
            {
                Changed = false;
                WheelFrictionCurve fFriction = WheelC.forwardFriction;
                fFriction.stiffness = TerraintForwardStiffness;
                WheelC.forwardFriction = fFriction;

                WheelFrictionCurve sFriction = WheelC.sidewaysFriction;
                sFriction.stiffness = TerrainSidewaysStiffness;
                WheelC.sidewaysFriction = sFriction;
            }
        }
    }
}
