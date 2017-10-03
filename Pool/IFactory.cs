namespace Exodrifter.Anchor
{
	/// <summary>
	/// A Factory is used to produce many items of the same type.
	/// </summary>
	public interface IFactory<T>
	{
		T Instantiate();
	}
}
