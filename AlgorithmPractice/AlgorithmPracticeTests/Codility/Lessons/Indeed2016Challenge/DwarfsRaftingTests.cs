using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmPractice.Codility.Lessons.Indeed2016Challenge.Tests
{
    [TestClass()]
    public class DwarfsRaftingTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var N = 4;
            var S = "1B 1C 4B 1D 2A";
            var T = "3B 2D";
            var actual = DwarfsRafting.Solution(N, S, T);
            var expected = 6;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest1()
        {
            var N = 2;
            var S = "2A";
            var T = "";
            var actual = DwarfsRafting.Solution(N, S, T);
            var expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest2()
        {
            var N = 4;
            var S = "1B 1A 2A";
            var T = "3C 4C";
            var actual = DwarfsRafting.Solution(N, S, T);
            var expected = -1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest3()
        {
            var N = 2;
            var S = "";
            var T = "1B";
            var actual = DwarfsRafting.Solution(N, S, T);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [TestMethod()]
        public void SolutionTest4()
        {
            var N = 12;
            var S = "11C 10J 9C 8I 7D 1J 12I 2K";
            var T = "11D 4F 4B 3E 3J 7C 7G 1C 2C 2G 3I 9J 6G 11E 11G 2L 10L 12D 9A 10I 6J 8F 11I 12J 11A 5G 7J 3K 4E 4K";
            var actual = DwarfsRafting.Solution(N, S, T);
            var expected = 102;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest5()
        {
            var N = 18;
            var S = "5P 7M 8J 2O 6R 4P 6N 4R 5M 2M 2R 9L 8N 9Q 9R 6M 9J 8R 9N 1O 7L 2K 9P 3J 3K 4M 6P 1L 8K 6L 1K 2J 4J 8O 5O 5K 2L 7Q 3L 7N 3N 4O 8P 3R 4K 6Q 7O 7P 1R 8M 2N 6J 6O 3P 3O 9K 5J 2P 9O 5N 5Q 1J 7J 7R 4Q 8L 3Q 1N 4L 7K 5R 1Q 1M 1P 5L 9M 2Q 4N 8Q 6K 3M 15H 18B 10E 16C 14A 11H 11C 13D 12E 16E 16I 10A 16G 13H 12C 13E 18A 10B 16B 15I 17B 15C 14C 10D 11I 14G 17A 12I 14D 18G 12G 10I 13F 15E 14I 18C 10H 18D 17C 17G 14B 15B 13I 14H 10C 12H 17H 18I 16H 17D 11F 12D 16D 11B 11E 15D 12B 12F 18E 16F 14F 15A 13C 13A 13B 10G 11D 17F 16A 13G 14E 18F 11A 11G 15F 18H 10F 17E 17I 12A 15G";
            var T = "";
            var actual = DwarfsRafting.Solution(N, S, T);
            var expected = 162;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest6()
        {
            var N = 22;
            var S = "6B 6H 4I 7G 10B 2D 8C 5G 6C 4C 7H 3G 6A 9B 2F 6I 4A 8B 4B 11G 7B 7E 9J 1B 6K 2B 7A 10F 1F 9I 4K 6E 8D 10K 9C 8F 1D 1G 10E 7J 4J 1I 7K 7D 11B 10J 6J 2C 7I 3F 11A 11D 5D 9A 7F 6D 1H 2G 10C 3C 6G 2H 5B 5K 2J 2K 8A 1E 10D 5C 5I 5H 4G 7C 1A 5J 10A 5A 3I 4H 11F 3D 9G 4D 1J 3A 8G 2E 11J 1K 8I 5F 11C 4E 6F 3E 9F 8H 3K 2I 11I 10H 8E 3J 5E 11H 3B 11E 9H 2A 8K 3H 9D 11K 9E 10I 4F 8J 1C 10G 9K 12M 18S 22T 16T 18N 13N 20O 22R 20N 13O 22U 21S 14N 13S 15R 18T 14R 17S 12Q 15Q 22O 12V 20M 19S 20Q 14M 17P 12N 14S 15O 20T 19Q 22L 22Q 12P 21P 17R 15N 17T 21Q 16O 22P 21O 13P 12T 13T 16Q 14U 16P 17N 17Q 22M 17O 21R 14O 20U 18Q 20S 13R 15T 19P 22S 15U 21M 14L 12R 14V 20L 15S 13M 17V 22N 15M 17L 19U 13U 16S 19L 18U 16N 21T 19M 19V 22V 20R 15P 12O 21L 15V 16M 21U 21V 17U 13L 14Q 16V 18R 14T 13Q 12S 19R 20P 18L 17M 16L 20V 18P 18M 19T 21N 18V 16R 19N 19O 14P 15L 18O 16U 12L 12U 13V";
            var T = "";
            var actual = DwarfsRafting.Solution(N, S, T);
            var expected = 242;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest7()
        {
            var N = 20;
            var S = "7C 8Q 15B 18P 9C 18S 13Q 20N 18G 20B 5Q 5D 2H 4P 1S 6R 18C 2R 16R 20R 12G 14K 3C 1C 3L 1N 6E 10F 13B 3A 3Q 5L 11K 17E 9H 11N 1D 14H 16C 7S 8P 9R 14N 17T 4I 6A 4G 18Q 19E 11I";
            var T = "17S 4T 2B 14O 13D 4O 8T 4J 2N 8A 1P 6S 19B 13F 13M 15K 5P 10O 10D 12M 20F 1L 18I 20S 9A 16K 2C 6F 14I 3I 2K 14G 10R 3H 13N 4B 15R 12L 13C 6G 7N 14B 16O 13S 16E 4L 6T 4N 15G 18F 16F 14M 3P 9D 5N 19D 18E 9T 17I 4H 8K 11J 11D 11P 20I 11G 12T 19H 20K 5J 13G 14C 11C 7G 14J 13T 19A 20J 14A 20O";
            var actual = DwarfsRafting.Solution(N, S, T);
            var expected = 266;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SolutionTest8()
        {
            var N = 24;
            var S = "15F 18I 24P 1H 21X 9H 14C 15V 10T 24A 19J 23M 12J 14G 2H 12C 18D 6U 23F 19N 5W 15D 23S 4X 11T 3L 3W 21S 8F 13C 21J 16F 24R 12K 8E 22B 22D 1G 20C 23P 14F 19V 17X 1O 22F 13B 8H 24E 2X 7R 1W 16L 17H 24T 22P 1S 10C 13X 17Q 3I 13U 24B 16V 21W 20L 2U 17G 17I 6K 20B 21M 20E 9J 14X 1N 11E 12V 17U 23D 19T 16O 11N 16H 8G 15E 10X 21O 15T 20M 3V 21D 21I 20R 1E 18U 23L 17F 18C 9Q 19L 18V 9W 23J 8I 1M 15H 11F 6N 16M 18N 1P 6S 9E 8Q 9F 10K 18W 15O 22R 22T 16E 4F 4R 5V 20Q 24N 17E 23C 5E 16U 10N 5J 12T 8V 7J 11R 6A 15M 23E 8L 14A 21B 24L 20U 7P 6F 14H 24I 5B 22W 6R 15N 23G 18M 7O 5U 15W 22X 3X 13J 22Q 13R 16J 11G 7V 2I 1C 13I 5Q 2R 10D 8R 6P 3S 21A 12E 20I 3O 20W 1Q 16R 4Q 3J 19R 5F 17B 3F 13T 22C 23R 5S 24V 12G 3R 1I 22U 19Q 1J 18G 19U 12W 11Q 16X 9T 12U 9M 5R 11L 23V 9N 2N 2W 19W 19S 8D 1K 1A 14E 12A 13A 17K 7N 23X 4T 7L 19I 9C 14B 21Q 3H 10S 3N 2A 6J 10B 15B 13D 15U 3B 20K 21R 4E 24O 4U 10W 16Q 11U 1L 15S 24X 16W 22K 15X 20H 19X 3E 12O 11H 9P 18B 6B 22G 12M 3U 14T 21T 16K 5H 1X 19O 8S 1R 9U 23O 17J 20N 9O 24D 7X 22S 12H 24W 13N 18X 15R 14U 15P 17V 23B 9A 5K 10J 10Q 2G 3D 16T 20X 3G 13G 7T 23H 22A 9G 18E 24K 23W 2J 11V 15G 6E 4N 11X 23K 8U 12B 7K 7E 23U 4H 6T 14N 10R 5G 10O 13S 15K 9L 14J 3T 8J 13P 7F 8N 12D 17T 5O 17C 7Q 23Q 4V 5X 3K 16P 24H 17M 15L 18S 8K 14R 4W 2Q 19A 8O 17L 3C 16G 18T 24F 14M 15Q 21G 17S 10A 1B 23N 24J 13L 18H 4J 24S 5T 18A 6M 1T 10F 16I 21N 7M 6H 11P 2M 20F 21L 24U 4O 21V 22H 10U 11D 24Q 15I 12F 20A 15J 12N 19D 5A 4B 10L 13V 18R 20S 5N 6G 22V 21K 6I 1F 9B 13K 19B 16C 12R 17A 2V 24M 4G 24G 7W 13F 22O 12I 3M 1V 19F 11S 23A 11O 20V 19G 2P 3P 2B 7S 8P 4C 18P 2D 4D 16D 6X 11M 2E 8X 2T 2C 22N 8B 21U 7U 20J 8M 17D 21E 3Q 6C 13O 19K 18O 20O 4L 17R 14V 10V 5C 21F 18L 8T 19P 9X 11C 17N 11I 22M 8A 16N 11A 12Q 23I 4A 4P 5I 18K 17O 23T 20D 17W 14P 7C 19M 11B 22E 10I 13W 7B 2S 7G 12X 20P 8W 14O";
            var T = "16S 4K 18Q 7H 17P 5M 7A 11K 11W 10E 20G 10M 10H 7D 22L";
            var actual = DwarfsRafting.Solution(N, S, T);
            var expected = 41;

            Assert.AreEqual(expected, actual);
        }
    }
}