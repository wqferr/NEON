using UnityEngine;

namespace NeonChaser.Util
{
	public class SelfDestructTimer : MonoBehaviour
	{
		public float selfDestructTime = 0.5f;

		void Start()
		{
			Invoke("DestroySelf", this.selfDestructTime);
		}

		void DestroySelf()
		{
			Destroy(this.gameObject);
		}
	}
}
