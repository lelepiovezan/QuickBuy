using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
   public class Pedido
    {
        public int Id { get; set; }

        public DateTime DataPedido{ get; set; }


        public int UsuarioId { get; set; }


        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public int Cidade { get; set; }

        public string EnderecoCompleto { get; set; }

        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento{ get; set; }

        ///<sumary>
        ///Pedido deve ter pelo menos 1 item pedido ou mutos itens de pedidos
        ///</sumary>

        public ICollection <ItemPedido>ItemPedido { get; set; }

    }
}
