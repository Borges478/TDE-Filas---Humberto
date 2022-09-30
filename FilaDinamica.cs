namespace TDE_Fila
{
	public class FilaDinamica : IFila<string>
	{
		public int Size { get; private set; }
		public No<string>? Start { get; private set; }
		public No<string>? End { get; private set; }

		public FilaDinamica()
		{
			Size = 0;
			Start = null;
			End = null;
		}

		public No<string> Desenfilerar()
		{
			if (EstaVazia()) throw new Exception("Underflow");

			var valorRetorno = Start;
			
			Start = Start.ProximoNo;
			Tamanho--;
			return valorRetorno;
		}

		public void Enfilerar(string item)
		{
			var novoNo = new No<string>(item, null);
			if (EstaVazia())
				Start = novoNo;
			else
				End.AtualizarNoProximo(novoNo);
			End = novoNo;
			Tamanho++;
		}

		public bool EstaVazia() => Tamanho == 0;
	}
}