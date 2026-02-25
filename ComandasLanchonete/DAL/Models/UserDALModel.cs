using ComandasLanchonete.Models.BaseModels;

namespace ComandasLanchonete.DAL.Models
{
    public class UserDALModel : UserBaseModel
    {
        public UserDALModel()
        {
            
        }
        public UserDALModel(UserBaseModel userBaseModel):base(userBaseModel)
        {
            
        }
    }
}