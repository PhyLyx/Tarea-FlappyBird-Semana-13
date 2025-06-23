using UnityEngine;
using System.Collections;
public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private bool CanJump = true;

    [SerializeField] private float jumpForce = 7f;
    [SerializeField] private float jumpCooldown = 0.3f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && CanJump)
        {
            CanJump = false;
            rb.linearVelocity = new Vector3(0, 0, 0);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            StartCoroutine(ResetJumpCooldown());
        }
    }
    private IEnumerator ResetJumpCooldown()
    {
        yield return new WaitForSeconds(jumpCooldown);
        CanJump = true;
    }
}