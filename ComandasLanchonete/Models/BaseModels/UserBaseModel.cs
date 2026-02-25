using System.Text.Json.Serialization;

namespace ComandasLanchonete.Models.BaseModels
{
    public class UserBaseModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        [JsonIgnore]
        public string? SenhaSalt { get; set; }
        public UserBaseModel()
        {
                
        }

        public UserBaseModel(UserBaseModel userBaseModel)
        {
            Id = userBaseModel.Id;
            Login = userBaseModel.Login;
            Senha = userBaseModel.Senha;
            SenhaSalt = userBaseModel.SenhaSalt;
        }
    }
}
