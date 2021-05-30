using UnityEngine;

public class movement : MonoBehaviour
{
    public int movementSpeed;
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            GetComponent<Rigidbody>().AddForce(new Vector3(-movementSpeed, 0, 0));
        if (Input.GetKey(KeyCode.D))
            GetComponent<Rigidbody>().AddForce(new Vector3(movementSpeed, 0, 0));
        if (Input.GetKey(KeyCode.W))
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, movementSpeed));
        if (Input.GetKey(KeyCode.S))
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -movementSpeed));

    }

}
