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

        public void MoveUp()
        {
            var position = _transform.position;

            position.y += Speed;
            _transform.position = position;
        }

        public void MoveDown() 
        {
            var position = _transform.position;

            position.y -= Speed;
            _transform.position = position;
        }

        public void MoveLeft() 
        {
            var position = _transform.position;

            position.x += Speed;
            _transform.position = position;
        }

        public void MoveRight() 
        {
            var position = _transform.position;

            position.x -= Speed;
            _transform.position = position;
        }

        public float Speed { get; set; }

        private readonly Transform _transform;
    }
}
