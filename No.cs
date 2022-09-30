namespace TDE
{
	public class No<T>
	{
		public No(T valor, No<T>? proximoNo)
		{
			Valor = valor;
			ProximoNo = proximoNo;
		}

		public T Valor { get; private set; }
		public No<T>? ProximoNo { get; private set; }

		public void AtualizarNoProximo(No<T>? noProximo)
		{
			ProximoNo = noProximo;
		}
	}
}