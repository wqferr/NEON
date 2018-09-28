using UnityEngine;

namespace NeonChaser.Core
{
	[RequireComponent(typeof(Collider2D)), DisallowMultipleComponent]
	public class ShipGunShot : MonoBehaviour
	{
		public int damage;
		public float speed;

		private Transform Transform;

		void Awake()
		{
			this.Transform = GetComponent<Transform>();
		}

		void FixedUpdate()
		{
			var velocity = this.transform.forward * this.speed;
			var delta = velocity * Time.fixedDeltaTime;
			this.Transform.Translate(delta);
		}
	}
}
