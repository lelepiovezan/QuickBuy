using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    class Usuario
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }
        public string SobreNome { get; set; }

        ///<sumary>
        ///Um usuário pode ter  muitos ou nenhum pedido
        ///</sumary>

        public ICollection<Pedido> Pedidos { get; set; }


    }
}
