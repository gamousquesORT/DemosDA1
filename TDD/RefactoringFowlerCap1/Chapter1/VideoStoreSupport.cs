// This is an open source non-commercial project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text.Json.Serialization;

namespace Chapter1
{
    public enum PayType : byte
    {
        Tragedy,
        Comedy
    }


    public class Play
    {
        public string Name { get; } 
        public PayType PayType { get; }

        public Play(string name, PayType payType)
        {
            Name = name;
            PayType = payType;
        }
    }

    public class Performance
    {
        public  int Audience { get; }
        public  string PlayId { get; }

        public Performance(string playId, int audience)
        {
            PlayId = playId;
            Audience = audience;
        }
    }

    public class Invoice
    {
        public string Customer { get; }
        public ImmutableList<Performance> Performances { get; }
        
        [JsonConstructor] // JsonSerializer.Deserialize will use this ctor 
        public Invoice(string customer, ImmutableList<Performance> performances)
        {
            Customer = customer;
            Performances = performances;
        }

        public Invoice(string customer, IEnumerable<Performance> performances)
        : this(customer, performances.ToImmutableList())
        {
        }
    }

    public interface IVideoStore
    {
        string Statement(Invoice invoice, IReadOnlyDictionary<string, Play> plays);
    }
    public interface IHtmlVideoStore
    {
        string HtmlStatement(Invoice invoice, IReadOnlyDictionary<string, Play> plays);
    }

}