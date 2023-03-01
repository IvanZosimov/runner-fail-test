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
        [InlineData("Model/Metadata/example.json")]
        [InlineData("Model/Metadata/example.metadata.json")] 
        [InlineData("Model/Metadata/new.metadata.json")] 
        public void EmbeddedFile_ShouldExist(string filePath)
        {
            string file = ResourceLoaderHelper.LoadTestDataAsString(filePath);
            Assert.NotNull(file);
        }
        
        
        [Fact]
        public void Print_All_Resources()
        {
            string[] resources = ResourceLoaderHelper.GetResourceNames();
            foreach (string resource in resources)
            {
                _testOutputHelper.WriteLine(resource);
            }
        }
    }
}
