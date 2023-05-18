using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    [Range(1,3)]
    [SerializeField] private float _mouseSensitive;

    private float horizontalInput;
    private float verticalInput;

    private void Update() 
    {
        float horizontalinput = Input.GetAxis("Mouse X");
        float verticalinput = Input.GetAxis("Mouse Y");

        transform.eulerAngles -= new Vector3 (0f, horizontalinput, 0f);

    }
    private void FixedUpdate()
    {
         horizontalInput = Input.GetAxis("Horizontal");
         verticalInput = Input.GetAxis("Vertical");

        // _rigidbody.velocity = transform.forward * horizontalInput *(_speed * Time.deltaTime);

        // LocalMover(transform.right, horizontalInput);
        LocalMover(transform.forward, transform.right, verticalInput, horizontalInput);
        

    }
    private void LocalMover(Vector3 direction,Vector3 direction1, float input, float input1)
    {
        // if(input == horizontalInput)
        // {
        //     _rigidbody.velocity = direction * input *(_speed * Time.fixedDeltaTime);
        // }
        // else if(input1 == verticalInput)
        // {
        //     _rigidbody.velocity = direction1 * input1 *(_speed * Time.fixedDeltaTime);
        // }
        _rigidbody.velocity = Vector3.Cross(direction, direction1) * input1 *(_speed * Time.fixedDeltaTime);
        // _rigidbody.velocity = direction1 * input1 *(_speed * Time.fixedDeltaTime);
        
    }
    
}
