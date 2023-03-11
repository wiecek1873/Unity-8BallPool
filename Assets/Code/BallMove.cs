using UnityEngine;

public class BallMove : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput = null;
    [SerializeField] private Board board = null;

    private Vector3 moveVector = default;

    private void Update()
    {
        //if (board.IsAnyBallMoving())
        //{
        //    return;
        //}

        Vector3 _direction = new Vector3(playerInput.GetHorizontalAxis(), 0f, playerInput.GetVerticalAxis()).normalized;
        moveVector = _direction;

        Debug.DrawLine(transform.position, transform.position + moveVector, Color.magenta, 0f);
    }
}
