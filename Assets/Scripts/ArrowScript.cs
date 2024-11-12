using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    [SerializeField]
    Transform rotAnchor;
    float minRotationAngel = -50.0f;
    float maxRotationAngel = 70.0f;
    // Update is called once per frame
    void Update()
    {
        float dy = Input.GetAxis("Vertical");
        float currentRotAngle = this.transform.eulerAngles.z;
        if (currentRotAngle > 180) currentRotAngle -= 360;
        if (currentRotAngle + dy > minRotationAngel && currentRotAngle + dy < maxRotationAngel)
            this.transform.RotateAround(rotAnchor.position, Vector3.forward, dy);
        else
        {
            Debug.Log(currentRotAngle);
            Debug.Log(currentRotAngle+dy);
        }
        //float rotationAngle = Mathf.Clamp(currentRotAngle + dy, minRotationAngel, maxRotationAngel);
    }
}
