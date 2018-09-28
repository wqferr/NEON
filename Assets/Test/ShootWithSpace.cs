using UnityEngine;
using NeonChaser.Core;

namespace NeonChaser.Testing
{
	public class ShootWithSpace : MonoBehaviour
	{
		public Ship ship;

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Space))
				ship.Shoot();
		}
	}
}
