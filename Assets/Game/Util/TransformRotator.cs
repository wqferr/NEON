using UnityEngine;

namespace NeonChaser.Util
{
	public class TransformRotator : MonoBehaviour
	{
		public Vector3 rotationAxis = Vector3.up;
		public Transform rotatedTransform;

		public void SetRotation(float angle)
		{
			this.rotatedTransform.eulerAngles = Vector3.zero;
			this.rotatedTransform.RotateAround(
				this.rotatedTransform.position,
				this.rotationAxis,
				angle);
		}
	}
}
