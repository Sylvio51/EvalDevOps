using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSampleCode_Tests
{
    public class HtmlFormatHelperTests
    {
        private HtmlFormatHelper _htmlFormatHelper;

        public HtmlFormatHelperTests()
        {
            _htmlFormatHelper = new HtmlFormatHelper();
        }

        public void GetStrongFormat_ShouldReturnStrongHtmlElement()
        {
            var content = "Test Content";

            var result = _htmlFormatHelper.GetStrongFormat(content);

            Assert.Equal("<strong>Test Content</strong>", result);
        }

        public void GetItalicFormat_ShouldReturnItalicHtmlElement()
        {
            var content = "Test Content";

            var result = _htmlFormatHelper.GetItalicFormat(content);

            Assert.Equal("<i>Test Content</i>", result);
        }

        public void GetFormattedListElements_ShouldReturnListOfHtmlListItems()
        {
            var contents = new List<string> { "Item 1", "Item 2", "Item 3" };

            var result = _htmlFormatHelper.GetFormattedListElements(contents);

            var expected = "<ul><li>Item 1</li><li>Item 2</li><li>Item 3</li></ul>";
            Assert.Equal(expected, result);
        }

        public void GetFormattedListElements_ShouldReturnEmptyListIfNoItems()
        {
            var contents = new List<string>();

            var result = _htmlFormatHelper.GetFormattedListElements(contents);

            var expected = "<ul></ul>";
            Assert.Equal(expected, result);
        }
    }
}
