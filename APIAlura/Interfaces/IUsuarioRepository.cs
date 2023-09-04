﻿using APIAlura.Entidade;

namespace APIAlura.Interfaces
{
    public interface IUsuarioRepository
    {
        IList<Usuario> ObterTodosUsuarios();

        Usuario ObterUsuarioPorId(int id);

        void CadastrarUsuario(Usuario usuario);

        void AlterarUsuario(Usuario usuario);

        void DeletarUsuario(int id);

    }
}
