using ComandasLanchonete.Models.BaseModels;

namespace ComandasLanchonete.Models
{
    public class UserModel : UserBaseModel
    {
        public UserModel()
        {
            
        }
        public UserModel(UserBaseModel userBaseModel):base(userBaseModel)
        {
            
        }
    }
}
