using UnityEngine;

namespace Neon.Core
{
	public class HP : MonoBehaviour
	{

		public delegate void DeathEventHandler(GameObject deadObject);
		public event DeathEventHandler DeathEvent;

		public int value
		{
			get;
			private set;
		}

		#pragma warning disable CS0649
		[SerializeField]
		private int max;
		#pragma warning restore CS0649

		void Awake()
		{
			this.value = this.max;
		}

		public void Decrease(int amount)
		{
			Set(this.value - amount);
		}

		public void Increase(int amount)
		{
			Set(this.value + amount);
		}

		public void Set(int value)
		{
			if (value > this.max)
				value = this.max;
			this.value = value;
			if (this.value <= 0)
				Death();
		}

		void Death()
		{
			this.DeathEvent?.Invoke(this.gameObject);
		}
	}
}
