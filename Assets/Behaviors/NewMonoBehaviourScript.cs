using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody sphereRigidbody;
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	Vector3 inputVector = Vector3.zero;
	if (Input.GetKey(KeyCode.Space) && sphereRigidbody.position.y==1){
	inputVector += Vector3.up*100;
	}
	if (Input.GetKey(KeyCode.W))
	{
	inputVector += Vector3.forward;
	}
	if (Input.GetKey(KeyCode.S))
	{
	inputVector += Vector3.back;
	}
	if (Input.GetKey(KeyCode.D))
	{
	inputVector += Vector3.right;
	}
	if (Input.GetKey(KeyCode.A))
	{
	inputVector += Vector3.left;
	}
        sphereRigidbody.AddForce(new(inputVector.x,inputVector.y,inputVector.z));
    }
}
