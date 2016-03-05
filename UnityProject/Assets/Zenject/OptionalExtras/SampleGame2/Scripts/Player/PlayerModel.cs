using UnityEngine;

namespace ModestTree
{
    public class PlayerModel
    {
        readonly Rigidbody _rigidBody;
        readonly MeshRenderer _renderer;

        float _health = 100.0f;

        public PlayerModel(
            Rigidbody rigidBody,
            MeshRenderer renderer)
        {
            _rigidBody = rigidBody;
            _renderer = renderer;
        }

        public MeshRenderer Renderer
        {
            get
            {
                return _renderer;
            }
        }

        public bool IsDead
        {
            get;
            set;
        }

        public float Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }
        }

        public Vector3 LookDir
        {
            get
            {
                return -_rigidBody.transform.right;
            }
        }

        public Quaternion Rotation
        {
            get
            {
                return _rigidBody.rotation;
            }
            set
            {
                _rigidBody.rotation = value;
            }
        }

        public Vector3 Position
        {
            get
            {
                return _rigidBody.position;
            }
            set
            {
                _rigidBody.position = value;
            }
        }

        public Vector3 Velocity
        {
            get
            {
                return _rigidBody.velocity;
            }
        }

        public void TakeDamage(float healthLoss)
        {
            _health -= healthLoss;
        }

        public void AddForce(Vector3 force)
        {
            _rigidBody.AddForce(force);
        }
    }
}