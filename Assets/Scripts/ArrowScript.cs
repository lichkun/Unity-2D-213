using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    [SerializeField]
    private Transform rotAnchor;

    private float minRotAngle = -50.0f;
    private float maxRotAngle = 70.0f;



    void Update()
    {
        float dy = Input.GetAxis("Vertical");
        float curRotAngle = NormalizeAngle(this.transform.eulerAngles.z);
        if (curRotAngle > 180)
        {
            curRotAngle -= 180;
        }
        if (curRotAngle + dy > minRotAngle && curRotAngle + dy < maxRotAngle)
        {
            this.transform.RotateAround(rotAnchor.position, Vector3.forward, dy);

        }
    }

    private float NormalizeAngle(float angle)
    {
        angle = angle % 360;
        if (angle > 180) angle -= 360;
        return angle;
    }


}