using Xunit.Abstractions;

namespace FileLoader.Tests
{
    public class MetadataFileLoadTests
    {
        private readonly ITestOutputHelper _testOutputHelper;
        public MetadataFileLoadTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Theory]
        [InlineData("../../testdata/Model/Metadata/example.json")]
        [InlineData("testdata/Model/Metadata/example.metadata.json")]
        public void EmbeddedFile_ShouldExist(string filePath)
        {
            string[] resources = ResourceLoaderHelper.GetResourceNames();
            foreach (string resource in resources)
            {
                _testOutputHelper.WriteLine("Resource: {0}", resource);
            }

            string file = ResourceLoaderHelper.LoadTestDataAsString(filePath);
            Assert.NotNull(file);
        }





    }
}
