namespace Modelos
{
	public class Usuario
	{
		public int usuarioID { get; set; } /// <summary>
		/// quando coloca ID a frente na variavelo entity framework cria como chave primaria o banco automaticamente
		/// </summary>

		public string Nome { get; set; }

		public bool Ativivo { get; set; }


	}
}
