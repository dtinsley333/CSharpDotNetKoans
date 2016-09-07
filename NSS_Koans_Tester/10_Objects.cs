﻿

using Xunit;
using NSS_Koans;

namespace NSS_Koans_Tester
{
    public  class Piano
    {
        public int NumberOfKeys { get; set; } 
        public string Brand { get; set; }
        public bool Acoustic { get; set; }
        public string Material { get; set; }
        public double Cost { get; set; }
    }
    
    public class DrumSet
    {
        public int NumberOfDrums { get; set; }
        public string Color { get; set; }
        public bool HasSticks { get; set; }

        public DrumSet ()//This is a constructor
        {
            NumberOfDrums = 6;
            Color = "Red";
            HasSticks = true;
        }

    }

    public class Guitar
    {
        public int Length { get; set; }
        public string Brand { get; set; }
        public bool Acoustic { get; set; }
        public string Material { get; set; }
        public double Cost { get; set; }

        public Guitar(int length, string brand, bool acoustic, double cost)
        {
            Length = length;
            Brand = brand;
            Acoustic = acoustic;
            Cost = cost;
        }
    }
   
    public class AboutObjects : Koan
    {
       //In addition to demonstrating how objects work, the test in this exercise demonstrate how you can test objects  you create in your own TDD code
        [Fact]
        public void AboutObjectsCanCreateAPiano()
        {
            Piano steinway = new Piano();
            Assert.Equal(steinway,null); //Change null to make this test pass
        }

        [Fact]
        public void AboutObjectsCanCreateAPianoWithProperties()
        {
            Piano knabe = new Piano() { NumberOfKeys = 88, Brand = "Knabe", Acoustic = true, Material = "Mahogany", Cost = 321.76 };
            Assert.Equal(FILL_ME_IN, knabe.NumberOfKeys);
            Assert.Equal(FILL_ME_IN, knabe.Brand);
            Assert.Equal(FILL_ME_IN, knabe.Acoustic);
            Assert.Equal(FILL_ME_IN, knabe.Material);
            Assert.Equal(FILL_ME_IN, knabe.Cost);
        }


        [Fact]
        public void AboutObjectsCanDefinePropertiesAfterInitialized()
        {
            Piano steinway = new Piano();
            steinway.NumberOfKeys = 85;
            steinway.Brand = "Steinway";
            steinway.Acoustic = false;
            steinway.Material = "Walnut";
            steinway.Cost = 1299.99;

            Assert.Equal(FILL_ME_IN, steinway.NumberOfKeys);
            Assert.Equal(FILL_ME_IN, steinway.Brand);
            Assert.Equal(FILL_ME_IN, steinway.Acoustic);
            Assert.Equal(FILL_ME_IN, steinway.Material);
            Assert.Equal(FILL_ME_IN, steinway.Cost);
        }

        [Fact]
        public void ObjectsCanBeCreatedWithDefaultProperites()
        {
            DrumSet drums = new DrumSet();
            Assert.Equal(FILL_ME_IN, drums.NumberOfDrums);
            Assert.Equal(FILL_ME_IN, drums.Color);
            Assert.Equal(FILL_ME_IN, drums.HasSticks);
        }

        [Fact]
        public void PropertiesOfObjectsCanGetOverrided()
        {
            DrumSet drums = new DrumSet();

            drums.NumberOfDrums = 8;
            drums.Color = "FILL_ME_IN";
            drums.HasSticks = false;

            Assert.Equal(FILL_ME_IN, drums.NumberOfDrums);
            Assert.Equal("blue", drums.Color);
            Assert.Equal(FILL_ME_IN, drums.HasSticks);
        }

        [Fact]
        public void AboutObjectCanInitializeObjectsWithPropertiesDefined()
        {
            Guitar rockStar = new Guitar(40, "Fender", false, 59.99);
            Assert.Equal(FILL_ME_IN, rockStar.Length);
            Assert.Equal(FILL_ME_IN, rockStar.Brand);
            Assert.Equal(FILL_ME_IN, rockStar.Acoustic);
            Assert.Equal(FILL_ME_IN, rockStar.Cost);
        }
    }
}
