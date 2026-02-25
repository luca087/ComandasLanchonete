using ComandasLanchonete.Models.BaseModels;

namespace ComandasLanchonete.Models
{
    public class User : UserBaseModel
    {
        public User()
        {
            
        }
        public User(UserBaseModel userBaseModel):base(userBaseModel)
        {
            
        }
    }
}
