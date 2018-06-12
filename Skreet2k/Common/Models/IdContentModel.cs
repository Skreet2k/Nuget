namespace S2k.Common.Core.Models
{
	public class IdContentModel<T>
	{
		public int Id { get; set; }
		public T Content { get; set; }
	}
}