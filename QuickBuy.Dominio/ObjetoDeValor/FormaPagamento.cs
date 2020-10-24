using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoDeValor
{
   public class FormaPagamento
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public Boolean EhBoleto {


            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
        
        }

        public Boolean EhCartao
        {


            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }

        }


        public Boolean EhDeposito
        {


            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }

        }


        public Boolean NaoFoiDefinido
        {


            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }

        }











        public object TipoFormaPagamento { get; private set; }
    }
}
