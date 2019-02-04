namespace CodeChallenge.Core.Entities
{
    using CodeChallenge.Core.SharedKernel;
    using System.Runtime.Serialization;
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Launchpad : BaseEntity
    {
        [DataMember(Name = "id")]
        public string LaunchpadId { get; set; }

        [DataMember(Name = "full_name")]
        public string LaunchpadName { get; set; }

        [DataMember(Name = "status")]
        public string LaunchpadStatus { get; set; }

        //Add events if needed.
    }
}
