using Newtonsoft.Json;
namespace Lab4Events.Core.Models
{

    /// <summary>
    /// Representa um usuário do sistema.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Identificador do usuário.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome completo.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Endereço de e-mail.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Telefone.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// URL representando a foto do usuário.
        /// </summary>
        public string PictureUrl { get; set; }

        /// <summary>
        /// Senha do usuário.
        /// </summary>
        public string Password { get; set; }


        #region Extensões para Serialização/Deserialização JSON

        /// <summary>
        /// Retorna essa instância representada como um objeto JSON.
        /// </summary>
        public string AsJson() => JsonConvert.SerializeObject(this);

        /// <summary>
        /// Obtém uma instância dessa classe através de um objeto JSON.
        /// </summary>
        /// <returns>A instância deserializada do usuário.</returns>
        /// <param name="json">Uma string representando o usuário no formato JSON.</param>
        public static User FromJson(string json) => JsonConvert.DeserializeObject<User>(json);

        #endregion

    }
}