using System.Runtime.Serialization;

namespace officium.ServiceModels
{
    [DataContract]
    public class RecipeServiceModel
    {
        [DataMember]
        public int RecipeId { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}