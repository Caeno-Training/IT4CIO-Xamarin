using System;
using System.Collections.Generic;
using Lab4Events.Core.Models;
using System.Linq;

namespace Lab4Events.Core.Services
{

    /// <summary>
    /// Representa um serviço com ações que podem ser realizadas para um usuário.
    /// </summary>
    public class UserService
    {
        /// <summary>
        /// Banco de dados em memória de usuários de testes.
        /// </summary>
        static List<User> users = new List<User> {
            new User { Id = 1, Name = "Jose da Silva", Email = "usuario1@email.com", Phone = "4112341234", PictureUrl = "http://", Password = "123" },
            new User { Id = 2, Name = "Usuário Teste", Email = "teste@email.com", Phone = "4112341234", PictureUrl = "http://", Password = "123" },
            new User { Id = 3, Name = "Popotex Silva", Email = "popoto@it4cio.com", Phone = "4112341234", PictureUrl = "http://", Password = "123" },
        };
    
        /// <summary>
        /// Tenta realizar o login de um usuário.
        /// </summary>
        /// <returns>Uma tupla informando o sucesso da ação. Caso verdadeiro o segundo parâmetro representa o usuário.</returns>
        /// <param name="email">Endereço de email do usuário.</param>
        /// <param name="password">Senha do usuário.</param>
        public (bool Success, User User) Login(string email, string password) {
            //
            // Método 1: forma imperativa
            /*
            foreach (var user in users) {
                if (user.Email == email && user.Password == password)
                    return (true, user);
            }

            return (false, null);
            */

            //
            // Método 2: Usando LINQ de forma funcional
            var user = users
                .Where(u => u.Email == email && u.Password == password)
                .FirstOrDefault();

            return (user == null) ? (false, null) : (true, user);
        }

        /// <summary>
        /// Registra um novo usuário no sistema.
        /// </summary>
        public void Register() {
            // TODO: Implementar o Registro de Usuário
        }
        
    }
}
