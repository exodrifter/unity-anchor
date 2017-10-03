using UnityEngine;

public class FollowBehaviour : MonoBehaviour
{
	/// <summary>
	/// The transform to follow.
	/// </summary>
	public Transform Target
	{
		get { return target; }
		set { target = value; }
	}
	[SerializeField, Tooltip("The transform to follow.")]
	private Transform target;

	/// <summary>
	/// The desired offset from the target.
	/// </summary>
	public Vector3 Offset
	{
		get { return offset; }
		set { offset = value; }
	}
	[SerializeField, Tooltip("The desired offset from the target.")]
	public Vector3 offset;

	/// <summary>
	/// The desired angle from the target. If the angle is 0, then the desired
	/// position will be the back vector.
	/// </summary>
	public Vector3 Angle
	{
		get { return angle; }
		set { angle = value; }
	}
	[SerializeField, Tooltip("The desired angle from the target.")]
	public Vector3 angle;

	/// <summary>
	/// The desired distance from the target.
	/// </summary>
	public float Distance
	{
		get { return distance; }
		set { distance = value; }
	}
	[SerializeField, Tooltip("The desired distance from the target.")]
	private float distance;

	/// <summary>
	/// True if the angle is local, otherwise global.
	/// </summary>
	public bool IsAngleLocal
	{
		get { return isAngleLocal; }
		set { isAngleLocal = value; }
	}
	[SerializeField, Tooltip("True if the angle is local, otherwise global.")]
	private bool isAngleLocal;

	/// <summary>
	/// True if the position should immediately snap, otherwise lerp.
	/// </summary>
	public bool IsImmediate
	{
		get { return isImmediate; }
		set { isImmediate = value; }
	}
	[SerializeField, Tooltip("True if the position should immediately snap, otherwise lerp.")]
	private bool isImmediate;

	public float Strength
	{
		get { return strength; }
	}
	[SerializeField, Tooltip("The strength of the follow behaviour, if not immediate.")]
	private float strength = 1;

	private void Update()
	{
		if (isImmediate)
		{
			return;
		}

		var a = transform.position;
		var b = GetDesiredPosition();
		transform.position = a + (b - a) * Time.deltaTime * strength;
		transform.LookAt(target);
	}

	private void LateUpdate()
	{
		if (!isImmediate)
		{
			return;
		}

		transform.position = GetDesiredPosition();
		transform.LookAt(target);
	}

	private Vector3 GetDesiredPosition()
	{
		var pos = target.transform.position;
		var dir = Quaternion.Euler(angle) * Vector3.back;
		if (isAngleLocal)
		{
			dir = target.transform.TransformVector(dir);
		}
		return pos + offset + (dir * distance);
	}
}
