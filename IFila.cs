namespace TDE
{
	public interface IFila<T>
	{
		public void Enfilerar(T item);

		public No<T> Desenfilerar();
	}
}