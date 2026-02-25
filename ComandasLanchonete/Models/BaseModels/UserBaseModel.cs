namespace ComandasLanchonete.Models.BaseModels
{
    public class UserBaseModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public UserBaseModel()
        {
                
        }

        public UserBaseModel(UserBaseModel userBaseModel)
        {
            Id = userBaseModel.Id;
            Login = userBaseModel.Login;
            Senha = userBaseModel.Senha;
        }
    }
}
