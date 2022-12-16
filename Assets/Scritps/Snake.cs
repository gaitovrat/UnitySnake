using UnityEngine;

namespace Assets.Scritps
{
    internal sealed class Snake
    {
        public Snake(Transform transform, float speed)
        {
            _transform = transform;
            Speed = speed;
        }

        public Snake(Transform transform) : this(transform, 0.01f) { }

        public void Move(float x, float y) 
        {
            MoveX(x);
            MoveY(y);
        }

        public void MoveX(float x) 
        {
            var position = _transform.position;

            position.x += x * Speed;
            _transform.position = position;
        }

        public void MoveY(float y) 
        {
            var position = _transform.position;

            position.y += y * Speed;
            _transform.position = position;
        }

        public void MoveUp()
        {
            MoveY(1);
        }

        public void MoveDown() 
        {
            MoveY(-1);
        }

        public void MoveLeft() 
        {
            MoveX(-1);
        }

        public void MoveRight() 
        {
            MoveX(-1);
        }

        public float Speed { get; set; }

        private readonly Transform _transform;
    }
}
