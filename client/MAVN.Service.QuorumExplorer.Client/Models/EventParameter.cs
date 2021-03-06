using JetBrains.Annotations;

namespace MAVN.Service.QuorumExplorer.Client.Models
{
    /// <summary>
    /// The event parameter
    /// </summary>
    [PublicAPI]
    public class EventParameter
    {
        /// <summary>
        /// The name of the parameter
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        ///  The order of the parameter
        /// </summary>
        public int Order { get; set; }
        
        /// <summary>
        /// The type of the parameter
        /// </summary>
        public string Type { get; set; }
        
        /// <summary>
        /// The payload of the parameter
        /// </summary>
        public string Value { get; set; }
    }
}
