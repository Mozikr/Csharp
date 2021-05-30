using UnityEngine;

public class movement2D : MonoBehaviour
{
    [SerializeField] int _speed;
    Rigidbody2D _rb2d;
    private float _horizontalMove;
    private bool _isFacingRight = true;

    private void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _horizontalMove = Input.GetAxisRaw("Horizontal");

        if(_isFacingRight && _horizontalMove < 0)
        {
            Flip();
        }else if(!_isFacingRight && _horizontalMove > 0)
        {
            Flip();
        }
    }

    void Flip()                     //flip
    {
        _isFacingRight = !_isFacingRight;
        transform.Rotate(0.0f, -180f, 0.0f);
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("d"))                  //move
        {
            _rb2d.velocity = new Vector2(_speed, _rb2d.velocity.y);
        }else if (Input.GetKey("a"))
        {
            _rb2d.velocity = new Vector2(-_speed, _rb2d.velocity.y);
        }
        else
        {
            _rb2d.velocity = new Vector2(0, _rb2d.velocity.y);
        }
    }
}
