using System.Collections.Generic;
using UnityEngine;

namespace NeonChaser.Core
{
	public class Ship : MonoBehaviour
	{
		public Transform gunContainer;
		private Gun[] guns;

		void Awake()
		{
			UpdateGunList();
		}

		public void Shoot()
		{
			foreach (var gun in this.guns)
				gun.Shoot();
		}

		public void UpdateGunList()
		{
			this.guns = this.gunContainer.GetComponentsInChildren<Gun>();
		}
	}
}
