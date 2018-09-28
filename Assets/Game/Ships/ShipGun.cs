using UnityEngine;

namespace NeonChaser.Core
{
	public class ShipGun : MonoBehaviour
	{
		public GameObject shotPrefab;
		private Transform Transform;

		void Awake()
		{
			this.Transform = GetComponent<Transform>();
		}

		public void Shoot()
		{
			var shot = Instantiate(
				this.shotPrefab,
				this.Transform.position,
				Quaternion.LookRotation(this.Transform.forward));
		}
	}
}
