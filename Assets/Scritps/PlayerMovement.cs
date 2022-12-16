using Assets.Scritps;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        _snake = new(_transform, _speed);
    }

    private void FixedUpdate()
    {
        var xAxis = Input.GetAxis("Horizontal");
        var yAxis = Input.GetAxis("Vertical");

        _snake.Move(xAxis, yAxis);
    }

    private void OnBecameInvisible()
    {
        Game.GameOver();
    }

    public GameManager Game { private get; set; }

    private Transform _transform;
    private Snake _snake;
}
