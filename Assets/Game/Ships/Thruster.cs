using UnityEngine;

namespace NeonChaser.Testing
{
	[RequireComponent(typeof(Rigidbody))]
	public class Thruster : MonoBehaviour
	{
		private new Rigidbody rigidbody;
		private new Transform transform;
		public float maxForce = 3;
		[SerializeField]
		private float currentForce = 0;

		void Awake()
		{
			this.rigidbody = GetComponent<Rigidbody>();
			this.transform = GetComponent<Transform>();
		}

		void FixedUpdate()
		{
			var force = this.currentForce * this.transform.up;
			this.rigidbody.AddForce(force);
		}

		void OnValidate()
		{
			SetForce(this.currentForce);
		}

		public void SetForce(float force)
		{
			if (force < 0)
				force = 0;
			if (force > this.maxForce)
				force = this.maxForce;
			this.currentForce = force;
		}
	}
}
