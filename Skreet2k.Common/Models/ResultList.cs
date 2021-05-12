using System.Collections.Generic;

namespace Skreet2k.Common.Models
{
    /// <summary>
    /// Result model with list content
    /// </summary>
    /// <typeparam name="T">Content type</typeparam>
    public class ResultList<T> : Result<IEnumerable<T>>
    {
        public ResultList() { }

        public ResultList(IEnumerable<T> content): base(content)
        {
        }
        
        public int Count { get; set; }
    }
}