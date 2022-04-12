// This is an open source non-commercial project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text.Json;
using NUnit.Framework;

namespace Chapter1.Tests
{
    public class VideoStore
    {
        /// <summary>
        /// Unit tests for Chapter1
        /// </summary>
        [TestFixture]
        public class UnitTests
        {
            [SetUp]
            public void Init()
            {
                _plays = new Dictionary<string, Play>
                {
                    {"hamlet", new Play("Hamlet", PayType.Tragedy)},
                    {"as-like", new Play("As You Like It", PayType.Comedy)},
                    {"othello", new Play("Othello", PayType.Tragedy)}
                }.ToImmutableDictionary();

                _invoice = new Invoice("BigCo", new List<Performance>
                {
                    new Performance("hamlet", 55),
                    new Performance("as-like", 35),
                    new Performance("othello", 40)
                });
            }

            private IImmutableDictionary<string, Play> _plays;
            private Invoice _invoice;

            [TestCaseSource(typeof(StatementImplementationProvider))]
            public void RenderPlainTextTest(IVideoStore implementation)
            {
                Assert.AreEqual(
                    "Statement for BigCo\r\n" +
                    "  Hamlet: $650.00 (55 seats)\r\n  As You Like It: $580.00 (35 seats)\r\n  Othello: $500.00 (40 seats)\r\n" +
                    "Amount owed is $1,730.00\r\nYou earned 47 credits",
                    implementation.Statement(_invoice, _plays));
            }

            /// <summary>
            /// Basic test to check HTML produces something
            /// </summary>
            [TestCaseSource(typeof(HtmlStatementImplementationProvider))]
            public void RenderHtmlTest(IHtmlVideoStore implementation)
            {
                Assert.IsNotEmpty(implementation.HtmlStatement(_invoice, _plays));
            }

            /// <summary>
            /// The book example passes in JSON. In C# it's much more natural to deal
            /// with classes but let's prove here that we could have consumed JSON
            /// and got the same result.
            /// </summary>
            [TestCaseSource(typeof(StatementImplementationProvider))]
            public void FromJsonRenderPlainTextTest(IVideoStore implementation)
            {
                string invoiceJson = JsonSerializer.Serialize(_invoice);

                string playsJson = JsonSerializer.Serialize(_plays);

                // Prove that if we worked from JSON and converted into of objects we would get same result
                Assert.AreEqual(
                    implementation.Statement(_invoice, _plays),
                    implementation.Statement(
                        JsonSerializer.Deserialize<Invoice>(invoiceJson),
                            JsonSerializer.Deserialize<IImmutableDictionary<string, Play>>(playsJson)));
            }
        }

        #region privates
        private class StatementImplementationProvider : IEnumerable<IVideoStore>
        {
            public IEnumerator<IVideoStore> GetEnumerator()
            {
                yield return new VideoStore0BeforeRefactor();
                yield return new VideoStore1DecomposeMethod();
                yield return new VideoStore2RemoveVariable();
                yield return new VideoStore3ExtractMethod();
                yield return new VideoStore4RemoveVariable();
                yield return new VideoStore5RemoveLoops();
                yield return new VideoStore6SplitPhase();
                yield return new VideoStore7Polymorphism();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        private class HtmlStatementImplementationProvider : IEnumerable<IHtmlVideoStore>
        {
            public IEnumerator<IHtmlVideoStore> GetEnumerator()
            {
                yield return new VideoStore6SplitPhase();
                yield return new VideoStore7Polymorphism();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
        #endregion

    }
}