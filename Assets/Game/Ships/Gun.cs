using UnityEngine;

namespace NeonChaser.Core
{
	public class Gun : MonoBehaviour
	{
		public GameObject shotPrefab;
		public Transform Transform { get; private set; }

		void Awake()
		{
			this.Transform = GetComponent<Transform>();
		}

		public void Shoot()
		{
			var shot = Instantiate(
				this.shotPrefab,
				this.Transform.position,
				this.Transform.rotation);
		}
	}
}
