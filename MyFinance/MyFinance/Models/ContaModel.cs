using Microsoft.AspNetCore.Http;
using MyFinance.Util;
using System.Collections.Generic;
using System.Data;

namespace MyFinance.Models
{
	public class ContaModel
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public double Saldo { get; set; }
		public int Usuario_Id { get; set; }
		IHttpContextAccessor HttpContextAccessor;

		public ContaModel()
		{

		}

		// Recebe o contexto para o acesso às variáveis de sessão.
		public ContaModel(IHttpContextAccessor httpContextAccessor)
		{
			HttpContextAccessor = httpContextAccessor;
		}

		public List<ContaModel> ListaConta()
		{
			List<ContaModel> lista = new List<ContaModel>();
			ContaModel item;

			string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
;
			string sql = $"SELECT ID, NOME, SALDO, USUARIO_ID FROM CONTA WHERE USUARIO_ID = {id_usuario_logado}";
			DAL objDAL = new DAL();
			DataTable dt = objDAL.RetDataTable(sql);

			for (int i = 0; i < dt.Rows.Count; i++)
			{
				item = new ContaModel();
				item.Id = int.Parse(dt.Rows[i]["ID"].ToString());
				item.Nome = dt.Rows[i]["NOME"].ToString();
				item.Saldo = double.Parse(dt.Rows[i]["SALDO"].ToString());
				item.Usuario_Id = int.Parse(dt.Rows[i]["USUARIO_ID"].ToString());

				lista.Add(item);
			}

			return lista;
		}
	}
}
