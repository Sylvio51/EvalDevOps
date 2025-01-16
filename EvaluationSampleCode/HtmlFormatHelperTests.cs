using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using EvaluationSampleCode;

namespace EvaluationSampleCodeTests
{
    [TestClass]
    public class HtmlFormatHelperTests
    {
        private HtmlFormatHelper _htmlFormatHelper;

        [TestInitialize]
        public void Setup()
        {
            _htmlFormatHelper = new HtmlFormatHelper();
        }

        [TestMethod]
        public void TestGetStrongFormat_ShouldReturnCorrectHtml()
        {

            string content = "Hello, World!";
            string expected = "<strong>Hello, World!</strong>";


            string result = _htmlFormatHelper.GetStrongFormat(content);

   
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestGetItalicFormat_ShouldReturnCorrectHtml()
        {

            string content = "Test Text";
            string expected = "<i>Test Text</i>";


            string result = _htmlFormatHelper.GetItalicFormat(content);


            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestGetFormattedListElements_ShouldReturnCorrectHtmlList()
        {

            List<string> contents = new List<string> { "Item 1", "Item 2", "Item 3" };
            string expected = "<ul><li>Item 1</li><li>Item 2</li><li>Item 3</li></ul>";


            string result = _htmlFormatHelper.GetFormattedListElements(contents);


            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestGetFormattedListElements_ShouldReturnEmptyListWhenNoItems()
        {

            List<string> contents = new List<string>();
            string expected = "<ul></ul>";


            string result = _htmlFormatHelper.GetFormattedListElements(contents);

       
            Assert.AreEqual(expected, result);
        }
    }
}
