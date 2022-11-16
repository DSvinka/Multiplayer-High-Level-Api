using System;
using UnityEngine;
using UnityEngine.Networking;

namespace Code
{
    [RequireComponent(typeof(CharacterController))]
    public abstract class PlayerBase : NetworkBehaviour
    {
        protected Action OnUpdateAction { get; set; }
        protected abstract FireAction _fireAction { get; set; }
        
        [SyncVar] protected Vector3 _serverPosition;
        
        protected virtual void Initiate()
        {
            OnUpdateAction += Movement;
        }
        
        private void Update()
        {
            OnUpdate();
        }
        
        private void OnUpdate()
        {
            OnUpdateAction?.Invoke();
        }
        
        [Command]
        protected void CmdUpdatePosition(Vector3 position)
        {
            _serverPosition = position;
        }
        
        public abstract void Movement();
    }
}
